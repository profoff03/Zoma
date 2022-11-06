using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterTarget : MonoBehaviour
{
    [SerializeField] private float health = 700f;
    

    private void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals("Damage"))
        {
            TakeDamage();
        }
    }

    private void TakeDamage()
    {
        health -= 10f;
        if (health <= 0)
        {
            Destroy(gameObject, 1f);
        }
    }
}
