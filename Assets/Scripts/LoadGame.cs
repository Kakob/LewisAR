using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("PeterFave");
    }
}