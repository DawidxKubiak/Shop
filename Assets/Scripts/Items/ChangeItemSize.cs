using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeItemSize : Draggable
{
    [SerializeField] GameObject bigItem;
    [SerializeField] GameObject smallItem;

    [SerializeField] Vector2 bigColliderSize = new Vector2(8, 5);
    [SerializeField] Vector2 smallColliderSize = new Vector2(1, 1);

    [SerializeField] float Ylimit = -3f;
    bool isUnder = true;

    private void OnMouseDrag()
    {
        if(transform.position.y < Ylimit)
        {
            isUnder = true;
        }else isUnder = false;

        if (isUnder)
        {
            smallItem.SetActive(true);
            bigItem.SetActive(false);
            transform.GetComponent<BoxCollider2D>().size = smallColliderSize;
        }
        else
        {
            smallItem.SetActive(false);
            bigItem.SetActive(true);
            transform.GetComponent<BoxCollider2D>().size = bigColliderSize;
        }
    }
}
