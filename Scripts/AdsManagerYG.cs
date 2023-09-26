using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class AdsManagerYG : MonoBehaviour
{
    public GameHelper gameHelper;
    // Start is called before the first frame update

// ������������� �� ������� �������� ������� � OnEnable
    private void OnEnable() => YandexGame.RewardVideoEvent += Rewarded;

// ������������ �� ������� �������� ������� � OnDisable
    private void OnDisable() => YandexGame.RewardVideoEvent -= Rewarded;

// ����������� ����� ��������� �������
    void Rewarded(int id)
    {
        // ���� ID = 1, �� ����� "+100 �����"
        if (id == 1)
            gameHelper.GetComponent<AutoClick>().autoClickBril();

        // ���� ID = 2, �� ����� "+������".
        else if (id == 2)
            gameHelper.GetComponent<GameHelper>().AdsRewardCoin();

        else if (id == 3)
            gameHelper.GetComponent<GameHelper>().AdsRewardBril();

    }



    // ������������� �� ������� �������� ������� � OnEnable
    //private void OnEnable() => YandexGame.RewardVideoEvent += Rewarded;

    // ������������ �� ������� �������� ������� � OnDisable
    //private void OnDisable() => YandexGame.RewardVideoEvent -= Rewarded;

    // ����������� ����� ��������� �������s


    // ����� ��� ������ ����� �������
    public void ExampleOpenRewardAd(int id)
    {
        // �������� ����� �������� ����� �������
        YandexGame.RewVideoShow(id);
    }
}
