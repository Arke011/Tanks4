using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ineedmorebullets : MonoBehaviour
{
    public float speed = 20;
    
    private void Start()
    {
        
        Destroy(gameObject, 2f);
    }

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        

        if (collision.gameObject.tag == "boom")
        {
            collision.gameObject.GetComponent<Health>().Damage();
            
        }
    }
}
