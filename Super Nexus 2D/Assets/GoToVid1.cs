using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToVid1 : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene("Level1Prior");
    }
}
