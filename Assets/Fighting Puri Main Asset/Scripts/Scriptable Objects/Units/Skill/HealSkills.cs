using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Skill", menuName = "Character/Skill/Heal", order = 1)]
public class HealSkills : ScriptableObject
{


    enum TypeOfHeal
    {
        healOverTime,
        healInstant,

    }
    [Header("Healing Types")]

    [SerializeField] private TypeOfHeal healType;
    

    [Header("Healing Values")]

    [SerializeField] private float healValue = 20f;
    [SerializeField] private int skillRange = 1;

    
    [Header("SFX")]
    
    [SerializeField] private AudioClip skillSound;
}
