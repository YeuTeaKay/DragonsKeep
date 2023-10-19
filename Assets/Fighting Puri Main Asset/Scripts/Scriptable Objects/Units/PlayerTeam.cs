using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "playerTeam", menuName = "Character/playerTeam", order = 0)]
public class PlayerTeam : ScriptableObject 
{

    [SerializeField] private PlayerProfile[] currentTeamPlayers = new PlayerProfile[4];

    [SerializeField] private PlayerProfile[] nonCurrentTeamPlayers = new PlayerProfile[4];

}
