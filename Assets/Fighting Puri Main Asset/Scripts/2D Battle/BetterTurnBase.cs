using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BetterTurnBase : MonoBehaviour
{
    [SerializeField]
    private enum State
    {
        Start,
        PlayerTurn,
        EnemyTurn,
        End

    }

    [SerializeField]
    private enum Position
    {
        playerPos1,
        playerPos2,
        playerPos3,
        playerPos4,

        enemyPos1,
        enemyPos2,
        enemyPos3,
        enemyPos4,
    }

    [SerializeField] private PlayerTeam luadTeam;
    [SerializeField] private EnemyProfile enemyPF; 


    

    private State TurnState;

    private Position UnitPosition;


    private void Awake()
    {
    
    }

    private void Start() 
    {
         
    }

    private void FixedUpdate()
    {
        switch (TurnState)
        {
        case State.Start:
            SetupBattle();
            break;
        case State.PlayerTurn:
            StartCoroutine(PlayerTurn());
            break;
        case State.EnemyTurn:
            StartCoroutine(EnemyTurn());
            break;
        case State.End:
            StartCoroutine(EndBattle());
            break;
        }

    }

    private void SetupBattle()
    {
        //Create 4 Slot for Player & Enemy Team 
        //Create instantiate both player and enemy

        //Instantiate 

    }

    IEnumerator EndBattle()
    {
        //End the Battle if the player wins or dies
        yield return new WaitForSeconds(2f);
        TurnState = State.End;
    }
    IEnumerator PlayerTurn()
    {
        //Make sure the player turns to attack the enemy
        yield return new WaitForSeconds(2f);
        
    

    }
    IEnumerator EnemyTurn()
    {
        //Stops the player from attacking the enemy
        yield return new WaitForSeconds(2f);
    }


    private void TurnIndactor()
    {
        //Checks both player unit and enemies stats and stack them accordingly from their speed
        

    }


}
