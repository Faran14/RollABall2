using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuretry : MonoBehaviour
{
    public void retryLevel()
    {
        SceneManager.LoadScene(1);
    }
}
