using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Threading.Tasks;
using TMPro;

public class SearchScript : MonoBehaviour {
    public GameObject ErrorScreen;
    public GameObject LoadingScreen;
    public GameObject SearchFieldObject;

    public GameObject ContainerObject;
    public GameObject HudContainerObject;
    public Terrain Terrain;

    public UIPrefabs UIPrefabs;

    void Start() {
        StartCoroutine(GetRequest("rikarin.org/index.dtml"));
    }

    public void ToggleSearch() {
        var isOpen = SearchFieldObject.activeSelf;
        SearchFieldObject.SetActive(!isOpen);

        if (isOpen) {
            var text = SearchFieldObject.transform.GetChild(0).GetComponent<TMP_InputField>().text;
            StartCoroutine(GetRequest(text));
        }
    }

    IEnumerator GetRequest(string url) {
        ErrorScreen.SetActive(false);
        LoadingScreen.SetActive(true);

        var request = UnityWebRequest.Get(url);
        yield return request.SendWebRequest();

        if (request.isNetworkError) {
            LoadingScreen.SetActive(false);
            ErrorScreen.SetActive(true);

            Debug.Log("Error While Sending: " + request.error);
        } else {
            var parser = new DtmlParser(request.downloadHandler.text);
            parser.Parse();

            var interpreter = new Interpreter(ContainerObject, HudContainerObject, Terrain, UIPrefabs);
            parser.Dtml.Accept(interpreter);

            LoadingScreen.SetActive(false);
        }
    }
}
