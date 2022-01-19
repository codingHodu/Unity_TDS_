using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    float damage = 1f;

    //float lifeTime = 1f;
    float velocity = 1f;

    /*
    public Projectile(float _damage, float _velocity)
    {
        damage = _damage;
        velocity = _velocity;
    }
*/
    private void Start()
    {
        //Destroy(this, lifeTime);
    }
    private void Update()
    {
        transform.Translate(Vector3.forward * velocity * Time.deltaTime);
    }

    public void SetDamage(float d)
    {
        this.damage = d;
    }
    public void SetVelocity(float v)
    {
        velocity = v;
    }
    public void SetLifeTime(float t)
    {
        Destroy(gameObject, t);
    }



}
