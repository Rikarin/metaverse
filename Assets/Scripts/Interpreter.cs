using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Threading.Tasks;
using System.Numerics;

public class Interpreter : IVisitor {
    readonly GameObject _container;
    readonly Terrain _terrain;

    public Interpreter(GameObject container, Terrain terrain) {
        _container = container;
        _terrain = terrain;
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
        _terrain.terrainData.size = new UnityEngine.Vector3(size.X, size.Z, size.Y);
    }



    public void Visit(Hud hud) {

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
        var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.parent = _container.transform;
        cube.transform.position = ParseCombinedValues(box.Position);
        //cube.transform.rotation = ParseCombinedValues(box.Rotation);
        cube.transform.localScale = ParseCombinedValues(box.Size);
    }



    public async void VisitScript(string script) {
        // object result = await CSharpScript.EvaluateAsync(script);
        // Debug.Log(result.ToString()); 
    }














    UnityEngine.Vector3 ParseCombinedValues(string values) {
        var vals = values.Split(' ');
        return new UnityEngine.Vector3(float.Parse(vals[0]), float.Parse(vals[2]), float.Parse(vals[1]));
    }
}
