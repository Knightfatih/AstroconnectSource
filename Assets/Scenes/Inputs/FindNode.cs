using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindNode : MonoBehaviour
{
    public float range = 5f;
    public Node lastNode = null;
    public Node startNode;
    public float speed = 1f;

    public float startTimebetween = 1.5f;
    float timeBetwween = 0f;
    bool canJump = false;

    Vector2 startPos;
    Vector2 endPos;

    public DrawLines lineRenderer;
    public Level levelManager;

    [Header("LIFES/Number of Moves")]
    public int lives = 15;
    public int startLives = 15;


    [Header("Sound Effects")]
    public AudioSource startMoveSound;

    // Start is called before the first frame update
    void Start()
    {
        lives = startLives;
        levelManager = gameObject.GetComponentInParent<Level>();

        lastNode = startNode;
        transform.position = startNode.transform.position;
        lastNode.GetComponent<Collider2D>().enabled = false;
        lineRenderer.listOfNodes.Add(lastNode);
    }

    // Update is called once per frame
    void Update()
    {
        CooldownLoop();
    }


    public void DrawRay(Vector2 dir)
    {
        if (canJump)
        {


            // Debug.Log(dir);

            if (dir != Vector2.zero)
            {


                Debug.DrawRay(transform.position, dir * range);


                if (Physics2D.Raycast(transform.position, dir * range))
                {
                    RaycastHit2D hit = Physics2D.Raycast(transform.position, dir * range, range);

                    if (hit.collider != null)
                    {

                        Debug.DrawLine(transform.position, hit.collider.gameObject.transform.position);
                        // Debug.Log(hit.collider.gameObject.name);



                        // Do Something


                        if (hit.collider.gameObject.GetComponent<Node>() != null) // if it is a node 
                        {
                            lastNode.GetComponent<Collider2D>().enabled = true;
                            lastNode = hit.collider.GetComponent<Node>();
                            lineRenderer.listOfNodes.Add(lastNode);
                            levelManager.CheckLevel();
                            lastNode.GetComponent<Collider2D>().enabled = false;
                            canJump = false;
                            timeBetwween = 0f;



                            //  transform.position = lastNode.transform.position; // Move

                            startPos = transform.position;
                            endPos = lastNode.transform.position;


                            lives--; // Lose a life every time you move

                            if (lives >= 1)
                            {

                            StartCoroutine("lerpNodes");
                            }
                            
                            LifeCheck();

                        }

                    }
                }
            }
        }
    }

    void CooldownLoop()
    {
        if (timeBetwween > startTimebetween)
        {
            canJump = true;
        }
        else
        {
            timeBetwween += Time.deltaTime;
        }
    }



    IEnumerator lerpNodes()
    {
        /// Sound for Movement ##############
        /// 
        startMoveSound.Play(0);


        for (float i = 0; i < 1;)
        {
            transform.position = Vector2.Lerp(startPos, endPos, i);

            i += Time.deltaTime * speed;

           yield return new WaitForEndOfFrame();
        }


    }

    void LifeCheck()
    {
        if (lives < 1)
        {
            // end level

            Debug.Log("lives = " + lives);
            levelManager.RestartLevel();

        }
    }

}
