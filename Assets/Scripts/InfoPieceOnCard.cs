using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InfoPieceOnCard : MonoBehaviour
{
    [SerializeField] ScriptableInfo scriptableInfo;
    [SerializeField] TextMeshProUGUI text;


    public void SetItemInfo(ScriptableInfo info)
    {
        scriptableInfo = info;
        text.text = scriptableInfo.infoName;
    }

    public void DeleteInfo()
    {
        GameObject itemInfo = GameObject.FindGameObjectWithTag("Item Info");
        itemInfo.GetComponent<InfoCollection>().DeleteInfo(scriptableInfo);
    }

}
