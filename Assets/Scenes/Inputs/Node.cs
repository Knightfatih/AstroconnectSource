using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public bool onPath = false;

    private void Start()
    {
        if (onPath)
        {
            gameObject.GetComponentInParent<Level>().requiredPath.Add(this);
        }
    }
}
