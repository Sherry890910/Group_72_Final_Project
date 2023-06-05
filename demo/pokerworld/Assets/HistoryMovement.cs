using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HistoryMovement : MonoBehaviour
{
    public GameObject m_HistoryText;
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            m_HistoryText.SetActive(true);
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            m_HistoryText.SetActive(false);
        }
    }
}
