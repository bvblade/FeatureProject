using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == ("Ground"))
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Bullet")
        {
            Debug.Log("Coin Hit");
            Destroy(this.gameObject);
            //instantiate new bullet that will hit enemies

        }
    }
}
