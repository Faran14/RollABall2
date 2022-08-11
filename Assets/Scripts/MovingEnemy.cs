using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MovingEnemy : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

        move();
        
    }

    

    private void move()
    {
        //Debug.Log("Is Moving");
        Sequence mySequence = DOTween.Sequence().SetLoops(-1);
        mySequence.Append(transform.DOMoveX(8, 6));
        mySequence.Append(transform.DORotate(new Vector3(0,270,0), 3));
        mySequence.PrependInterval(2);
        mySequence.Append(transform.DOMoveX(-8, 6));
        
        mySequence.Append(transform.DORotate(new Vector3(0, 90, 0), 3));
        
    }
    

}
