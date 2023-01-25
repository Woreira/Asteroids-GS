using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : Enemy{

    public float angularVelocity;

    void Awake(){
        angularVelocity = Random.Range(-10f, 10f);
    }

    void FixedUpdate(){
        Rotate();
        Move();
    }

    void Rotate(){
        transform.Rotate(0f, 0f, angularVelocity, Space.Self);
    }

}