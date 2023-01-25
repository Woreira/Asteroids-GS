using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class UIManager : MonoBehaviour{

    public Text scoreText;
    public List<GameObject> healthBars;

    public static UIManager singleton;

    void Awake(){
        singleton = this;
    }

    public void UpdateScore(){
        scoreText.text = Player.singleton.score.ToString("00000000");
    }

    public void UpdateHealthBar(){
        
        healthBars.ForEach(x => x.SetActive(false));

        for(int i = 0; i < Player.singleton.hp; i++){
            healthBars[i].SetActive(true);
        }
    }
}