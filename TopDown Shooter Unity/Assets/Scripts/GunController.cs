using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    Gun currentGun;
    public Gun initialGun;
    public Transform wield;

    void Start()
    {
        if(initialGun != null)
        {
            EquipGun(initialGun);
        }
        else
        {
            Debug.LogError("기본 총이 설정되어 있지 않습니다!");
        }


        
    }
    public void EquipGun(Gun gun)
    {
        if(currentGun != null)
        {
            Destroy(currentGun.gameObject);
        }
        currentGun = Instantiate(gun, wield.position,wield.rotation , wield);
        
    }
    public void Fire()
    {
        currentGun.Fire();
    }

}
