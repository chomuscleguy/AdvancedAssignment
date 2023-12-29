using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Heroine", menuName = "Characters/Heroine")]

public class HeroineSO : ScriptableObject
{
    [field: SerializeField] public PlayerGroundData GroundedData { get; private set; }
    [field: SerializeField] public PlayerAirData AirData { get; private set; }
}