using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class commudity : MonoBehaviour
{
    public GameObject m_commodity;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            m_commodity.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            m_commodity.SetActive(false);
        }
    }

}
