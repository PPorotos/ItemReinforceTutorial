using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlessedWater : MonoBehaviour
{
    private int weaponReinforceLevel;
    private int currection;

    private void Currection()
    {
        if(weaponReinforceLevel <8 || weaponReinforceLevel > 10)
        {
            Debug.Log("해당 강화 레벨에서는 사용이 불가능합니다.");
        }
        else
        {
            currection = 3;
        }
    }
}
