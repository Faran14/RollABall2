using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Punch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        move();
    }

    void move()
    {
        Sequence mySequence = DOTween.Sequence().SetLoops(-1);
        mySequence.Append(transform.DOMoveZ(70f, 3));
        mySequence.PrependInterval(1);
        mySequence.Append(transform.DOMoveZ(84f, 3));

    }
}
