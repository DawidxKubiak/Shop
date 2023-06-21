using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Condition", menuName = "SO/Condition")]
public class Condition : ScriptableInfo
{
    public Condition()
    {
        Type = InfoType.condition;
    }
}
