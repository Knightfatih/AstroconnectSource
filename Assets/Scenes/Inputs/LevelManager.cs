using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public List<Level> listOfLevels = new List<Level>();
    public List<Level> listOfNewLevels = new List<Level>();

    public float camaeraSizeSpeed = 1f;

    int currentLevelIndex = 0;
    Level curretLevel;
    MoveCameraPos cameraManager;
    public AudioSource newLevelSound;

    // Start is called before the first frame update
    void Start()
    {
        cameraManager = gameObject.GetComponent<MoveCameraPos>();

        curretLevel = listOfLevels[currentLevelIndex];
        listOfNewLevels = listOfLevels;

        foreach (var item in listOfNewLevels)
        {
            item.GetComponentInChildren<FindNode>().enabled = false;
        }

        curretLevel.GetComponentInChildren<FindNode>().enabled = true;

        CameraTarget target = curretLevel.GetComponentInChildren<CameraTarget>();
        cameraManager.MoveCam(target.transform.position);


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            NewLevel();
        }
    }


    public void NewLevel()
    {
        if (listOfNewLevels.Count > 1) // If theres a level left to play
        {
            listOfNewLevels.Remove(curretLevel);
            curretLevel.GetComponentInChildren<FindNode>().enabled = false;


            int randomInt = Random.Range(0, listOfNewLevels.Count);
            //      Debug.Log("new leves avalible" + listOfNewLevels.Count);
            //      Debug.Log("levels total" + listOfLevels.Count);

            //     Debug.Log(randomInt);

            curretLevel = listOfNewLevels[randomInt];
            Debug.Log(curretLevel.gameObject.name);
            curretLevel.GetComponentInChildren<FindNode>().enabled = true;




            /// Theres a new Level now MOVE CAMERA ACTIVATE PLAYER
            /// 

            CameraTarget target = curretLevel.GetComponentInChildren<CameraTarget>();
            cameraManager.MoveCam(target.transform.position);

            // Play Audio new Level
            newLevelSound.Play(0);

        }
        else
        {
            EndGame();
        }
    }


    void EndGame()
    {
        Debug.Log("EndGame");

        

        cameraManager.MoveCam(Vector2.zero);
        StartCoroutine(lerpCamSize(32));
        StartCoroutine(ReturnToMenu());
    }

    IEnumerator lerpCamSize(float size)
    {

        float startSize = cameraManager.cam.orthographicSize;
        float calc;

        for (float i = 0; i < 1;)
        {
            calc = Mathf.Lerp(startSize, size, i);
            cameraManager.cam.orthographicSize = calc;
            i += Time.deltaTime * camaeraSizeSpeed;

            yield return new WaitForEndOfFrame();
            
        }



        // Enable UI Element here for game over


    }

    IEnumerator ReturnToMenu()
    {
        yield return new WaitForSeconds(15);
        LoadMainMenu();

    }

    private void LoadMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }


    public void RestartCurrentLevel()
    {
        curretLevel.RestartLevel();
    }

}
