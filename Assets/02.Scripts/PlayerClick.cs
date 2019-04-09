using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClick : MonoBehaviour
{
    private RaycastHit hit;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit)){
                if (hit.collider.gameObject.tag == "Blacksmith")
                {
                    hit.collider.gameObject.SendMessage("StartReinforceUI");
                }
            }
        }
    }
}
