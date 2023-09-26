using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameHelper : MonoBehaviour
{
    public GameObject soundButton;

    [SerializeField]public float _HitClick;               // ���� ���� �����
    public int _ClickCost;           //  ���� ��� ���� �����
    public GameObject _ClickCostUI;  // ������ ���� �����
    /// <summary>
    /// ////////////////////////// ////////////////////////// ////////////////////////// ///////////////////////
    /// </summary>
    public GameObject TextGoldUI;       // ������ ����������� �����
    public float GoldInt;             // c��� ��� �����
    /// <summary>
    /// ////////////////////////// ////////////////////////// ////////////////////////// ///////////////////////
    /// </summary>

    public GameObject TextBril;       // ������ ����������� ������ �� �������� �������
    public float BrilInt;           // ���� ������ �� �������



    // Start is called before the first frame update
    void Start()
    {
        
        _ClickCost  = PlayerPrefs.GetInt("���� �����");
        _HitClick   = PlayerPrefs.GetFloat("����");
        GoldInt     = PlayerPrefs.GetFloat("���� �����");
        BrilInt     = PlayerPrefs.GetFloat("���� ����������");
        if(_HitClick == 0)
        {
            _HitClick = 5;
        }
        if (_ClickCost == 0)
        {
            _ClickCost = 100;
        }
    }

    // Update is called once per frame
    void Update()
    {

        TextGoldUI.GetComponent<TMPro.TextMeshProUGUI>().text = GoldInt.ToString("0");
        TextBril.GetComponent<TMPro.TextMeshProUGUI>().text = BrilInt.ToString();

        _ClickCostUI.GetComponent<TMPro.TextMeshProUGUI>().text = _ClickCost.ToString();
        SaveGame();




    }

    public void upHitAndUpCost()
    {
        if (GoldInt >= _ClickCost)
        {
            GoldInt -= _ClickCost;
            _HitClick += 5;
            _ClickCost += 100;
        }
    }





    public void AdsRewardCoin()
    {
        GoldInt += 3000;
        
    }
    public void AdsRewardBril()
    {
        BrilInt += 10;
    }



    public void SaveGame()
    {
        PlayerPrefs.SetInt("���� �����", _ClickCost);
        PlayerPrefs.SetFloat("����", _HitClick);

        PlayerPrefs.SetFloat("���� �����", GoldInt);
        PlayerPrefs.SetFloat("���� ����������", BrilInt);

    }

}
