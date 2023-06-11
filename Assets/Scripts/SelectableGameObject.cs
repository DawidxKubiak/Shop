using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Selectable))]
public class SelectableGameObject : MonoBehaviour
{
    [SerializeField] GameObject objectToSelect;

    private void OnMouseDown()
    {
        objectToSelect.GetComponent<Selectable>().SelectThis();
    }
}
