using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.KartSystems;

public class Power : MonoBehaviour
{
    public ArcadeKart arcadeKart;
    public GameObject arcadecart;

    float accelerationInicial;
    float SteerInicial;
    float SpeedInicial;

    private void Start()
    {
        arcadecart = GameObject.FindWithTag("Player");
        arcadeKart = arcadecart.GetComponent<ArcadeKart>();
        SpeedInicial = arcadeKart.GetTopSpeed();
        accelerationInicial = arcadeKart.GetAcceleration();
        SteerInicial = arcadeKart.GetSteer();
        GameFlowManager.instance.initialSpeed = SpeedInicial;
    }
    IEnumerator NoticeOn()
    {
        gameObject.GetComponentInChildren<Canvas>().enabled = true;
        yield return new WaitForSeconds(1f);
        gameObject.GetComponentInChildren<Canvas>().enabled = false;
    }
    

    IEnumerator TurboOn()
    {
        //arcadeKart.SetAcceleration(16f);
        GameFlowManager.instance.AddTurbo();
        StartCoroutine(NoticeOn());
        yield return new WaitForSeconds(2f);
        //arcadeKart.SetAcceleration(accelerationInicial);
    }
    IEnumerator LostControlOn()
    {
        arcadeKart.SetSteer(20f);
        StartCoroutine(NoticeOn());
        yield return new WaitForSeconds(5f);
        arcadeKart.SetSteer(SteerInicial);
    }
    IEnumerator TopSpeedUp()
    {
        arcadeKart.SetTopSpeed(20f);
        StartCoroutine(NoticeOn());
        yield return new WaitForSeconds(5f);
        arcadeKart.SetTopSpeed(SpeedInicial);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("GetPower");


            switch (this.gameObject.name)
            {
                case "Turbo":
                    Debug.Log("Turbo!!");
                    
                    StartCoroutine(TurboOn());
                    break;

                case "LostControl":
                    Debug.Log("LostControl!!");
                    StartCoroutine(LostControlOn());
                    break;

                case "SpeedUp":
                    Debug.Log("Speed Up!!");
                    StartCoroutine(TopSpeedUp());
                    break;
            }
            
        }

    }
}
