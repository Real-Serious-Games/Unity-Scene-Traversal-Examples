using UnityEngine;
using System.Collections;

public class Identify_root_nodes : MonoBehaviour
{

	void Start ()
    {
        GameObject[] allGameObjects = GameObject.FindObjectsOfType<GameObject>();

        foreach (var gameObject in allGameObjects)
        {
            if (gameObject.transform.parent == null)
            {
                // ... Do something with the root game object ...

                Debug.Log(gameObject.name);
            }
        }
    }
}
