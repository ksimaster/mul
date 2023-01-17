using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class PlayerControl : NetworkBehaviour
{
    private Vector3 moveDirection;
    private float moveSpeed = 3;
    void FixedUpdate()
    {
        if (!IsOwner) return;
        Move();
    }
    private void Move()
    {
        moveDirection = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.W)) moveDirection.z = +1f;
        if (Input.GetKey(KeyCode.A)) moveDirection.x = -1f;
        if (Input.GetKey(KeyCode.S)) moveDirection.z = -1f;
        if (Input.GetKey(KeyCode.D)) moveDirection.x = +1f;
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}
