using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float healthPoints = 100f;
    bool isDead = false;

    public bool IsDead()
    {
        return isDead;
    }

    // create a public method that reduces hitpoints by the amount of damage
    public void TakeDamage(float weapondamage)
    {
        BroadcastMessage("OnDamageTaken");
        healthPoints -= weapondamage;
        if (healthPoints <= 0)
        {
            if (isDead) return;
            isDead = true;
            GetComponent<Animator>().SetTrigger("Death");
        }
    }
}
