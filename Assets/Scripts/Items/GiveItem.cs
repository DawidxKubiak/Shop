using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GiveItem : MonoBehaviour
{
    [SerializeField] GameObject item;
    [SerializeField] Transform startPos;
    [SerializeField] Vector3 endPos;

    public void Give()
    {
        item.transform.position = startPos.position;
        item.transform.DOScale(1f, 1f);
        item.transform.DOMove(endPos,1f);
    }

    public void TakeItem()
    {
        Destroy(item.gameObject);
    }
}
