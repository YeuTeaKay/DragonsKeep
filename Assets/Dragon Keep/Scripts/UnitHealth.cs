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

    public void TakeDamage(int damage)
    {
        if(!isServer)
        {
            return;
        }

        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            currentHealth = maxHealth;
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
            transform.position = Vector3.zero;
        }
    }
}
