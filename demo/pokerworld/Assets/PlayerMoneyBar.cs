using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMoneyBar : MonoBehaviour
{
    [Tooltip("Text component displaying current money")]
    public Text moneyText;

    PlayerCharacterController playerCharacterController;

    private void Start()
    {
        playerCharacterController = GameObject.FindObjectOfType<PlayerCharacterController>();
        DebugUtility.HandleErrorIfNullFindObject<PlayerCharacterController, PlayerHealthBar>(playerCharacterController, this);

        //m_PlayerHealth = playerCharacterController.GetComponent<Health>();
        //DebugUtility.HandleErrorIfNullGetComponent<Health, PlayerHealthBar>(m_PlayerHealth, this, playerCharacterController.gameObject);
    }

    void Update()
    {
        // update health bar value
        moneyText.text = "$" + playerCharacterController.playerMoney.ToString();
    }
}
