using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class HitHelper : MonoBehaviour
{
    public GameObject TextDamage;
    public GameObject TextGold;
   
    GameHelper _gameHelper;
    private float hit;

    public AudioClip audioClick;

    public AudioClip[] audioStons;
    public int ChetStonov;
    public int ChetDoStonov;

    //private int schet = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        _gameHelper = GameObject.FindAnyObjectByType<GameHelper>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        //hit = _gameHelper._HitClick / 10;
        GetComponent<Animator>().SetTrigger("Hit");
        //GetComponent<HealthHelper>().GetHit(_gameHelper._HitClick);
        soundClick();


        ChetDoStonov++;
        if (ChetDoStonov == 15)
        {
            GetComponent<AudioSource>().PlayOneShot(audioStons[ChetStonov]);
            if (ChetStonov == audioStons.Length - 1)
            {
                ChetStonov = 0;
            }
            else
            {
                ChetStonov++;
            }
            ChetDoStonov = 0;
        }
        


        TextDamage.GetComponent<Animator>().SetTrigger("klick");
        TextDamage.GetComponent<TMPro.TextMeshProUGUI>().text = "+" + _gameHelper._HitClick.ToString(); 
        _gameHelper.GoldInt += _gameHelper._HitClick;
        
        


    }

    public void OnMouseDownAuto()
    {
        hit = 0.05f;
        GetComponent<Animator>().SetTrigger("Hit");
        //GetComponent<HealthHelper>().GetHit(_gameHelper._HitClick);


        //TextDamage.GetComponent<Animator>().SetTrigger("klick");
        //TextDamage.GetComponent<TMPro.TextMeshProUGUI>().text = "+" + hit.ToString();
        _gameHelper.GoldInt += hit;
       // GetComponent<AudioSource>().PlayOneShot(audioClick); /// лучше без звука



    }


    public void soundClick()
    {
        GetComponent<AudioSource>().PlayOneShot(audioClick);
    }



    

}
