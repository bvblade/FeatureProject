using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public InputManager inputManager;

    public Rigidbody coinPrefab;

    public float speed;

    public AudioSource CoinSound;

    // Start is called before the first frame update
    void Start()
    {
        inputManager.inputMaster.CoinToss.TossCoin.started += _ => tossCoin();
    }

    void tossCoin()
    {
        Rigidbody coin = Instantiate(coinPrefab);
        CoinSound.Play();
        coin.transform.position = transform.position;
        coin.AddForce(transform.forward * speed);
    }
}
