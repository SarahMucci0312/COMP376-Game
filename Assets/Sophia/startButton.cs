using UnityEngine;
using UnityEngine.SceneManagement;

public class startButton : MonoBehaviour
{
    public void onClick()
    {
        SceneManager.LoadScene("Main");
    }
}
