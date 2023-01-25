using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : Enemy{

    public float bulletSpeed;
    public GameObject enemyBulletPrefab;

    void Awake(){
        InvokeRepeating("FireAtPlayer", 3f, 4f);
    }

    void FixedUpdate(){
        Move();
    }
   
    void FireAtPlayer(){
        var b = Instantiate(enemyBulletPrefab, transform.position, Quaternion.identity);
        var dir = Player.singleton.transform.position - transform.position;
        b.GetComponent<Bullet>().velocity = (Vector2)(dir.normalized * bulletSpeed);
    }
}