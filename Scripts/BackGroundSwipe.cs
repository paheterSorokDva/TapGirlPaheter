using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGroundSwipe : MonoBehaviour
{
    public GameObject BackGround;
    public Sprite[] BackGroundList;
    public int chet;



    // Start is called before the first frame update
    void Start()
    {
        chet = PlayerPrefs.GetInt("—четƒевушек»фона");
        BackGround.GetComponent<Image>().sprite = BackGroundList[chet];
    }

    // Update is called once per frame
    void Update()
    {
        
    }





    public void BackSwipeClick()
    {
        if (chet == BackGroundList.Length - 1)
        {
            chet = 0;
            BackGround.GetComponent<Image>().sprite = BackGroundList[chet];
        }
        else
        {
            chet++;
            BackGround.GetComponent<Image>().sprite = BackGroundList[chet];
        }
    }
}
