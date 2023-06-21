using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hagle : MonoBehaviour
{
    [SerializeField] int currentPrice = 0;
    [SerializeField] TextMeshProUGUI priceText;
    public void UpdatePriceVFX()
    {
        priceText.text = currentPrice.ToString();
    }

    public void ChangePrice(int amount)
    {
        currentPrice += amount;

        if (currentPrice < 0)
        {
            currentPrice = 0;
        }
        UpdatePriceVFX();
    }
}
