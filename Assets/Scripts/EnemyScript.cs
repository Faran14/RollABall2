using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 direction = new Vector3(0f,0f,1f);
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        move();
    }

    private void move()
    {
        Debug.Log("3ge");
        rb.AddForce(direction * 0.5f);
        Wait(25f);
        rb.transform.Rotate(0f, 20f, 0f);
        Wait(5f);
        rb.transform.Rotate(0f, 20f, 0f);
        Wait(5f);
        rb.transform.Rotate(0f, 20f, 0f);
        Wait(5f);
        rb.transform.Rotate(0f, 20f, 0f);
        Wait(5f);
        rb.transform.Rotate(0f, 20f, 0f);
        Wait(5f);
    }

    public IEnumerator Wait(float delayInSecs)
    {
        yield return new WaitForSeconds(delayInSecs);
    }
}
