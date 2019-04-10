using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuccessPercentage : MonoBehaviour
{
    private int basicPercentage;
    private int stonPercentage;
    private int reinforceWaterPercentage = 0;
    private int evetPercentage = 0;
    private int vipPercentage = 0;
    private int successPercentage;
    public int itemLevel;


    public int ReinforceSuccessPercentage(int itemReinforceLevel, int stonLevel)
    {
        BasicSuccessPercentage(itemReinforceLevel);
        StonCurrection(stonLevel);

        //강화 성공 확률 = 강화 단계에 따른 기본 성공률 + 강화석과 아이템 레벨 차이에 대한 성공 확률 보정 + 강화수 보정 + 이벤트 보정 + vip 보정 
        successPercentage = basicPercentage + stonPercentage + reinforceWaterPercentage + evetPercentage + vipPercentage;

        return successPercentage;
    }

    private void BasicSuccessPercentage(int itemReinforceLevel)
    {
        if(itemReinforceLevel >=1 || itemReinforceLevel <= 3)
        {
            basicPercentage = 100;
        }
        else
        {
            switch (itemReinforceLevel)
            {
                case 4:
                    basicPercentage = 75;
                    break;
                case 5:
                    basicPercentage = 50;
                    break;
                case 6:
                    basicPercentage = 25;
                    break;
                case 7:
                    basicPercentage = 10;
                    break;
                case 8:
                    basicPercentage = 5;
                    break;
                case 9:
                    basicPercentage = 3;
                    break;
                case 10:
                    basicPercentage = 1;
                    break;
            }
        }
    }
    private void StonCurrection(int stonLevel)
    {
        int levelCheck = itemLevel - stonLevel;
        if (levelCheck >= 10)
        {
            stonPercentage = 10;
        }
        else if (levelCheck <= 9 || levelCheck >= 0)
        {
            stonPercentage = levelCheck;
        }
        else if (levelCheck <= -1 || levelCheck >= -5)
        {
            stonPercentage = levelCheck * 2;
        }
        else if (levelCheck <= -6)
        {
            Debug.Log("이 강화석으로는 강화를 할 수 없습니다.");
        }
    }
}
