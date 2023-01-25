using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : Bullet{
    public override void HitDetection(){
        if(DetectHit(out var hit, LayerMask.GetMask("Player"))){
            hit.collider.GetComponent<Player>().OnHit();
            DestroySelf();
        }
    }
}