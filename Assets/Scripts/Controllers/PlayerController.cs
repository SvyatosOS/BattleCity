using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D),typeof(BoxCollider2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private FixedJoystick joystick;
    [SerializeField] private float moveSpeed;
    [SerializeField] GameObject bullet;

    private void FixedUpdate()
    {
      rb.velocity = new Vector3(joystick.Horizontal * moveSpeed, joystick.Vertical * moveSpeed);

        //if (joystick.Horizontal != 0 || joystick.Vertical != 0)
       
    }
   /* private void Update()
    {
        if (joystick.Horizontal > .2f)
            transform.Rotate(0, 0, -90);
        else if (joystick.Horizontal < .2f)
            transform.Rotate(0, 0, 90);
        else
            transform.Rotate(0, 0, 0);

    }*/

    public void Gun()
    {
        Instantiate(bullet, transform.position, transform.rotation);
       
    }
}
