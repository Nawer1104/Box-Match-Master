using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Box : MonoBehaviour
{
    public Target target;

    private void OnMouseDown()
    {
        GetComponent<BoxCollider2D>().enabled = false;

        transform.DOMove(target.transform.position, 1f).OnComplete(() => {
            target.AddBox(this);
        });
    }
}
