using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;

public class UnitHealth : NetworkBehaviour
{
    public const int maxHealth = 100;
    [SyncVar(hook = nameof(OnChangeHealth))]
    public int currentHealth = maxHealth;
    public RectTransform healthbar;
    public bool destroyOnDeath;

    private Vector3 respawnPosition;

    
    public override void OnStartServer()
    {
        base.OnStartServer();
        

        respawnPosition = transform.position;
    }

    public void TakeDamage(int damage)
    {
        if(!isServer)
        {
            return;
        }


        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            if (destroyOnDeath)
            {
                Destroy(gameObject);
            }
            RpcRespawn();
        }
    }

    public void OnChangeHealth(int oldhealth, int newhealth)
    {
        healthbar.sizeDelta = new Vector2(newhealth * 2, healthbar.sizeDelta.y);
    }

    [ClientRpc]
    void RpcRespawn()
    {
        if(isLocalPlayer)
        {
            CmdRespawn();
        }
    }

    [Command]
    private void CmdRespawn()
    {
        // Set the player's position to the respawn position
        transform.position = respawnPosition;
        
        // Reset health to maxHealth after respawn
        currentHealth = maxHealth;
    }
}
