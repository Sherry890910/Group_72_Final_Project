using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sleep_ani : MonoBehaviour
{
    public GameObject S0;
    public GameObject S1;
    public GameObject S2;
    // Start is called before the first frame update
    void Start()
    {
        first_Routinetime();
    }
    private IEnumerator first_Routinetime(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        S0.SetActive(true);
        Sleep1_Routinetime();
    }
    private void first_Routinetime()
    {
        StartCoroutine(first_Routinetime(1.5f));
    }
    private IEnumerator Sleep1_Routinetime(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        S1.SetActive(true);
        Sleep2_Routinetime();
    }
    private void Sleep1_Routinetime()
    {
        StartCoroutine(Sleep1_Routinetime(1.5f));
    }
    private IEnumerator Sleep2_Routinetime(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        S2.SetActive(true);
        Dis_Routinetime();
    }
    private void Sleep2_Routinetime()
    {
        StartCoroutine(Sleep2_Routinetime(1.5f));
    }
    private IEnumerator Dis_Routinetime(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        S2.SetActive(false);
        S1.SetActive(false);
        S0.SetActive(false);
        first_Routinetime();
    }
    private void Dis_Routinetime()
    {
        StartCoroutine(Dis_Routinetime(1.5f));
    }



}
