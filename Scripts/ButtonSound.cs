using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSound : MonoBehaviour
{
    public Sprite ActiveSprite;
    public Sprite DisableSprite;
    public GameObject SoundMain;
    //public Sprite SpriteButton;
    // Start is called before the first frame update
    void Start()
    {

        ActiveSprite = GetComponent<Image>().sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SwipeSprite()
    {
        if(GetComponent<Image>().sprite == ActiveSprite)
        {
            GetComponent<Image>().sprite = DisableSprite;
            SoundMain.GetComponent<AudioSource>().mute = true;

        }
        else
        {
            GetComponent<Image>().sprite = ActiveSprite;
            SoundMain.GetComponent<AudioSource>().mute = false;
        }
    }    

}
