using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoEnd : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene("EndScene");
    }
}