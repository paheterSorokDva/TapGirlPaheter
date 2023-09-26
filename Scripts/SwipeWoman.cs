using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class SwipeWoman : MonoBehaviour
{
    public GameObject GirlImage;
    public GameObject GoldCostWifu;
    public int BrilCostGold;
    public GameObject BrilCostWifuUI;
    public int BrilCostWifu;
    public Sprite[] AnimeGirlSpisok;
    public int chet;
    // Start is called before the first frame update
    void Start()
    {
        chet = PlayerPrefs.GetInt("����������������");
        
        BrilCostWifu = PlayerPrefs.GetInt("���������������������");
        BrilCostGold = PlayerPrefs.GetInt("�����������������u����");
        if (BrilCostWifu == 0)
        {
            BrilCostWifu = 10;
        }

        if (BrilCostGold == 0)
        {
            BrilCostGold = 5;
        }
        
        GirlImage.GetComponent<Image>().sprite = AnimeGirlSpisok[chet];
    }

    // Update is called once per frame
    void Update()
    {
        GoldCostWifu.GetComponent<TMPro.TextMeshProUGUI>().text = BrilCostGold.ToString() + "K";
        BrilCostWifuUI.GetComponent<TMPro.TextMeshProUGUI>().text = BrilCostWifu.ToString();
        
    }


    public void swipeWifuGold()
    {
        if (GetComponent<GameHelper>().GoldInt >= (BrilCostGold * 1000))
        {
            GetComponent<GameHelper>().GoldInt -= (BrilCostGold * 1000);
            BrilCostGold += 3;
            saveGirlAndBack();
        }

    }

    public void swipeWifuBril()
    {
        if (GetComponent<GameHelper>().BrilInt >= BrilCostWifu)
        {
            GetComponent<GameHelper>().BrilInt -= BrilCostWifu;
            BrilCostWifu += 5;
            saveGirlAndBack();


        }
    }




    public void SwipeImageClick()
    {
        if (chet == AnimeGirlSpisok.Length - 1)
        {
            chet = 0;
            GirlImage.GetComponent<Image>().sprite = AnimeGirlSpisok[chet];
        }
        else
        {
            chet++;
            GirlImage.GetComponent<Image>().sprite = AnimeGirlSpisok[chet];
        }
    }



    public void saveGirlAndBack()
    {
        GetComponent<BackGroundSwipe>().BackSwipeClick();               /// ����� ����� ����
        SwipeImageClick();                                              /// ����� ����� ������� 

        PlayerPrefs.SetInt("����������������", chet);                   /// ����. ��������
        PlayerPrefs.SetInt("���������������������", BrilCostWifu);      /// ����.
        PlayerPrefs.SetInt("�����������������u����", BrilCostGold);     /// ����.
    }
}
