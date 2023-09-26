using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class AdsManagerYG : MonoBehaviour
{
    public GameHelper gameHelper;
    // Start is called before the first frame update

// Подписываемся на событие открытия рекламы в OnEnable
    private void OnEnable() => YandexGame.RewardVideoEvent += Rewarded;

// Отписываемся от события открытия рекламы в OnDisable
    private void OnDisable() => YandexGame.RewardVideoEvent -= Rewarded;

// Подписанный метод получения награды
    void Rewarded(int id)
    {
        // Если ID = 1, то выдаём "+100 монет"
        if (id == 1)
            gameHelper.GetComponent<AutoClick>().autoClickBril();

        // Если ID = 2, то выдаём "+оружие".
        else if (id == 2)
            gameHelper.GetComponent<GameHelper>().AdsRewardCoin();

        else if (id == 3)
            gameHelper.GetComponent<GameHelper>().AdsRewardBril();

    }



    // Подписываемся на событие открытия рекламы в OnEnable
    //private void OnEnable() => YandexGame.RewardVideoEvent += Rewarded;

    // Отписываемся от события открытия рекламы в OnDisable
    //private void OnDisable() => YandexGame.RewardVideoEvent -= Rewarded;

    // Подписанный метод получения наградыs


    // Метод для вызова видео рекламы
    public void ExampleOpenRewardAd(int id)
    {
        // Вызываем метод открытия видео рекламы
        YandexGame.RewVideoShow(id);
    }
}
