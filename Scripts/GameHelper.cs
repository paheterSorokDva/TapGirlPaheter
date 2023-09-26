using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameHelper : MonoBehaviour
{
    public GameObject soundButton;

    [SerializeField]public float _HitClick;               // счет урон клика
    public int _ClickCost;           //  счет инт цена клика
    public GameObject _ClickCostUI;  // объект цены клика
    /// <summary>
    /// ////////////////////////// ////////////////////////// ////////////////////////// ///////////////////////
    /// </summary>
    public GameObject TextGoldUI;       // объект отображени€ денег
    public float GoldInt;             // cчет инт денег
    /// <summary>
    /// ////////////////////////// ////////////////////////// ////////////////////////// ///////////////////////
    /// </summary>

    public GameObject TextBril;       // объект отображени€ валюта за просмотр рекламы
    public float BrilInt;           // счет валюты за рекламу



    // Start is called before the first frame update
    void Start()
    {
        
        _ClickCost  = PlayerPrefs.GetInt("÷ена клика");
        _HitClick   = PlayerPrefs.GetFloat("”рон");
        GoldInt     = PlayerPrefs.GetFloat("—чет ƒенег");
        BrilInt     = PlayerPrefs.GetFloat("—чет Ѕрилиантов");
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
        PlayerPrefs.SetInt("÷ена клика", _ClickCost);
        PlayerPrefs.SetFloat("”рон", _HitClick);

        PlayerPrefs.SetFloat("—чет ƒенег", GoldInt);
        PlayerPrefs.SetFloat("—чет Ѕрилиантов", BrilInt);

    }

}
