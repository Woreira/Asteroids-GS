using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBig : Asteroid{
    public override void OnHit(){
        AwardPoints();
        LevelManager.singleton.SpawnAsteroidMid(transform.position, Random.Range(1, 5));
        Destroy(gameObject);
    }
}