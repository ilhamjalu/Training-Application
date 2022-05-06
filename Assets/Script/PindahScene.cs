using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PindahScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PindahKeSceneAssemble()
    {
        SceneManager.LoadScene("AssemblyScene");
    }
 
    public void PindahKeSceneLevel()
    {
        SceneManager.LoadScene("LevelScene");
    }
    public void PindahKeSceneAbout()
    {
        SceneManager.LoadScene("About");
    }
    public void PindahKeSceneMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
