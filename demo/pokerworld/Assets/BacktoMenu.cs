using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BacktoMenu : MonoBehaviour
{
    public void Backto()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -4);
    }
}
