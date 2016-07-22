using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Post_order_traversal : MonoBehaviour {

    void PostOrderTraversal(GameObject parentGameObject)
    {
        foreach (Transform childTransform in parentGameObject.transform)
        {
            var childGameObject = childTransform.gameObject;
            PostOrderTraversal(childGameObject); // Recursion! 
        }

        // ... Do something with the parent game object after traversing the children ...
        Debug.Log(parentGameObject.name);
    }

    void Start ()
    {
        foreach (var rootGameObject in SceneManager.GetActiveScene().GetRootGameObjects())
        {
            PostOrderTraversal(rootGameObject);
        }
    }
}
