using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MenuManager : MonoBehaviour
{
    Animator animator;
    public void OnStartButton()
    {
        animator.SetBool("Start", true);
        SceneManager.LoadScene("Scenes/MainLevel");
    }
    public void OnStoreButton()
    {
        animator.SetBool("Start", true);
        SceneManager.LoadScene("Scenes/Store");
    }
    public void OnExitButton()
    {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
    // Start is called before the first frame update
    void Start()
    {
        animator = GameObject.Find("Main Camera").GetComponent<Animator>();
    }

    public void Load(string scene)
    {
        SceneManager.LoadScene(scene);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
