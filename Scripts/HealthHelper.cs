using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthHelper : MonoBehaviour
{
    
    public int _MaxHealth = 100;
    public int _Health = 100;
    GameHelper _gameHelper;
    
    // Start is called before the first frame update
    void Start()
    {
        
        _gameHelper = GameObject.FindAnyObjectByType<GameHelper>();
       // GetComponent<SpriteRenderer>().sprite = _gameHelper.MonstersLow[Random.Range(0,5)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   /* public void GetHit(int damage)
    {
        int health = _Health - damage;
        if(health <= 0)
        {
            int w = _gameHelper.MonstersLow.Length;
            GetComponent<SpriteRenderer>().sprite = _gameHelper.MonstersLow[Random.Range(0,5)];
            health = 100;
        }

        _Health = health;
        
    }
   */



}
