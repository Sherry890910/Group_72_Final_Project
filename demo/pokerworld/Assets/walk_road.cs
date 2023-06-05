using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class walk_road : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject target;
    Vector3 direction;
    public int total_step = 200;
    public int step = 0;
    void Start()
    {
        direction = target.transform.position - this.gameObject.transform.position;
        direction = direction / total_step;
    }

    // Update is called once per frame
    void Update()
    {
        if (step != total_step)
        {
            step++;
            this.gameObject.transform.position = this.gameObject.transform.position + direction;
        }
    }
}
