using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public InputManager inputManager;

    public Rigidbody bulletPrefab;

    public float speed;

    public AudioSource shootSound;

    // Start is called before the first frame update
    void Start()
    {
        inputManager.inputMaster.Shoot.shootBullet.started += _ => shooting();
    }

    void shooting()
    {
        Rigidbody bullet = Instantiate(bulletPrefab);
        shootSound.Play();
        bullet.transform.position = transform.position;
        bullet.AddForce(transform.forward * speed);
        //Destroy(gameObject, 2);
    }
}
