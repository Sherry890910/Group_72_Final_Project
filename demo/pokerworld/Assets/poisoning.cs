using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poisoning : MonoBehaviour
{
    Health m_Health;
    bool is_poisoning = false;
    public GameObject Player;
    public float poison_rate = 0.0009f;


    private void Update()
    {
        if(is_poisoning)
        {
            m_Health.currentHealth = m_Health.currentHealth - m_Health.maxHealth * poison_rate * Time.deltaTime;
            m_Health.HandleDeath();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            is_poisoning = true;
            m_Health = other.gameObject.GetComponent<Health>();
            Player.GetComponent<PlayerCharacterController>().maxSpeedOnGround = 5f;
            Player.GetComponent<PlayerCharacterController>().movementSharpnessOnGround = 5f;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            is_poisoning = false;
            Player.GetComponent<PlayerCharacterController>().maxSpeedOnGround = 10f;
            Player.GetComponent<PlayerCharacterController>().movementSharpnessOnGround = 15f;

        }
    }
}
