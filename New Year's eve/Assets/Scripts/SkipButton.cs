using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipButton : MonoBehaviour
{
    public int waveCount, maxChildren;
    public bool last = false;
    public void OnSkipButton()
    {
        SceneManager.LoadScene("Scenes/MainLevel");
        GameLoop.waveCount = waveCount;
        GameLoop.maxChildren = maxChildren;
        GameLoop.last = last;
    }
}
