using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour{
    public GameObject asteroidBigPrefab, asteroidMidPrefab, asteroidSmallPrefab, enemyShipPrefab;
    public static LevelManager singleton;

    void Awake(){
        singleton = this;
    }

    void Start(){
        InvokeRepeating("SpawnAsteroidBig", 1f, 2f);
          InvokeRepeating("SpawnEnemyShip", 5f, 10f);
    }

    void SpawnAsteroidBig(){
        Instantiate(asteroidBigPrefab, Random.insideUnitCircle.normalized * new Vector2(8f, 5f), Quaternion.identity);
       
    }

    public void SpawnAsteroidMid(Vector2 position, int times){
        for(int i = 0; i < times; i++){
            var a = Instantiate(asteroidMidPrefab, position, Quaternion.identity);
        }
    }

    public void SpawnAsteroidSmall(Vector2 position, int times){
        for(int i = 0; i < times; i++){
            var a = Instantiate(asteroidSmallPrefab, position, Quaternion.identity);
        }
    }

    public void SpawnEnemyShip(){
        Instantiate(enemyShipPrefab, Random.insideUnitCircle.normalized * new Vector2(8f, 5f), Quaternion.identity);
    }
}