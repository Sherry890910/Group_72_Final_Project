using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartStoryHouse : MonoBehaviour
{
    public GameObject m_StoryText;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player" )
        {
            m_StoryText.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            m_StoryText.SetActive(false);
        }
    }
}
