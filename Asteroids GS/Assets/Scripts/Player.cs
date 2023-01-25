using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODO inertial dampers

public class Player : MonoBehaviour{

    public float thrustSensitivity;
    public float yawSensitivity;

    public GameObject bulletPrefab;
    public float bulletSpeed;

    public int score;
    public int hp = 5;

    Rigidbody2D rb;
    Vector2 inputVector;
    
    public static Player singleton;

    void Awake(){
        singleton = this;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        PlayerInput();
    }

    void FixedUpdate(){
        rb.AddRelativeForce(Vector3.up * inputVector.y * thrustSensitivity);
        rb.AddTorque(inputVector.x * yawSensitivity);
    }

    void PlayerInput(){
        inputVector = new Vector2(-Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        if(Input.GetKeyDown(KeyCode.K)) FireBullet();
    }

    //important: in Asteroids the bullet seem to inherit the ship's velocity
    void FireBullet(){
        var b = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        b.GetComponent<Bullet>().velocity = (Vector2)(transform.up * bulletSpeed) + rb.velocity;
    }

    public void OnHit(){
        hp--;
        UIManager.singleton.UpdateHealthBar();
    }

    
}