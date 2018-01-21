using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMissileController : MonoBehaviour {

    private Rigidbody2D missile;
    public float missileSpeed;

	void Start ()
    {
        missile = GetComponent<Rigidbody2D>();
	}
    private void FixedUpdate()
    {
        transform.Translate(0f, -missileSpeed * Time.deltaTime, 0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else if (collision.tag == "Border")
        {
            Destroy(gameObject);
        }
    }
}
