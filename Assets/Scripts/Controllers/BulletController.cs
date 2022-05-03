using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * 5);
    }
}
