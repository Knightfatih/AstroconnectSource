using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StoryManager : MonoBehaviour
{
#pragma warning disable 0649
    [SerializeField] private LineRenderer[] lineRends = new LineRenderer[3];
    [SerializeField] private Text storyText;
    [SerializeField] private ParticleSystemRenderer[] particles = new ParticleSystemRenderer[7];
    [SerializeField] private GameObject storyPanel;
    [SerializeField] private GameObject controlsPanel;
#pragma warning restore 0649

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < particles.Length; i++)
        {
            Color particleColor = particles[i].material.GetColor("_TintColor");
            particles[i].material.SetColor("_TintColor", new Color(particleColor.r, particleColor.g, particleColor.b, 0));
        }

        storyText.color = new Color(1, 1, 1, 0);

        StartCoroutine("StoryTransitions");

        storyPanel.SetActive(true);
        controlsPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator StoryTransitions()
    {
        yield return new WaitForSeconds(3f);
        yield return StartCoroutine("FadeOut");
        yield return StartCoroutine("FadeInStars");
        yield return StartCoroutine("FadeInText");
        yield return new WaitForSeconds(3f);
        LoadControls();
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("GameSelect");
    }

    private IEnumerator FadeOut()
    {
        float elapsedTime = 0;
        float endTime = 3f;
        float endPos = 0f;
        Material lineMat = lineRends[0].material;
        Color lineColor = lineMat.GetColor("_TintColor");
        float startPos = lineColor.a;

        while (elapsedTime < endTime)
        {
            for (int i = 0; i < lineRends.Length; i++)
            {
                lineRends[i].material.SetColor("_TintColor", new Color(lineColor.r, lineColor.g, lineColor.b, Mathf.Lerp(startPos, endPos, elapsedTime / endTime)));
            }

            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }

    private IEnumerator FadeInStars()
    {
        float elapsedTime = 0;
        float endTime = 2f;
        float endPos = 1f;
        Color starColor = particles[0].material.GetColor("_TintColor");
        float startPos = starColor.a;

        while (elapsedTime < endTime)
        {
            for (int i = 0; i < particles.Length; i++)
            {
                particles[i].material.SetColor("_TintColor", new Color(starColor.r, starColor.g, starColor.b, Mathf.Lerp(startPos, endPos, elapsedTime / endTime)));
            }

            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }

    private IEnumerator FadeInText()
    {
        float elapsedTime = 0;
        float endTime = 2f;
        float endPos = 1f;
        float startPos = storyText.color.a;

        while (elapsedTime < endTime)
        {
            storyText.color = new Color (1, 1, 1, Mathf.Lerp(startPos, endPos, elapsedTime / endTime));
            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }

    private void LoadControls()
    {
        storyPanel.SetActive(false);
        controlsPanel.SetActive(true);
    }
}
