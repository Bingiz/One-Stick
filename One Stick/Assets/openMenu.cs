using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class openMenu : MonoBehaviour
{
    public GameObject pauseScreen;

    bool paused = false;



    // Start is called before the first frame update
    void Start()
    {
        pauseScreen = GameObject.Find("PauseScreen");
        pauseScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Cancel")){
            pauseScreen.SetActive(!paused);
            paused = !paused;
            if(paused){
                Time.timeScale=0;
                Camera.main.GetComponent<PlayerFollow>().enabled = !paused;
            } else{
                Time.timeScale=1;
                Camera.main.GetComponent<PlayerFollow>().enabled = !paused;
            }
        }
    }
}
