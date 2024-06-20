using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipVideoScenes : MonoBehaviour
{
       // Update is called once per frame
       private void Start()
       {
           AudioManager.Instance.musicSource.Stop();
           AudioManager.Instance.PlayMusic("Main");
           AudioManager.Instance.PlayEffect("Bell");
       }

       void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            AudioManager.Instance.sfxSource.Stop();
            SceneManager.LoadScene(2);
        }
    }
}
