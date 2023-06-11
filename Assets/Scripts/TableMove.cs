using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class TableMove : MonoBehaviour
{
    [SerializeField] Vector3 onPosition;
    [SerializeField] Vector3 offPosition;
    [SerializeField] float timeIn = 1f;
    [SerializeField] float timeOff = 1f;

    public void SetIn()
    {
        transform.DOMove(onPosition, timeIn).SetEase(Ease.OutBounce);
    }

    public void SetOut()
    {
        transform.DOMove(offPosition, timeOff);
    }
}
