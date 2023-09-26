using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttontimer : MonoBehaviour
{
    public GameObject Gamehelper;

    public GameObject Button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Timer>()._timerOn == true)
        {
            Button.GetComponent<Button>().interactable = false;
        }
        else
        {
            Button.GetComponent<Button>().interactable = true;
        }
    }



    public void StartTime()
    {
        GetComponent<Timer>()._timerOn = true;
    }

}
