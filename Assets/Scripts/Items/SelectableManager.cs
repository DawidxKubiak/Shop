using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectableManager : MonoBehaviour
{
    #region Singleton
    public static SelectableManager instance;
    private void Awake()
    {
        instance = this;
    }
    #endregion

    public List<Selectable> selected;

    public void SetSelected(Selectable selectable)
    {
        if (selectable.GetComponent<Button>() && selected.Count>0 &&  selected[0].GetComponent<Button>())
        {
            selected.Clear();
        }

        if (selected.Contains(selectable))
        {
            selected.Remove(selectable);
        }
        else
        {
            selected.Add(selectable);
        }

        if(selected.Count == 2)
        {
            Debug.Log($"Connected: {selected[0]} and {selected[1]}");
            selected.Clear();
        }
    }

}



