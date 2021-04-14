using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameFlowManager gameManager;
    void SetPositionRespawn()
    {
        gameManager.RespawnLocation = this.gameObject.transform;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") )
        {
            SetPositionRespawn();
        }
    }

}
