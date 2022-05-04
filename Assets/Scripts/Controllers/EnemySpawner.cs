using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> enemies;
    [SerializeField] private BoxCollider2D ground;
    [SerializeField] private float scaleGround;
    private float time, repeatSpawnEnemy = 5f;

    private void Awake()
    {
        SpawnEnemy();
        InvokeRepeating(nameof(SpawnEnemy), time, repeatSpawnEnemy);
       
    }

    private void SpawnEnemy()
    {
        var posX = Random.Range(0, ground.size.x * scaleGround);
        var posY = Random.Range(0, ground.size.y * scaleGround);
        Instantiate(enemies[Random.Range(0, enemies.Count)], new Vector3(posX, posY),Quaternion.identity);
    }
  

}
