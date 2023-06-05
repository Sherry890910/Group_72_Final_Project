using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gotomenu : MonoBehaviour
{
    public void backto()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 10);
    }
    
}
