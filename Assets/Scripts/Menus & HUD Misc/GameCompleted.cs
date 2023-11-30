using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCompleted : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (StateNameConptroller.p1Solved && StateNameConptroller.p2Solved && StateNameConptroller.p3Solved && StateNameConptroller.p4Solved)
            {
                SceneManager.LoadScene("EndingScene");
            }
        }
    }
}
