using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System.Linq;

public class Breath_first_traversal : MonoBehaviour
{

    IEnumerable<GameObject> GetChildren(IEnumerable<GameObject> hierarchyLevel)
    {
        foreach (var parentGameObject in hierarchyLevel)
        {
            foreach (Transform childTransform in parentGameObject.transform)
            {
                var childGameObject = childTransform.gameObject;
                yield return childGameObject;
            }
        }
    }

    void BreadthFirstTraversal(IEnumerable<GameObject> hierarchyLevel)
    {
        if (!hierarchyLevel.Any())
        {
            return;
        }

        foreach (var gameObject in hierarchyLevel)
        {
            // ... Do something with the game object ...
            Debug.Log(gameObject.name);
        }

        BreadthFirstTraversal(GetChildren(hierarchyLevel).ToArray());
    }

    void BreadthFirstTraversal()
    {
        BreadthFirstTraversal(SceneManager.GetActiveScene().GetRootGameObjects());
    }

    void Start ()
    {
        BreadthFirstTraversal();
    }
}
