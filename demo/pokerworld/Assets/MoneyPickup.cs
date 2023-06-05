using UnityEngine;

public class MoneyPickup : MonoBehaviour
{
    [Header("Parameters")]
    [Tooltip("Amount of money on pickup")]
    public int moneyAmount;

    Pickup m_Pickup;

    void Start()
    {
        m_Pickup = GetComponent<Pickup>();
        DebugUtility.HandleErrorIfNullGetComponent<Pickup, HealthPickup>(m_Pickup, this, gameObject);

        // Subscribe to pickup action
        m_Pickup.onPick += OnPicked;
    }

    void OnPicked(PlayerCharacterController player)
    {
        player.playerMoney += moneyAmount;
        m_Pickup.PlayPickupFeedback();
        Destroy(gameObject);
    }
}
