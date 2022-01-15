using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    Rigidbody rigidBody;
    Vector3 moveVelocity = Vector3.zero;
    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rigidBody.MovePosition(transform.position + moveVelocity * Time.deltaTime);
    }

    public void SetVelocity(Vector3 v)
    {
        moveVelocity = v;
    }
    public void LookAt(Vector3 point)
    {
        point.y = transform.position.y;
        transform.LookAt(point);
    }
    

    public void Move(Vector3 moveDir, float velocity)
    {
        rigidBody.MovePosition(transform.position + moveDir * velocity * Time.fixedDeltaTime);
    }

}
