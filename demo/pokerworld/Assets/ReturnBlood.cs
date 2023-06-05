using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnBlood : MonoBehaviour
{
    public AudioClip returnblood;
    AudioSource m_returnAudioSource;
   
    Health m_Health;
    public GameObject Player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            m_Health = other.gameObject.GetComponent<Health>();
            m_Health.currentHealth = m_Health.maxHealth;
            m_returnAudioSource = GetComponent<AudioSource>();
            if (returnblood)
            {
                m_returnAudioSource.PlayOneShot(returnblood);
            }
        }
    }

}
