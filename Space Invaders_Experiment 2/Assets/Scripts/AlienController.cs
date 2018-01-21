using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienController : MonoBehaviour {

    public float alienSpeed;
    public float leftBoundAlien, rightBoundAlien;
    public float rowHeight = 0.5f;
    public float startDelay;
    public float moveDelay;
    public float fireRate = 0.997f;
    public GameObject missile;

    private Transform alienHolder;

    // Use this for initialization
    void Start ()
    {
        alienHolder = GetComponent<Transform>();
        InvokeRepeating("MoveAlien", startDelay, moveDelay);
    }

    void MoveAlien()
    {
        alienHolder.position += Vector3.right * alienSpeed;

        foreach (Transform alien in alienHolder)
        {
            if (alien.position.x < leftBoundAlien || alien.position.x > rightBoundAlien)
            {
                alienSpeed = -alienSpeed;
                alienHolder.position = alienHolder.position + (Vector3.down * rowHeight) + (Vector3.right * alienSpeed);
            }

            if (Random.value > fireRate)
                Instantiate(missile, alien.position, alien.rotation);
        }
    }
}
