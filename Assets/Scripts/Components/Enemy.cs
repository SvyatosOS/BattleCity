using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Tank
{
    private float time, repeatShooting = 1f;
    private void Start()
    {
        InvokeRepeating(nameof(Shoot),time,repeatShooting);
    }
    public void MoveTo(Vector2 point)
    {
        var direction = point - (Vector2)transform.position;
        Move(direction);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            Health(health, 1);
            health--;
            Destroy(collision.gameObject);
        }
    }


}
