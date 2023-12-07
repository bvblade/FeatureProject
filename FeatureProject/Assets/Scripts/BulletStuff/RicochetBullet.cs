using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RicochetBullet : MonoBehaviour
{

    public float bulletSpeed;
    private GameObject [] enemies;
    private Transform targetedEnemy;

    // Update is called once per frame
    void Update()
    {
        float step = bulletSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetedEnemy.position, step);
    }
    
    private void Awake()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        targetedEnemy = enemies[Random.Range(0, enemies.Length)].transform;
        Destroy(this.gameObject, 1);
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Ground")
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }
    }
}
