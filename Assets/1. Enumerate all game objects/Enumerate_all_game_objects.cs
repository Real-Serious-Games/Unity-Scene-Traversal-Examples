using UnityEngine;
using System.Collections;

public class Enumerate_all_game_objects : MonoBehaviour
{
	void Start ()
    {
        GameObject[] allGameObjects = GameObject.FindObjectsOfType<GameObject>();

        foreach (var gameObject in allGameObjects)
        {
            // ... Do something with the game object ...

            Debug.Log(gameObject.name);
        }
    }
}
