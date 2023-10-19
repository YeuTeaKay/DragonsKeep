using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



[CreateAssetMenu(fileName = "EnemyProfile", menuName = "Character/Profile/Enemy", order = 0)]
public class EnemyProfile : ScriptableObject    
{
    
    [Header("Player Profile")]
    [SerializeField] private string UnitName;
    [SerializeField] private float UnitLevel;

    [SerializeField] private Image playerProfilePic;

    [SerializeField] private PlayerStats playerStats;
}
