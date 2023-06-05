using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public GameObject m_NPC;
    private bool m_isMoving = true;
    public List<Transform> pathNodes = new List<Transform>();
    private int m_targetIndex = 0;
    CharacterController m_characterController;

    private void Update()
    {
        if (m_targetIndex == pathNodes.Count)
            m_targetIndex = 0;

        MoveTo(pathNodes[m_targetIndex]);

        if (IsArrived(pathNodes[m_targetIndex]))
        {
            m_targetIndex++;
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
       
    }
    
    float m_verticalSpeed = 0.0f;

    
}
