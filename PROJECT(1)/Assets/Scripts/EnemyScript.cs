using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    private NavMeshAgent _agent;
    private Transform _transform;
    [SerializeField]
    private GameObject _target;
    
    // Start is called before the first frame update
    void Start()
    {
        _agent = gameObject.GetComponent<NavMeshAgent>();
        _transform = gameObject.transform;
        _target = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToPlayer = Vector3.Distance(_transform.position, _target.transform.position);
        
        if (distanceToPlayer > 1)
        {
            _agent.destination = _target.transform.position;
        }
        
        
    }
}
