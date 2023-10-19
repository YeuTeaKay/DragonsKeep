using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



[CreateAssetMenu(fileName = "Profile", menuName = "Character/Profile/Player", order = 1)]
public class PlayerProfile : ScriptableObject    
{
    
   
    [SerializeField] private string UnitName;
    [SerializeField] private float UnitLevel;

    [SerializeField] private Image playerProfilePic;

    [SerializeField] private PlayerStats playerStats;
}
