using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerController))]
[RequireComponent(typeof(GunController))]
public class Player : MonoBehaviour
{
    PlayerController playerController;
    GunController gunController;
    public float moveSpeed = 5;

    void Start()
    {
        playerController = GetComponent<PlayerController>();
        gunController = GetComponent<GunController>();
    }

    void Update()
    {
        //플레이어를 움직이기(일뿅뿅 아님~)

        Vector3 moveDir = new Vector3(
            Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
        //playerController.Move(moveDir, moveSpeed);
        playerController.SetVelocity(moveDir * moveSpeed);



        //플레이어가 마우스 커서(사실 작음)를 바라보게 만듦
        Plane plane = new Plane(Vector3.up, Vector3.zero);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float distanceToPlane;
        
        if (plane.Raycast(ray, out distanceToPlane))
        {
            Vector3 point = ray.GetPoint(distanceToPlane);
            playerController.LookAt(point);

            Debug.DrawLine(ray.origin, point, Color.red);
        }

        //총빵빵
        if (Input.GetMouseButton(0))
        {
            gunController.Fire();
        }






    }
}
