using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnEnterLoadScene : MonoBehaviour
{

    public string sceneName;
    public FindNode targetPlayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckPlayer();
    }

    void CheckPlayer()
    {

        Vector2 calc = transform.position - targetPlayer.transform.position;

        if (calc.sqrMagnitude < 1)
        {
            StartCoroutine(LoadTargetScene());
        }
    }


    IEnumerator LoadTargetScene()
    {
        yield return new WaitForSeconds(2);
        Time.timeScale = 1f;

        SceneManager.LoadScene(sceneName);
        Debug.Log(sceneName);
        yield return null;
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, 1f);
    }

}
