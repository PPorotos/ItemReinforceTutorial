using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blacksmith : MonoBehaviour
{
    public GameObject reinforceUI;
    private RaycastHit hit;

    private void Awake()
    {
        reinforceUI.SetActive(false);
    }
    public void StartReinforceUI()
    {
        reinforceUI.SetActive(true);
    }

}
