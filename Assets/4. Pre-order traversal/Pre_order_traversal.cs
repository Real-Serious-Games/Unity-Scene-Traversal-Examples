using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pre_order_traversal : MonoBehaviour {

    void PreOrderTraversal(GameObject parentGameObject)
    {
        // ... Do something with the parent game object before traversing the children ...
        Debug.Log(parentGameObject.name);

        foreach (Transform childTransform in parentGameObject.transform)
        {
            var childGameObject = childTransform.gameObject;
            PreOrderTraversal(childGameObject); // Recursion!
        }
    }

    void Start ()
    {
        foreach (var rootGameObject in SceneManager.GetActiveScene().GetRootGameObjects())
        {
            PreOrderTraversal(rootGameObject);
        }
    }
}
