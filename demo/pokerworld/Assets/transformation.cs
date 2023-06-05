using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformation : MonoBehaviour
{
    public GameObject m_PortalText;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            m_PortalText.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            m_PortalText.SetActive(false);
        }
    }
}
