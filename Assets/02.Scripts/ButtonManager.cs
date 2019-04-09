using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject reinforceUI;

    public void ReinforceButtonClick()
    {

    }
    public void ExitButtonClick()
    {
        reinforceUI.SetActive(false);
    }
}
