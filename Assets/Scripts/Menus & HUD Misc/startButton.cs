using UnityEngine;
using UnityEngine.SceneManagement;

public class startButton : MonoBehaviour
{
    public void LoadIntroScene()
    {
        SceneManager.LoadScene("IntroScene");
    }
}
