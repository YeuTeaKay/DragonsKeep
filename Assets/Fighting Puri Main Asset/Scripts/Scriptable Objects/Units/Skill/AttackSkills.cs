using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Skill", menuName = "Character/Skill/Attack", order = 1)]
public class AttackSkills : ScriptableObject
{
    
    enum TypeOfDamage
    {
        damageOverTime,
        damageInstant,

    }

    [Header("Damage Types")]

    [SerializeField] private TypeOfDamage damageType;


    [Header("Damage Values")]

    [SerializeField] private float damageValue = 20f;
    [SerializeField] private int skillRange = 1;

    

    [Header("SFX")]
    [SerializeField] private AudioClip skillSound;
}
