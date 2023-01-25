using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour{
    
    public int score;
    public Vector2 velocity;

    public void Start(){
        velocity = Random.insideUnitCircle * 2f;
    }

    public virtual void Move(){
        transform.Translate(velocity * Time.fixedDeltaTime, Space.World);
    }

    public virtual void OnHit(){
        AwardPoints();
        Destroy(gameObject);
    }

    public virtual void AwardPoints(){
        Player.singleton.score += score;
        UIManager.singleton.UpdateScore();
    }

    public void OnCollisionEnter2D(Collision2D c){
        if(c.gameObject.CompareTag("Player")){
            Player.singleton.OnHit();
            Destroy(gameObject);
        }
    }
}