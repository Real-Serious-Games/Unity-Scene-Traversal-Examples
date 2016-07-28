using UnityEngine;
using System.Collections;
using RSG.Scene.Query;

public class Scene_Traversal_API_Examples : MonoBehaviour {

	void Start () {

        var sceneTraversal = new SceneTraversal();

        Debug.Log("Enumerate root game objects:");

        foreach (var gameObject in sceneTraversal.RootNodes())
        {
            Debug.Log(gameObject.name);
        }

        Debug.Log("Get parent game object:");

        var parentGameObject = GameObject.Find("L2.B").Parent();
        Debug.Log(parentGameObject.name);


        Debug.Log("Get root game object:");

        var rootGameObject = GameObject.Find("L2.B").RootObject();
        Debug.Log(rootGameObject.name);

        Debug.Log("Enumerate children:");

        foreach (var childGameObject in GameObject.Find("L1.B").Children())
        {
            Debug.Log(childGameObject.name);
        }

        Debug.Log("Enumerate scene (pre-order):");

        foreach (var gameObject in sceneTraversal.PreOrderHierarchy())
        {
            Debug.Log(gameObject.name);
        }

        Debug.Log("Enumerate scene (post-order):");

        foreach (var gameObject in sceneTraversal.PreOrderHierarchy())
        {
            Debug.Log(gameObject.name);
        }

        Debug.Log("Enumerate descendents (all game objects in a sub-tree):");

        foreach (var descendentGameObject in GameObject.Find("L1.B").Descendents())
        {
            Debug.Log(descendentGameObject.name);
        }

        Debug.Log("Enumerate ancestors of a game object:");

        foreach (var ancestorGameObject in GameObject.Find("L3.B").Ancestors())
        {
            Debug.Log(ancestorGameObject.name);
        }
    }
}
