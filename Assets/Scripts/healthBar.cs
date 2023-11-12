using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthBar : MonoBehaviour
{
    public Health health;

    
    void Update()
    {
        var scaleX = health.hp / 5f;
        transform.localScale = new Vector3(scaleX, 1, 1);
    }
}
