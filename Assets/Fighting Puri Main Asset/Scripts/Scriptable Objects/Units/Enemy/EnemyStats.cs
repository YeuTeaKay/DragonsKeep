using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy",menuName = "Character/Stats/Enemy", order = 1)]
public class EnemyStats : ScriptableObject
{
    
    
    [Header("Based Stats")]
    public string UnitName;
    public float UnitLevel;
    public float baseHP;
    public float baseSP;

    [Header("Speed Stats")]
    public float Speed = 0f;
    public float Dodge = 0f;
    
    [Header("Strength Stats")]
    
    public float extraHP = 0f;

    public float Damage = 0f;
    
    [Header("Strategy Stats")]

    public float extraSP = 0f;
    public float Hit = 0f;

    




}
