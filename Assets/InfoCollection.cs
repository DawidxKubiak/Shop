using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoCollection : MonoBehaviour
{
    [SerializeField] GameObject itemInfoPieceOnCardPrefab;
    [SerializeField] Transform itemInfoList;
    [SerializeField]List<ScriptableInfo> list = new List<ScriptableInfo>();

    public void GainInfo(ScriptableInfo info)
    {
        if (list.Contains(info) == false)
       {
            list.Add(info);
        }
        UpdateVFX();
    }

    public void UpdateVFX()
    {
        foreach(Transform child in itemInfoList)
        {
            Destroy(child.gameObject);
        }

        foreach(var info in list)
        {
           var newInfo =  Instantiate(itemInfoPieceOnCardPrefab, itemInfoList);
            newInfo.GetComponent<InfoPieceOnCard>().SetItemInfo(info);
        }
    }

    public void DeleteInfo(ScriptableInfo info)
    {
        list.Remove(info);
        UpdateVFX();
    }


    public void ResetCard()
    {
        for (int i = list.Count - 1; i >= 0; i--)
        {
            DeleteInfo(list[i]);
        }
        UpdateVFX();

        gameObject.transform.position = new Vector3(-6f, -1.5f, 0f);
    }
}
