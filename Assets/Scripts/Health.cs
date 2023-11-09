using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int hp;
    public GameObject particle;
    public int particleCount;
    public AudioSource audioSource1;
    public AudioSource audioSource2;


    void Start()
    {
        
        

    }

    public void Damage()
    {
        hp--;
        audioSource1.Play(); 
        if (hp <= 0)
        {
            Die();
            
        }
    }

    public void Die()
    {
        
        Destroy(gameObject);

        for (int i = 0; i < particleCount; i++)
        {
            var offset = Vector3.up + Random.insideUnitSphere * 2;
            Instantiate(particle, transform.position + offset, transform.rotation);
        }

        audioSource2.Play();
    }

    
}


