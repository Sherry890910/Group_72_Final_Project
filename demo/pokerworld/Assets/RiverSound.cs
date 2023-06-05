using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiverSound : MonoBehaviour
{
    public AudioClip riversound;
    AudioSource m_riverAudioSource;
    public GameObject Player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            m_riverAudioSource = GetComponent<AudioSource>();
            if (riversound)
            {
                m_riverAudioSource.PlayOneShot(riversound);
            }
        }
    }
}
