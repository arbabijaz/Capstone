using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiScript : MonoBehaviour
{
    public Canvas canvas;
    public GameObject playUi;
    public GameObject restartButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void play()
    {
        playUi.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(true);

    }
    public void restart()
    {
        SceneManager.LoadScene(0);
        
    }
}
