using UnityEngine;

public class Tank : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Bullet bulletPrefab;
    public int health;

    private new Rigidbody2D rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2 direction)
    {
        rigidbody.AddForce(direction * speed, ForceMode2D.Force);
    }

    public void Rotate(Vector2 direction)
    {
        transform.up = Vector3.Lerp(transform.up, direction, .2f);
    }

    public void Attack(Vector2 direction )
    {
        var bulletInstance = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        bulletInstance.Launch(direction);
    }
    public void Shoot()
    {
        Attack(transform.up);
    }

  
    public void Health(int health, int damege)
    {
         health -= damege;
        if (health <= 0)
            Destroy(gameObject);
    }
}
