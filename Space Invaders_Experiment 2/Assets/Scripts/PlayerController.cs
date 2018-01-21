using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float leftBound, rightBound;
    public GameObject missile;
    public bool playerLoaded = true;

    private Vector3 missileStart;
    private Transform player;

    private void Start()
    {
        player = GetComponent<Transform>();
    }

    private void FixedUpdate()
    {
        float horizontalMove = Input.GetAxis("Horizontal");

        if (player.position.x < leftBound && horizontalMove < 0)
            horizontalMove = 0;
        else if (player.position.x > rightBound && horizontalMove > 0)
            horizontalMove = 0;

        transform.Translate(moveSpeed * horizontalMove * Time.deltaTime, 0f, 0f);

        if (Input.GetButton("Fire1") && playerLoaded)
        {
            missileStart = new Vector3(player.position.x, player.position.y + 2, 0f);
            Instantiate(missile, missileStart, player.rotation);
            playerLoaded = false;
        }
    }

}
