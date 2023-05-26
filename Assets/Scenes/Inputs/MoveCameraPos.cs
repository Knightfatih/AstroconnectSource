using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraPos : MonoBehaviour
{
    public Camera cam;
    public float speed = 5f;

    Vector3 offset = new Vector3(0, 0, -10);

    // Start is called before the first frame update
    void Awake()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoveCam(Vector2 targetPos)
    {
        StartCoroutine(Move(targetPos, cam.transform.position));
    }

    IEnumerator Move(Vector2 targetPos, Vector2 startPos)
    {
        targetPos = new Vector3(targetPos.x, targetPos.y, 0);
        startPos = new Vector3(startPos.x, startPos.y, 0);


        for (float i = 0; i < 1;)
        {
            cam.transform.position = Vector3.Lerp(startPos, targetPos, i) + offset;

                i += Time.deltaTime * speed;

            yield return new WaitForEndOfFrame();


        }
    }
}
