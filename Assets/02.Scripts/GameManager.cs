using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject successUI;
    public GameObject failUI;
    public Text priceText;

    public Weapon weapon;
    public Ston ston;

    public SuccessPercentage successPercentage;
    public Commission commission;

    private int percentage;
    private int price;

    private void Awake()
    {
        successUI.SetActive(false);
        failUI.SetActive(false);
    }

    private void Start()
    {
        weapon = GetComponent<Weapon>();
        ston = GetComponent<Ston>();

        successPercentage = GetComponent<SuccessPercentage>();
        commission = GetComponent<Commission>();

        commission.itemLevel = weapon.itemLevel;
        commission.weaponRating = weapon.itemRating;

        successPercentage.itemLevel = weapon.itemLevel;
        successPercentage.itemReinforceLevel = weapon.itemReinforceLevel;
        successPercentage.stonLevel = ston.stonLevel;
    }

    private void Update()
    {
        percentage = successPercentage.ReinforceSuccessPercentage();
        price = commission.ReinforceCommission();

        priceText.text = price.ToString();

    }

    public void Reinforce()
    {
        int temp = Random.Range(0, 101);

        if(temp > percentage)
        {
            Debug.Log(temp + "의 확률로 실패하였습니다.");
            failUI.SetActive(true);
        }
        else
        {
            Debug.Log(temp + "의 확률로 성공하였습니다.");
            successUI.SetActive(true);
        }
    }

}
