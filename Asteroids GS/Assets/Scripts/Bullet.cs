using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour{
    public float lifetime;
    public Vector2 velocity;

    public void Awake(){
        Invoke("DestroySelf", lifetime);
    }

    public void FixedUpdate(){
        HitDetection();
        Move();
    }

    public virtual void HitDetection(){
        if(DetectHit(out var hit, LayerMask.GetMask("Enemy"))){
            hit.collider.GetComponent<Enemy>().OnHit();
            DestroySelf();
        }
    }

    //important: this prevents frame tunneling on really fast bullets
    public bool DetectHit(out RaycastHit2D hit, LayerMask layer){
        hit = Physics2D.Raycast(transform.position, velocity.normalized, velocity.magnitude * Time.fixedDeltaTime, layer);
        return hit.collider != null;
    }

    public void Move(){
        transform.Translate(velocity * Time.fixedDeltaTime, Space.World);
    }

    public void DestroySelf(){
        Destroy(gameObject);
    }
}