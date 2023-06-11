using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInfoPiece : MonoBehaviour
{
    [SerializeField] ScriptableInfo info;
    GameObject itemInfo;

    private void Awake()
    {
        itemInfo = GameObject.FindGameObjectWithTag("Item Info");
    }

    public void AddInfo()
    {
        itemInfo.GetComponent<InfoCollection>().GainInfo(info);
    }
}
