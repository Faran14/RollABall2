using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PRight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        move();
    }

    void move()
    {
        Sequence mySequence = DOTween.Sequence().SetLoops(-1);
        mySequence.Append(transform.DOMoveZ(300f, 4));
        mySequence.PrependInterval(1);
        mySequence.Append(transform.DOMoveZ(328.4f, 4));
        mySequence.PrependInterval(4);

    }
}
