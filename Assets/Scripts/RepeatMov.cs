using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class RepeatMov : MonoBehaviour
{
    [NonSerialized] public Vector3 target;
    float t = 0.0f;

    float decSpeed = 300;//‘¬“x‚ð’x‚­


    void Update()
    {
        t += Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, t / decSpeed);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "WeaponYellow") Destroy(this.gameObject);
        else if (collision.gameObject.tag == "Player") Destroy(this.gameObject);

    }
}
