using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMid : Asteroid{
    public override void OnHit(){
        AwardPoints();
        LevelManager.singleton.SpawnAsteroidSmall(transform.position, Random.Range(1, 3));
        Destroy(gameObject);
    }
}