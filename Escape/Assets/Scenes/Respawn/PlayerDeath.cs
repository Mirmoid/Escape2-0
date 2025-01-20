using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerDeath : MonoBehaviour
{
    public Vector3 startPosition;
    private void Awake()
    {
        startPosition = transform.position;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            transform.position = startPosition;
        }
    }
}
