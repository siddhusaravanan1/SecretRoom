using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonBehaviour : MonoBehaviour
{
    public GameObject play;
    public GameObject quit;
    public GameObject line1;
    public GameObject line2;
    public GameObject line3;
    public GameObject pause;
    public GameObject up;
    public GameObject down;
    public GameObject left;
    public GameObject right;
    public GameObject panel;
    public GameObject ghostPanel;
    public GameObject cluePanel;

    public bool canContinue;

    public PlayerBehaviour _pB;
    public void Play()
    {
        line1.SetActive(true);
        play.SetActive(false);
        quit.SetActive(false);
        StartCoroutine(Line1());
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Scene()
    {
        SceneManager.LoadScene("Prototype");
    }
    IEnumerator Line1()
    {
        yield return new WaitForSeconds(3f);
        line1.SetActive(false);
        line2.SetActive(true);
        canContinue = true;
    }
    public void Pause()
    {
        pause.SetActive(false);
        panel.SetActive(true);
        Time.timeScale = 0;
    }
    public void Resume()
    {
        pause.SetActive(true);
        panel.SetActive(false);
        Time.timeScale = 1;
    }
    public void GhostPanel()
    {
        ghostPanel.SetActive(false);
        up.SetActive(true);
        down.SetActive(true);
        left.SetActive(true);
        right.SetActive(true);
        pause.SetActive(true);
    }
    public void CluePanel()
    {
        cluePanel.SetActive(false);
        up.SetActive(true);
        down.SetActive(true);
        left.SetActive(true);
        right.SetActive(true);
        pause.SetActive(true);
    }
    public void Restart()
    {
        pause.SetActive(true);
        panel.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene("Prototype");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }
    private void Update()
    {
        if(Input.GetMouseButtonUp(0)&&canContinue)
        {
            line2.SetActive(false);
            line3.SetActive(true);
            canContinue = false;
        }
    }
}
