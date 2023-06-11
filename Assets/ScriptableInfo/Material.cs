using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Material", menuName = "SO/Materials")]
public class Material : ScriptableInfo
{
    public Material()
    {
        Type = InfoType.material;
    }
}
