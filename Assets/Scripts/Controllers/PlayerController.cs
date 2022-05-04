using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance { get; private set; }

    [SerializeField] private Tank player;
    [SerializeField] private FixedJoystick joystick;

    private void Awake()
    {
        Instance = this;
    }

    private void FixedUpdate()
    {
        //var movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        var movement = new Vector2(joystick.Horizontal, joystick.Vertical);

       /* if (Input.GetKeyDown(KeyCode.Space))
        {
            player.Attack(player.transform.up);
        }*/

        player.Move(movement);
        player.Rotate(movement);
    }
   
}
