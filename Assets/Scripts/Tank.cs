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
    public AudioClip shootSound;
    public AudioClip movementSound;
    private AudioSource shootAudioSource;
    private AudioSource movementAudioSource;

    // Adjust this value to set the volume of the movement sound
    private float movementVolume = 0.2f;

    void Start()
    {
        shootAudioSource = gameObject.AddComponent<AudioSource>();
        shootAudioSource.playOnAwake = false;
        shootAudioSource.clip = shootSound;

        movementAudioSource = gameObject.AddComponent<AudioSource>();
        movementAudioSource.playOnAwake = false;
        movementAudioSource.clip = movementSound;
        movementAudioSource.volume = movementVolume; // Set the initial volume
    }

    void Update()
    {
        var ver = Input.GetAxis(vertical);
        var hor = Input.GetAxis(horizontal);

        if (ver != 0 || hor != 0)
        {
            if (!movementAudioSource.isPlaying)
            {
                movementAudioSource.Play();
            }
        }
        else
        {
            if (movementAudioSource.isPlaying)
            {
                movementAudioSource.Stop();
            }
        }

        GetComponent<Rigidbody>().velocity = transform.forward * speed * ver;
        transform.Rotate(0, rotateSpeed * hor * Time.deltaTime, 0);

        if (Input.GetKeyDown(shootKey))
        {
            Instantiate(bullet, shootPoint.position, shootPoint.rotation);
            shootAudioSource.Play();
        }
    }
}



