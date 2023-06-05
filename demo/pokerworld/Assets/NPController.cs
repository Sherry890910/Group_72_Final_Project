using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPController : MonoBehaviour
{
    public GameObject m_NPC;
    public List<Transform> pathNodes = new List<Transform>();

    private int m_targetIndex = 0;
    private bool m_isMoving = true;
    private CharacterController m_characterController;

    private void Start()
    {
        m_characterController = m_NPC.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_NPC != null)
        {
            ApplyGravity();

            if (m_targetIndex == pathNodes.Count)
                m_targetIndex = 0;

            MoveTo(pathNodes[m_targetIndex]);

            if (IsArrived(pathNodes[m_targetIndex]))
            {
                m_targetIndex++;
            }
        }
    }

    private bool IsArrived(Transform target)
    {
        const float NEAR_DISTANCE = 1f;
        Vector3 diff = m_NPC.transform.position - target.position;
        diff.y = 0;
        return diff.sqrMagnitude <= NEAR_DISTANCE;
    }

    private void MoveTo(Transform target)
    {
        Vector3 to = new Vector3(target.position.x, 0, target.position.z);
        Vector3 from = new Vector3(m_NPC.transform.position.x, 0, m_NPC.transform.position.z);
        if (from != to && m_isMoving)
        {
            m_NPC.transform.LookAt(new Vector3(to.x, m_NPC.transform.position.y, to.z));
            Vector3 toward = (to - from).normalized * m_characterController.stepOffset;
            toward.y = m_verticalSpeed;
            m_characterController.Move(toward* Time.deltaTime);
        }
    }

    public GameObject m_NPCText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player" && m_NPCText != null)
        {
            m_NPCText.SetActive(true);
            m_isMoving = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player" && m_NPCText != null)
        {
            m_NPCText.SetActive(false);
            m_isMoving = true;
        }
    }

    float m_gravity = 20.0f;
    float m_verticalSpeed = 0.0f;

    private void ApplyGravity()
    {
        if (m_characterController.isGrounded)
            m_verticalSpeed = 0.0f;
        else
            m_verticalSpeed -= m_gravity * Time.deltaTime;
    }
}
