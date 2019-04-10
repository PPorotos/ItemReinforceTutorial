using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Commission : MonoBehaviour
{
    private float basicCommission = 100.0f;
    private float uniqueLevel;
    private float eventDistcount = 0;
    private float vipDiscount = 0;
    private int reinforceCommission;

    public int ReinforceCommission(float itemLevel, string itemRating)
    {
        uniqueCurrection(itemRating);
        //강화 수수료 = 아이템Level * 기본수수료 * 희귀도 보정 * (1 - (이벤트 할인보정 + vip 할인 보정))
        reinforceCommission = (int)(itemLevel * basicCommission * uniqueLevel * (1 - (eventDistcount + vipDiscount)));

        return reinforceCommission;
    }

    private void uniqueCurrection(string itemRating)
    {
        switch (itemRating)
        {
            case "low":
                uniqueLevel = 1.0f;
                break;
            case "nomal":
                uniqueLevel = 1.1f;
                break;
            case "high":
                uniqueLevel = 1.2f;
                break;
            case "unique":
                uniqueLevel = 1.3f;
                break;
            case "hero":
                uniqueLevel = 1.4f;
                break;
            case "legendary":
                uniqueLevel = 1.5f;
                break;
        }
    }

}
