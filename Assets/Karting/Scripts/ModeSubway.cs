using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSubway : MonoBehaviour
{
    public GameObject arcadeKart;
    int CountLeft = 2;
    int CountRigth = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)){
            if (CountLeft > 0)
            {
                arcadeKart.transform.Translate(-2.80f, 0, 0);
                CountLeft--;
                CountRigth++;
            }
        }
        if (Input.GetKeyDown(KeyCode.D)){
            if(CountRigth > 0)
            {
                arcadeKart.transform.Translate(2.80f, 0, 0);
                CountLeft++;
                CountRigth--;
            }
        }
    }
}
