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

    private Animator _animator;
    
    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _transform = transform;
        _animator = GetComponent<Animator>();
        _target = GameObject.FindWithTag("Target");
    }

    // Update is called once per frame
    void Update()
    {
        var distanceToPlayer = Vector3.Distance(_transform.position, _target.transform.position);
        
        if (distanceToPlayer < 20 && distanceToPlayer > 4)
        {
            if(_animator.GetBool("IsFight")) _animator.SetBool("IsFight", false); 
            
            _animator.SetBool("IsRunning", true);
            _agent.destination = _target.transform.position;
        }

        if (distanceToPlayer < 4)
        {
            _animator.SetBool("IsRunning", false);
            _animator.SetBool("IsFight", true);
        }

        


    }
}
