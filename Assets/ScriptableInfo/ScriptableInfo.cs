using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableInfo : ScriptableObject
{
    public string infoName;
    public InfoType Type;
}

public enum InfoType
{
    itemType,
    origin,
    material
}
