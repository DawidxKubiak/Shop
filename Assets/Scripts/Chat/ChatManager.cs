using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class ChatManager : MonoBehaviour
{
    [SerializeField] RectTransform chat;
    [SerializeField] float inSpeed = 1f;
    [SerializeField] float outSpeed = 1f;

    [SerializeField] TextMeshProUGUI guestText;

    Vector3 normalScale;

    private void Start()
    {
        normalScale = chat.transform.localScale;
        chat.transform.localScale = Vector3.zero;
    }

    public void ScaleIn()
    {
        chat.transform.DOScale(normalScale, inSpeed);
    }

    public void ScaleOut()
    {
        chat.transform.DOScale(0, outSpeed);
    }

    public void SetGuestText(string textToSet)
    {
        guestText.text = textToSet;
    }
}
