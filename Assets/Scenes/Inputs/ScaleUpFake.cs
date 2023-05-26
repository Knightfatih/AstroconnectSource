using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleUpFake : MonoBehaviour
{
    // Start is called before the first frame update

    public ScaleManager scaleMan;

    public float scaleMod = 1f;

    public Transform target;

    void Start()
    {

        if (GetComponentInParent<ScaleManager>() != null)
        {
            scaleMan = GetComponentInParent<ScaleManager>();


            target.localScale = Vector3.one * scaleMan.scaleMod;

        }

    }

    // Update is called once per frame
    void Update()
    {
        if (scaleMan != null)
        {
            // scaleMan = GetComponentInParent<ScaleManager>();


            target.localScale = Vector3.one * scaleMan.scaleMod;

        }

    }

}
   
