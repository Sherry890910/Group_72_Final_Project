using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gototreasure : MonoBehaviour
{
    public void Goto()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 10);
    }
}
