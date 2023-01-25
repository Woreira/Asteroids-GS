using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstrainToScreen : MonoBehaviour{
    
    void Update(){
        CheckScreenConstrain();
    }
    
    void CheckScreenConstrain(){
        if(transform.position.y > 5f) transform.position = new Vector2(transform.position.x, -5f);
        else if(transform.position.y < -5f) transform.position = new Vector2(transform.position.x, 5f);
        else if(transform.position.x > 8f) transform.position = new Vector2(-8f, transform.position.y);
        else if(transform.position.x < -8f) transform.position = new Vector2(8f, transform.position.y);
    }
}