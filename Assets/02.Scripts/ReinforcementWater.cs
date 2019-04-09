using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReinforcementWater : MonoBehaviour
{
    private int weaponReinforceLevel;
    private int currection;

    private void Currection()
    {
        if(weaponReinforceLevel > 7)
        {
            Debug.Log("해당 강화 레벨에서는 사용이 불가능합니다.");
        }
        else
        {
            currection = 5;
        }
    }
}
