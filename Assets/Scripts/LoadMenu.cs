using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMenu : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("LewisAR Main Menu");
    }
}