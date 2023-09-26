using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoClick : MonoBehaviour
{
    public int BrilCostAutoClick;
    public GameObject BrilCostAutoClickUI;
    public GameObject BrilCostAutoClickTextTime;
    public GameObject BrilCostAutoClickButton;
    public bool AutoClickOn = false;
    public GameObject Girl;
    public GameObject ButtonTextAutoClick;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        BrilCostAutoClickUI.GetComponent<TMPro.TextMeshProUGUI>().text = BrilCostAutoClick.ToString();

        if (BrilCostAutoClickTextTime.GetComponent<Timer>()._timerOn == true)
        {
            
            autoClick();
            BrilCostAutoClickButton.SetActive(false);
            ButtonTextAutoClick.SetActive(true);
        }
        else
        {
            //BrilCostAutoClickButton.GetComponent<Button>().interactable = true;

            //BrilCostAutoClickButton.SetActive(true);
            //ButtonTextAutoClick.SetActive(false);
        }

        if (ButtonTextAutoClick.GetComponent<Timer>()._timerOn == false) 
        {
            BrilCostAutoClickButton.SetActive(true);
            ButtonTextAutoClick.SetActive(false);

        }
        
        
    }

    public void autoClickBril()
    {
       
        
            
            BrilCostAutoClickTextTime.GetComponent<Timer>()._timerOn = true;
            ButtonTextAutoClick.GetComponent<Timer>()._timerOn = true;

            

    }


    public void autoClick()
    {
        Girl.GetComponent<HitHelper>().OnMouseDownAuto();
        
    }

}
