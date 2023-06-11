using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CustomButton : MonoBehaviour
{
    [SerializeField] UnityEvent OnButtonPressed;

    private void OnMouseDown()
    {
        OnButtonPressed?.Invoke();
    }
}
