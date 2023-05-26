using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Level : MonoBehaviour
{
    public FindNode player;
    public DrawLines lineRenderer;
    private LevelManager manager;

    public List<Node> requiredPath = new List<Node>();

    
    // Start is called before the first frame update
    void Awake()
    {
        manager = gameObject.GetComponentInParent<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            RestartLevel();
        }


    }


    public void CheckLevel()
    {
        CountMatches2(requiredPath, lineRenderer.listOfNodes.Distinct<Node>().ToList<Node>());
    }

    void FinishLevel()
    {
        Debug.Log("level Complete");
        player.enabled = false;

        manager.NewLevel();

    }

    public void RestartLevel()
    {
        player.lastNode = player.startNode;
        player.lives = player.startLives;
        player.transform.position = player.startNode.transform.position;

        lineRenderer.listOfNodes.Clear();
        lineRenderer.listOfNodes.Add(player.startNode);

        Node[] nodes  = gameObject.GetComponentsInChildren<Node>();
        foreach (var item in nodes)
        {
            item.GetComponent<Collider2D>().enabled = true;

        }

        player.startNode.GetComponent<Collider2D>().enabled = false;
    }


    static public int CountMatches(List<Node> required, List<Node> taken)
    {
        int numMatches = 0;
        int idx = 0;

        while (idx < required.Count && idx < taken.Count)
        {
            if (required[idx] == taken[idx])
            {
                numMatches++;
                idx++;
            }
            else
            {
                break;
            }
        }

        return numMatches;
    }

     public void CountMatches2(List<Node> required, List<Node> taken)
    {

        int numMatches = 0;
        foreach (var requiredItem in required)
        {
            foreach (var takenItem in taken)
            {
                if (requiredItem == takenItem)
                {
                    numMatches++;
                }




            }
        }

        if (numMatches == required.Count)
        {
            FinishLevel();
        }

    }
}
