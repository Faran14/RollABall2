using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class NEML : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        move();
    }

    void move()
    {
        Sequence mySequence = DOTween.Sequence().SetLoops(-1);
        mySequence.Append(transform.DOMoveX(187.5f, 3));
        mySequence.Append(transform.DORotate(new Vector3(0, 90, 0), 3));
        mySequence.PrependInterval(1);
        mySequence.Append(transform.DOMoveX(201f, 3));
        mySequence.Append(transform.DORotate(new Vector3(0, 270, 0), 3));

    }
}
