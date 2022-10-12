using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public static string playerName;
    public InputField inputField;
    
    // Start is called before the first frame update
    void Start()
    {
        //inputField = GetComponent<InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveName()
    {
        playerName = inputField.text;
        Debug.Log(playerName);
    }

    public void StartNew()
    {
        
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
