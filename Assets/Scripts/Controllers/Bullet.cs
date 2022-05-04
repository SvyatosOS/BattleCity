using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private new Rigidbody2D rigidbody;
    [SerializeField] private float speed;
    [SerializeField] private float lifetime = 1f;

    private Vector2 direction;

    public bool IsLaunched => direction != default;
  
    private void FixedUpdate()
    {
        if (IsLaunched) 
            Move();
    }

    private void Move()
    {
        rigidbody.AddForce(direction * speed);
    }

    public void Launch(Vector2 direction)
    {
        this.direction = direction;
        Destroy(gameObject, lifetime);
    }

}
