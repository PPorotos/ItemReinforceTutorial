using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int itemLevel;
    public int itemReinforceLevel;
    public string itemRating = "unique";

    private void Start()
    {
        itemLevel = 100;
        itemReinforceLevel = 2;
    }
}
