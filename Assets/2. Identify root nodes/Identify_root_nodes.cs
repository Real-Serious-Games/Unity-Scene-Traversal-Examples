using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Identify_root_nodes : MonoBehaviour
{

	void Start()
    {
        // Note that you can't execute this code in Awake.
        var rootObjects = SceneManager.GetActiveScene().GetRootGameObjects();
        foreach (var gameObject in rootObjects)
        {
            Debug.Log(gameObject.name);
        }

        /*
         * Pre Unity 5.3 code.
         * 
        GameObject[] allGameObjects = GameObject.FindObjectsOfType<GameObject>();

        foreach (var gameObject in allGameObjects)
        {
            if (gameObject.transform.parent == null)
            {
                // ... Do something with the root game object ...

                Debug.Log(gameObject.name);
            }
        }
        */
    }
}
