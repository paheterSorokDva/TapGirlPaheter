using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time = 60;
    //public GameObject timerText;
    //[SerializeField] private float time;
    
   // GameHelper _gameHelper;


    private float _timeLeft = 0f;
    public bool _timerOn = false;

    private void Start()
    {
    //    _gameHelper = GameObject.FindAnyObjectByType<GameHelper>();
        _timeLeft = time;
        // _timerOn = true;
        
    }

    private void Update()
    {
        if (_timerOn)
        {
            if (_timeLeft > 0)
            {
                _timeLeft -= Time.deltaTime;
                //_gameHelper.GetComponent<AutoClick>().autoClick();
                UpdateTimeText();

            }
            else
            {
                _timeLeft = time;
                _timerOn = false;
            }
        }
    }

    private void UpdateTimeText()
    {
        if (_timeLeft < 0)
            _timeLeft = 0;

        float minutes = Mathf.FloorToInt(_timeLeft / 60);
        float seconds = Mathf.FloorToInt(_timeLeft % 60);
        GetComponent<TMPro.TextMeshProUGUI>().text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
