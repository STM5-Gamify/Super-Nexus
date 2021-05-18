using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoLevel3 : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene("level3");
    }
}