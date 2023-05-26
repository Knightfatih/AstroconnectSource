using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLines : MonoBehaviour
{

    public LineRenderer lineRenderer;
    public List<Node> listOfNodes = new List<Node>();


    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = gameObject.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        List<Vector3> listOfPos = new List<Vector3>();
        foreach (var item in listOfNodes)
        {
            listOfPos.Add(item.gameObject.transform.position);
        }
       Vector3[] arrayOfPos = listOfPos.ToArray();

        lineRenderer.positionCount = arrayOfPos.Length;
        lineRenderer.SetPositions(arrayOfPos);
    }
}
