using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Vidéo : MonoBehaviour
{
    public VideoPlayer Vp;
    // Start is called before the first frame update

    void Update()
    {
        if (Vp.time >= Vp.clip.length)
        {
            Application.Quit();
        }
    }
}
