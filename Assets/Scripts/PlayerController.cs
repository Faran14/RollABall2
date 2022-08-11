using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody),typeof(SphereCollider))]
public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    //public TextMeshProUGUI ScoreText;
    public GameObject winTextObject;
    public GameObject loseTestObject;
    private Rigidbody rb;
    private int Score;
    //private float movementX;
    //private float movementY;
    private float timer = 150f;
    private float speedTimer = 0f;
    private float growTimer = 0f;
    public Image SpeedBar;
    public Image TimerBar;
    public Image GrowBar;
    public FloatingJoystick FJoy;
    
    public AudioSource saw;
    
    Vector3 OriginalScale = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
       
        rb = GetComponent<Rigidbody>();
        Score = 0;
        timer = 150f;
        //SetScoreText();
        OriginalScale = transform.localScale;
        winTextObject.SetActive(false);
        loseTestObject.SetActive(false);
        updateSpeedBar();
        updateGrowBar();
        updateTimer();
    }

    //private void OnMove(InputValue movementValue)
    //{
    //    Vector2 movementVector = movementValue.Get<Vector2>();

    //    movementX = movementVector.x;
    //    movementY = movementVector.y;
    //}

    //private void OnJump(InputValue value)
    //{
    //    Debug.Log("jumooooooopppppp");
    //    rb.AddForce(Vector2.up * 10, ForceMode.Impulse);
    //}

    private void FixedUpdate()
    {
        //Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        //rb.AddForce(movement * speed);
        timerUpdate();
        speedTimerUpdate();
        growTimerUpdate();
        updateSpeedBar();
        updateTimer();
        updateGrowBar();

        rb.velocity = new Vector3(FJoy.Horizontal * speed, rb.velocity.y, FJoy.Vertical * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            Score = Score + 10;
            //SetScoreText();
        }

        if (other.gameObject.CompareTag("speedramp"))
        {
            speedTimer = 10f;
            saw.Play();
            if (speed <20)
            {
                speed = speed + 20;

            }
        }
        if (other.gameObject.CompareTag("GrowPU"))
        {
            other.gameObject.SetActive(false);
            growTimer = 10f;
            if (transform.localScale.z< 2f)
            {

                transform.localScale += new Vector3(1f, 1f, 1f);
            }
        }
        if (other.gameObject.CompareTag("TurnR"))
        {
            //FC.TurnRight();
            
        }
        if (other.gameObject.CompareTag("Win"))
        {
            //gameObject.SetActive(false);
            //winTextObject.SetActive(true);
            SceneManager.LoadScene(3);


        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Death"))
        {
            //gameObject.SetActive(false);
            //loseTestObject.SetActive(true);
            SceneManager.LoadScene(2);

        }
        //if (collision.gameObject.CompareTag("Win"))
        //{
            
        //    winTextObject.SetActive(true);

        //}
    }

    //void SetScoreText()
    //{
    //    ScoreText.text = "Score: " + Score.ToString();

    //    if (Score >= 11)
    //    {
    //        // Set the text value of your 'winText'
    //        winTextObject.SetActive(true);
    //    }
    //}

    void updateSpeedBar()
    {
        SpeedBar.fillAmount= speedTimer/10f;
    }
    void updateGrowBar()
    {
        GrowBar.fillAmount = growTimer / 10f;
    }
    void updateTimer()
    {
        TimerBar.fillAmount = timer / 150f;
    }
    void speedTimerUpdate()
    {
        if (speedTimer<=0)
        {
            speed = 10;
        }

        if (speedTimer > 0)
        {
            speedTimer -= Time.deltaTime;

        }
    }
    void growTimerUpdate()
    {
        if (growTimer > 0)
        {
            growTimer -= Time.deltaTime;

        }
        if (transform.localScale.z > 1f && growTimer <= 0)
        {
            transform.localScale = OriginalScale;
        }
    }
    void timerUpdate()
    {
        if (timer>0)
        { timer -= Time.deltaTime;
        }
        if (timer<=0)
        {
            gameObject.SetActive(false);
            loseTestObject.SetActive(true);
        }

    }
}