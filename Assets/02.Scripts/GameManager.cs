using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Weapon weapon;
    private Ston ston;
    private UIManager uimanger;

    private SuccessPercentage successPercentage;
    private Commission commission;

    private int percentage;
    private int price;

    private void Start()
    {
        weapon = GameObject.Find("Weapon").GetComponent<Weapon>();
        ston = GameObject.Find("Reinforce Ston").GetComponent<Ston>();
        uimanger = GameObject.Find("UIManager").GetComponent<UIManager>();

        successPercentage = this.gameObject.GetComponent<SuccessPercentage>();
        commission = this.gameObject.GetComponent<Commission>();

        successPercentage.itemLevel = weapon.itemLevel;
    }

    private void Update()
    {
        Reset();
        uimanger.PriceText(price);
    }
    public void Reset()
    {
        percentage = successPercentage.ReinforceSuccessPercentage(weapon.itemReinforceLevel, ston.stonLevel);
        price = commission.ReinforceCommission(weapon.itemLevel, weapon.itemRating);
    }
    public bool Reinforce()
    {
        int temp = Random.Range(0, 101);
        bool check = false;
        Debug.Log(percentage);

        if(temp > percentage)
        {
            Debug.Log(temp + "의 확률로 실패하였습니다.");
            check = false;
        }
        else
        {
            Debug.Log(temp + "의 확률로 성공하였습니다.");
            weapon.itemReinforceLevel += 1;
            uimanger.ReinforceSuccessText(weapon.itemReinforceLevel, weapon.name);
            check = true;
        }
        return check;
    }

}
