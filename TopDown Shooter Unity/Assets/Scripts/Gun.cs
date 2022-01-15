using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;
public class Gun : MonoBehaviour
{
    public Transform muzzle;

    public Projectile bulletPrefab;


    public float timeBetFire = 1f;
    public float damage = 1f;

    public float lifeTime = 1f;
    public float velocity = 1f;

    float nextFireTime = 0;

    public bool isWizard = false;
    public float wizardAngle = 45;
    bool wizardShotL = true;

    public void Fire()
    {
        if(nextFireTime < Time.time)
        {
            nextFireTime = Time.time + timeBetFire;

            Projectile newProj = Instantiate(bulletPrefab, muzzle.position, muzzle.rotation);
            newProj.SetDamage(damage);
            newProj.SetLifeTime(lifeTime);
            newProj.SetVelocity(velocity);

            if (isWizard)
            {


                if (wizardShotL)
                    newProj.transform.Rotate(Vector3.up * wizardAngle);
                else
                    newProj.transform.Rotate(Vector3.up * -wizardAngle);
                wizardShotL ^= true;
            }

        }


    }





    void GenerateProj()
    {

    }


}
