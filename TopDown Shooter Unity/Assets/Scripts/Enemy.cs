using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Enemy : MonoBehaviour
{
    public Transform Target;

    NavMeshAgent pathFinder;
    private void Awake()
    {
        pathFinder = GetComponent<NavMeshAgent>();
    }
    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player").transform;
        StartCoroutine(GoToTarget());
    }

    IEnumerator GoToTarget()
    {
        float findingInterval = 1 / 4f;

        while(true)
        if(Target != null)
        {
            pathFinder.SetDestination(Target.position);
            yield return new WaitForSeconds(findingInterval);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
