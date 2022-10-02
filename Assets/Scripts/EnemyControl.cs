using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyControl : MonoBehaviour
{
    [SerializeField] private NavMeshAgent navMeshAgent;
    [SerializeField] private Transform[] waypoints;

    private int curentWaypoint;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent.SetDestination(waypoints[0].position);
    }

    // Update is called once per frame
    void Update()
    {
        if(navMeshAgent.remainingDistance < navMeshAgent.stoppingDistance)
        {
            if (curentWaypoint == 0)
            {
                StartCoroutine(Review(new Vector3(1f, 0f, 0f)));
                StopAllCoroutines();
            }
            if (curentWaypoint == 1)
            {
                StartCoroutine(Review(new Vector3(0f, 1f, 0f)));
                StopAllCoroutines();
            }
            if (curentWaypoint == 2)
            {
                StartCoroutine(Review(new Vector3(-1f, 0f, 0f)));
                StopAllCoroutines();
            }
            if (curentWaypoint == 3)
            {
                StartCoroutine(Review(new Vector3(1f, 0f, 0f)));
               StopAllCoroutines();
            }
            new WaitForSeconds(2f);
            curentWaypoint = (curentWaypoint + 1) % waypoints.Length;
            navMeshAgent.SetDestination(waypoints[curentWaypoint].position);
        }    
    }

    private IEnumerator Review(Vector3 direction)
    {
        transform.rotation = Quaternion.LookRotation(direction);
        yield return new WaitForSeconds(2f);
    }
}
