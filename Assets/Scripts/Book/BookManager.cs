using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookManager : MonoBehaviour
{
    [SerializeField] GameObject[] pages;
    [SerializeField] GameObject[] buttons;
    [SerializeField] int currentPage = 0;


    private void Start()
    {
        PageChanged(0);
    }


    public void JumpToPage(int index)
    {
        currentPage = index;

        UpdatePageVFX();
    }

    public void PageChanged(int dir)
    {
        currentPage += dir;

        UpdatePageVFX();
    }

    public void SetButtons()
    {
        foreach(var button in buttons)
        {
            button.SetActive(true);
        }
        if (currentPage == 0)
        {
            buttons[0].SetActive(false);
        }
        if (currentPage == pages.Length-1)
        {
            buttons[1].SetActive(false);
        }
    }

    public void UpdatePageVFX()
    {
        foreach (var page in pages)
        {
            page.SetActive(false);
        }

        pages[currentPage].SetActive(true);

        SetButtons();
    }
}
