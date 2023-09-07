using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float lifeTime;
    [SerializeField] private int damage;

    private void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    private void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destructable destructable = collision.transform.root.GetComponent<Destructable>();

        if(destructable != null)
        {
            destructable.ApplyDamage(damage);
        }

        Destroy(gameObject);    
    }

    public void SetDamage(int damage)
    {
        this.damage= damage;
    }
}
