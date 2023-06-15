using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class EndOfDayScreenManager : MonoBehaviour
{
    [SerializeField] Transform ScoreScreen;
    [SerializeField] Transform star1, star2, star3;
    public void EnablePanel()
    {
        ScoreScreen.DOScale(1, 2f).OnComplete(ShowStars);
    }
    
    public void ShowStars()
    {
        star1.DOScale(1, 1f).SetEase(Ease.InExpo)
            .OnComplete(
            () => star2.DOScale(1, 1f).SetEase(Ease.InExpo)
            .OnComplete(
               () => star3.DOScale(1, 1f).SetEase(Ease.InExpo)
                ));
    }
}
