using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditKart : MonoBehaviour
{
    public Material whell;
    public Material chassis;

    public void SetWhellBlack()
    {
        whell.color = Color.black;
    }
    public void SetWhellWhite()
    {
        whell.color = Color.white;
    }
    public void SetWhellBlue()
    {
        whell.color = Color.blue;
    }
    public void SetChassisRed()
    {
        chassis.color = Color.red;
    }
    public void SetChassisBlue()
    {
        chassis.color = Color.blue;
    }
    public void SetChassisYellow()
    {
        chassis.color = Color.yellow;
    }
}
