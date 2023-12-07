using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public Rigidbody bulletRicPrefab;
   

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == ("Ground"))
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Bullet")
        {
            Debug.Log("Coin Hit");
            //instantiate new bullet that will hit enemies
            GameObject bulletInstance = Instantiate(bulletRicPrefab).gameObject;
            bulletInstance.transform.position = this.transform.position;
            Debug.Log("bullet instantiated");
            Destroy(this.gameObject);
        }
    }
}
