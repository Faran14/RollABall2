using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MovingPlatformEnemyOPP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        move();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void move()
    {
        Sequence mySequence = DOTween.Sequence().SetLoops(-1);
        mySequence.Append(transform.DOMoveX(7.7f, 3));
        mySequence.PrependInterval(1);
        mySequence.Append(transform.DOMoveX(11.39f, 3));

    }
}
