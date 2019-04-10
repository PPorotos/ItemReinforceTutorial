using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject successUI;
    public GameObject failUI;
    public Text priceText;

    private Weapon weapon;
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
        weapon = GameObject.Find("Weapon").GetComponent<Weapon>();
        ston = GameObject.Find("Reinforce Ston").GetComponent<Ston>();

        successPercentage = this.gameObject.GetComponent<SuccessPercentage>();
        commission = this.gameObject.GetComponent<Commission>();

        successPercentage.itemLevel = weapon.itemLevel;
    }

    private void Update()
    {
        percentage = successPercentage.ReinforceSuccessPercentage(weapon.itemReinforceLevel, ston.stonLevel);
        price = commission.ReinforceCommission(weapon.itemLevel, weapon.itemRating);

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
