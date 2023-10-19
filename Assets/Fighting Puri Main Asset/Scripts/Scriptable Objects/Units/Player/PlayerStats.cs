using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player",menuName = "Character/Stats/Player", order = 1)]


public class PlayerStats : ScriptableObject
{
    
    
    [Header("Based Stats")]
    [SerializeField] private float baseHP;
    [SerializeField] private float baseSP;

    [Header("Speed Stats")]
    [SerializeField] private float Speed = 0f;
    [SerializeField] private float Dodge = 0f;
    
    [Header("Strength Stats")]
    
    [SerializeField] private float extraHP = 0f;

    [SerializeField] private float Damage = 0f;
    
    [Header("Strategy Stats")]

    [SerializeField] private float extraSP = 0f;
    [SerializeField] private float Hit = 0f;

    




}
