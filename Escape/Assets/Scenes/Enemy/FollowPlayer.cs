using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class FollowPlayer : MonoBehaviour
{

    public float attackSpeed = 4;
    public float attackDistance;
    public float bufferDistance;
    public GameObject player;

    Transform playerTransform;

    void GetPlayerTransform()
    {
        if (player != null)
        {
            playerTransform = player.transform;
        }
        else
        {
            Debug.Log("Player not specified in Inspector");
        }
    }

    void Start()
    {
        GetPlayerTransform();
    }

    void Update()
    {
        float step = attackSpeed * Time.deltaTime;

        // Переместите нашу позицию на шаг ближе к цели.
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, step);
    }
}
