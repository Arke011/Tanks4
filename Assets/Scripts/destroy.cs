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
            ExplodeCubes();
            isBroken = true;
        }
    }

    void ExplodeCubes()
    {
        for (int i = 0; i < 6; i++)
        {
            Vector3 cubeSpawnPosition = transform.position;
            Instantiate(cubePrefab, cubeSpawnPosition, Quaternion.identity);
        }

        Destroy(gameObject);
    }
}


