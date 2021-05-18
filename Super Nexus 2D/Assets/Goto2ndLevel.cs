using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goto2ndLevel : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("level2");
    }
}
