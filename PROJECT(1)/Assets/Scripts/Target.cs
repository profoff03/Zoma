using UnityEngine;
using UnityEngine.AI;

public class Target : MonoBehaviour
{
    public float health = 100f;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Animator animator = GetComponent<Animator>();
        NavMeshAgent _agent = GetComponent<NavMeshAgent>();
        EnemyScript _enemy = GetComponent<EnemyScript>();
        if (animator && _agent && _enemy != null)
        {
            Destroy(_enemy);
            Destroy(_agent);
            animator.SetBool("IsDied", true);
            Destroy(gameObject, 5f);
        }
    }
}
