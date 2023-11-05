using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public float speed = 5;
    public float rotateSpeed = 90;

    public string vertical;
    public string horizontal;
    public KeyCode shootKey;

    public GameObject bullet;

    public Transform shootPoint;

    


    void Update()
    {
        var ver = Input.GetAxis(vertical);
        transform.position += transform.forward * speed * ver * Time.deltaTime;

        var hor = Input.GetAxis(horizontal);
        transform.Rotate(0, rotateSpeed * hor * Time.deltaTime, 0);

        if (Input.GetKeyDown(shootKey))
        {
            Instantiate(bullet, shootPoint.position, shootPoint.rotation);
        }
    }
}
