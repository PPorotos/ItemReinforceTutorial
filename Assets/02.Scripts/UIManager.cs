using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //메인 강화 UI
    public GameObject reinforceUI;

    //각 확인 메시지 UI
    public GameObject reinforceSuccessUI;
    public GameObject reinforceFailUI;
    public GameObject reinforceLevelDownUI;

    //강화 비용 출력 UI
    public Text priceText;

    //강화 성공 텍스트
    public Text reinforceSuccessText;

    private GameManager gameManager;

    private void Awake()
    {
        reinforceUI.SetActive(false);
        reinforceSuccessUI.SetActive(false);
        reinforceFailUI.SetActive(false);
        reinforceLevelDownUI.SetActive(false);
    }
    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    //강화 버튼
    public void ReinforceButtonClick()
    {
        gameManager.Reset();
        bool check = gameManager.Reinforce();
        if (check)
        {
            reinforceSuccessUI.SetActive(true);
        }
        else
        {
            reinforceFailUI.SetActive(false);
        }
    }

    //종료 버튼
    public void ExitButtonClick()
    {
        reinforceUI.SetActive(false);
    }

    //각 확인 메시지 UI 확인 버튼 
    public void ReinforceSuccessUIButton()
    {
        reinforceSuccessUI.SetActive(false);
    }
    public void ReinforceFailUIButton()
    {
        reinforceFailUI.SetActive(false);
    }
    public void ReinforceLevelDownButton()
    {
        reinforceLevelDownUI.SetActive(false);
    }

    //강화 성공 메시지
    public void ReinforceSuccessText(int itemReinforceLevel, string itemName)
    {
        reinforceSuccessText.text = "아이템 강화에 성공하여 +" + itemReinforceLevel.ToString() + itemName + "아이템이 되었습니다.";
    }

    //강화 비용 출력
    public void PriceText(int price)
    {
        priceText.text = price.ToString() + "골드";
    }
}
