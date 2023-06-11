using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Events;

public class GuestManager : MonoBehaviour
{
    [SerializeField] GameObject guest;

    [SerializeField] Vector3 startPos = new Vector3(-12f,1.85f,0f);
    [SerializeField] Vector3 endPos = new Vector3(-4.5f,-1.85f,0f);


    [SerializeField] int jumpAmount = 2;
    [SerializeField] float jumpSpeed = 1f;

    [SerializeField] UnityEvent OnWalkIn;

    private void Start()
    {
        guest.transform.position = startPos;
        WalkIn();
    }

    public void WalkIn()
    {
        guest.GetComponentInChildren<SpriteRenderer>().flipX = false;
        guest.transform.DOJump(endPos,1f,jumpAmount,jumpSpeed).SetEase(Ease.Linear).OnComplete(OnWalkInEvent);
    }
    public void WalkOut()
    {
        guest.GetComponentInChildren<SpriteRenderer>().flipX = true;
        guest.transform.DOJump(startPos, 1f, jumpAmount, jumpSpeed).SetEase(Ease.Linear);
    }

    public void OnWalkInEvent()
    {
        OnWalkIn?.Invoke();
    }
}
