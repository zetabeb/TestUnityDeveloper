using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ontrigger : MonoBehaviour
{
    public string otherTag = "Player";
    public UnityEvent onTriggerEventEnter = new UnityEvent();
    public UnityEvent onTriggerEventEnterOther = new UnityEvent();
    public UnityEvent onTriggerEventExit = new UnityEvent();



    private void OnTriggerEnter(Collider other)
    {
        //if (other.name == "Jugador")
        if (other.CompareTag(otherTag))
        {
            Debug.Log("Enter "+otherTag );
            onTriggerEventEnter.Invoke();
        }
        if (!other.CompareTag(otherTag))
        {
            Debug.Log("Enter " + otherTag);
            onTriggerEventEnterOther.Invoke();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        //if (other.name == "Jugador")
        if (other.CompareTag(otherTag))
        {
            onTriggerEventExit.Invoke();
        }
    }
}
