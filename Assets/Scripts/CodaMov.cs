using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodaMov : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.transform.position = this.gameObject.transform.GetChild(0).transform.position;
    }
}
