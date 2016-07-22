using UnityEngine;
using System.Collections;

public class Access_children : MonoBehaviour
{
	void Start ()
    {
        GameObject parentGameObject = GameObject.Find("L1.C");

        foreach (Transform childTransform in parentGameObject.transform)
        {
            var childGameObject = childTransform.gameObject;
            Debug.Log(childGameObject.name);
        }
    }
}
