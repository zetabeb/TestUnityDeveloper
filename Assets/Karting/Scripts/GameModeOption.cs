using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModeOption : MonoBehaviour
{

    public void SetGameMode(int gameMode)
    {
        //0 = TimeLimit
        //1 = Racer
        PlayerPrefs.SetInt("gameMode", gameMode);
    }
}
