using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interpreter : IVisitor {
    readonly GameObject _container;
    readonly GameObject _hudContainer;
    readonly Terrain _terrain;
    readonly UIPrefabs _uiPrefabs;

    public Interpreter(GameObject container, GameObject hudContainer, Terrain terrain, UIPrefabs uiPrefabs) {
        _container = container;
        _hudContainer = hudContainer;
        _terrain = terrain;
        _uiPrefabs = uiPrefabs;
    }

    public void Visit(Dtml dtml) {
        Debug.Log($"DTML Version: {dtml.Version}");

        dtml.Configuraiton.Accept(this);
        dtml.Hud.Accept(this);
        dtml.World.Accept(this);
    }

    public void Visit(Configuraiton configuraiton) {
        configuraiton.Server.Accept(this);
        configuraiton.Size.Accept(this);
        configuraiton.Heightmap.Accept(this);
        configuraiton.Spawnpoint.Accept(this);

        foreach (var settings in configuraiton.Settings) {
            settings.Accept(this);
        }
    }

    public void Visit(Settings settings) {
        Debug.Log("settings " + settings.Name + " : " + settings.Value);
    }

    public void Visit(Server server) {
        Debug.Log("server " + server.Link);
    }

    public void Visit(Heightmap heightmap) {

    }

    public void Visit(Spawnpoint spawnpoint) {

    }

    public void Visit(Size size) {
        _terrain.terrainData.size = new Vector3(size.X, size.Z, size.Y);
    }



    public void Visit(Hud hud) {
        foreach (var button in hud.Buttons) {
            button.Accept(this);
        }
    }

    public void Visit(Button button) {
        Debug.Log("rendering button");
        var inst = GameObject.Instantiate(_uiPrefabs.ButtonPrefab);
        inst.transform.parent = _hudContainer.transform;
    }



    public void Visit(World world) {
        foreach (var script in world.Scripts) {
            VisitScript(script);
        }
        
        foreach (var box in world.Boxes) {
            box.Accept(this);
        }
    }

    public void Visit(Box box) {
        var obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        SetPrimitiveValues(box, obj);
    }

    public void Visit(Plane plane) {
        var obj = GameObject.CreatePrimitive(PrimitiveType.Plane);
        SetPrimitiveValues(plane, obj);
    }

    public void Visit(Sphere sphere) {
        var obj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        SetPrimitiveValues(sphere, obj);
    }

    public void Visit(Cylinder cylinder) {
        var obj = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        SetPrimitiveValues(cylinder, obj);
    }



    public async void VisitScript(string script) {
        // object result = await CSharpScript.EvaluateAsync(script);
        // Debug.Log(result.ToString()); 
    }







    void SetPrimitiveValues(Primitive primitive, GameObject obj) {
        obj.transform.parent = _container.transform;
        obj.transform.position = ParseCombinedValues(primitive.Position);
        obj.transform.Rotate(ParseCombinedValues(primitive.Rotation));
        obj.transform.localScale = ParseCombinedValues(primitive.Size);
    }







    Vector3 ParseCombinedValues(string values) {
        var vals = values.Split(' ');
        return new Vector3(float.Parse(vals[0]), float.Parse(vals[2]), float.Parse(vals[1]));
    }
}
