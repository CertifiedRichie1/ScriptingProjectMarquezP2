using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CheckState : MonoBehaviour
{
    public GameObject myObject;
    // Start is called before the first frame update

    void Start()
    {
        Debug.Log("Active Self: " + myObject.activeSelf);
        Debug.Log("Active in HierarchyDropFlags" + myObject.activeInHierarchy);
    }
}