using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public static EnemyHealth instance;

    private void Awake()
    {
        instance = this;
    }

    public float Health = 100f;

    public void TakeDamage(float Damage)
    {
        Health -= Damage;
        if(Health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
