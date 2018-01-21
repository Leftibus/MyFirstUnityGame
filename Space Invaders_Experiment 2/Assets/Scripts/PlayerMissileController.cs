using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMissileController : MonoBehaviour {

    private Rigidbody2D missile;
    public float missileSpeed;
    private GameObject player;

    void Start()
    {
        missile = GetComponent<Rigidbody2D>();
        player = GameObject.FindWithTag("Player");
    }
    private void FixedUpdate()
    {
        transform.Translate(0f, missileSpeed * Time.deltaTime, 0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            player.GetComponent<PlayerController>().playerLoaded = true;
        }
        else if (collision.tag == "Border")
        {
            Destroy(gameObject);
            player.GetComponent<PlayerController>().playerLoaded = true;
        }
        else if (collision.tag == "Alien_Missile")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            player.GetComponent<PlayerController>().playerLoaded = true;
        }

    }
}
