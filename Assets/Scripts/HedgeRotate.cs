using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HedgeRotate : MonoBehaviour
{
    
    void Start()
    {
        move();
    }

    void move()
    {
        Sequence mySequence = DOTween.Sequence().SetLoops(-1);
        mySequence.Append(transform.DORotate(new Vector3(0, 270, 0), 15));


    }
}
