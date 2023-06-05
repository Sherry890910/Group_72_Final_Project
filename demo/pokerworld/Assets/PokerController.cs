using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokerController : MonoBehaviour
{
    public GameObject m_storyText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            m_storyText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            m_storyText.SetActive(false);
        }
    }
}
