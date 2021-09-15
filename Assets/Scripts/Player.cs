using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rigidBody;
    public Player player;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Goal goal = collision.collider.gameObject.GetComponent<Goal>();
        print("1");
    }
}
