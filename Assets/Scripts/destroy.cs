using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableObject : MonoBehaviour
{
    public GameObject cubePrefab; 

    private bool isBroken = false;

    void OnCollisionEnter(Collision collision)
    {
        if (isBroken) return; 

        if (collision.gameObject.CompareTag("Bullet"))
        {
            BreakObject();
            isBroken = true;
        }
    }

    void BreakObject()
    {
        for (int i = 0; i < 20; i++) 
        {
            Vector3 cubeSpawnPosition = transform.position;
            Instantiate(cubePrefab, cubeSpawnPosition, Quaternion.identity);
        }

        Destroy(gameObject); 
    }
}


