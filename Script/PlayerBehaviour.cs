using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBehaviour : MonoBehaviour
{
    public GameObject room1;
    public GameObject room2;
    public GameObject room3;
    public GameObject room4;
    public GameObject room5;
    public GameObject room6;
    public GameObject room7;
    public GameObject room8;
    public GameObject room9;
    public GameObject ghostPanel;
    public GameObject cluePanel;
    public GameObject gameOverPanel;
    public GameObject up;
    public GameObject down;
    public GameObject left;
    public GameObject right;
    public GameObject pause;

    public AudioSource door;

    Rigidbody rb;

    public bool room1Stay = false;
    public bool room2Stay = false;
    public bool room3Stay = false;
    public bool room4Stay = false;
    public bool room5Stay = false;
    public bool room6Stay = false;
    public bool room7Stay = false;
    public bool room8Stay = false;
    public bool room9Stay = false;

    public ButtonBehaviour _Bb;

    LayerMask player;

    public float speed;

    Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = LayerMask.GetMask("Player");
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        Movement();
        PositionCheck();
    }
    void Movement()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(speed, 0, 0);
            transform.localEulerAngles = new Vector3(0, 90, 0);
            anim.SetBool("isWalk", true);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(-speed, 0, 0);
            transform.localEulerAngles = new Vector3(0, -90, 0);
            anim.SetBool("isWalk", true);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3(0, 0, -speed);
            transform.localEulerAngles = new Vector3(0, 180,0);
            anim.SetBool("isWalk", true);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector3(0, 0, speed);
            transform.localEulerAngles = new Vector3(0, 0, 0);
            anim.SetBool("isWalk", true);
        }
        if ((Input.GetKeyUp(KeyCode.A)) || (Input.GetKeyUp(KeyCode.D)) || (Input.GetKeyUp(KeyCode.S)) || (Input.GetKeyUp(KeyCode.W)))
        {
            rb.velocity = Vector3.zero;
            anim.SetBool("isWalk", false);
        }
    }
    public void Up()
    {
        rb.velocity = new Vector3(0, 0, speed);
        transform.localEulerAngles = new Vector3(0, 0, 0);
        anim.SetBool("isWalk", true);
    }
    public void Down()
    {
        rb.velocity = new Vector3(0, 0, -speed);
        transform.localEulerAngles = new Vector3(0, 180, 0);
        anim.SetBool("isWalk", true);
    }
    public void Left()
    {
        rb.velocity = new Vector3(-speed, 0, 0);
        transform.localEulerAngles = new Vector3(0, -90, 0);
        anim.SetBool("isWalk", true);
    }
    public void Right()
    {
        rb.velocity = new Vector3(speed, 0, 0);
        transform.localEulerAngles = new Vector3(0, 90, 0);
        anim.SetBool("isWalk", true);
    }
    public void Check()
    {
        rb.velocity = Vector3.zero;
        anim.SetBool("isWalk", false);
    }

    void PositionCheck()
    {
        if (Physics.CheckSphere(room1.transform.position, 1, player))
        {
            room1Stay = true;
            room2Stay = false;
            room3Stay = false;
            room4Stay = false;
            room5Stay = false;
            room6Stay = false;
            room7Stay = false;
            room8Stay = false;
            room9Stay = false;
            cluePanel.SetActive(false);
            ghostPanel.SetActive(false);
        }
        if (Physics.CheckSphere(room2.transform.position, 1, player))
        {
            room2Stay = true;
            room1Stay = false;
            room3Stay = false;
            room4Stay = false;
            room5Stay = false;
            room6Stay = false;
            room7Stay = false;
            room9Stay = false;
            room8Stay = false;
            cluePanel.SetActive(false);
            ghostPanel.SetActive(false);
        }
        if (Physics.CheckSphere(room3.transform.position, 1, player))
        {
            room3Stay = true;
            room2Stay = false;
            room1Stay = false;
            room4Stay = false;
            room5Stay = false;
            room6Stay = false;
            room7Stay = false;
            room8Stay = false;
            room9Stay = false;
            cluePanel.SetActive(true);
            ghostPanel.SetActive(false);
            up.SetActive(false);
            down.SetActive(false);
            left.SetActive(false);
            right.SetActive(false);
            pause.SetActive(false);
        }
        if (Physics.CheckSphere(room4.transform.position, 1, player))
        {
            room4Stay = true;
            room2Stay = false;
            room3Stay = false;
            room1Stay = false;
            room5Stay = false;
            room6Stay = false;
            room7Stay = false;
            room9Stay = false;
            room8Stay = false;
            cluePanel.SetActive(false);
            ghostPanel.SetActive(false);
        }
        if (Physics.CheckSphere(room5.transform.position, 1, player))
        {
            room5Stay = true;
            room2Stay = false;
            room3Stay = false;
            room4Stay = false;
            room1Stay = false;
            room6Stay = false;
            room7Stay = false;
            room8Stay = false;
            room9Stay = false;
            cluePanel.SetActive(false);
            ghostPanel.SetActive(false);
        }
        if (Physics.CheckSphere(room6.transform.position, 1, player))
        {
            room6Stay = true;
            room2Stay = false;
            room3Stay = false;
            room4Stay = false;
            room1Stay = false;
            room5Stay = false;
            room7Stay = false;
            room8Stay = false;
            room9Stay = false;
            cluePanel.SetActive(false);
            ghostPanel.SetActive(false);
        }
        if (Physics.CheckSphere(room7.transform.position, 1, player))
        {
            room7Stay = true;
            room2Stay = false;
            room3Stay = false;
            room4Stay = false;
            room1Stay = false;
            room6Stay = false;
            room5Stay = false;
            room8Stay = false;
            room9Stay = false;
            cluePanel.SetActive(false);
            ghostPanel.SetActive(true);
            up.SetActive(false);
            down.SetActive(false);
            left.SetActive(false);
            right.SetActive(false);
            pause.SetActive(false);

        }
        if (Physics.CheckSphere(room8.transform.position, 1, player))
        {
            room8Stay = true;
            room2Stay = false;
            room3Stay = false;
            room4Stay = false;
            room1Stay = false;
            room6Stay = false;
            room7Stay = false;
            room5Stay = false;
            room9Stay = false;
            cluePanel.SetActive(false);
            ghostPanel.SetActive(false);
        }
        if (Physics.CheckSphere(room9.transform.position, 1, player))
        {
            room9Stay = true;
            room2Stay = false;
            room3Stay = false;
            room4Stay = false;
            room1Stay = false;
            room6Stay = false;
            room7Stay = false;
            room8Stay = false;
            room5Stay = false;
            cluePanel.SetActive(false);
            ghostPanel.SetActive(false);
        }
    }
    private void OnCollisionEnter(Collision cd)
    {
        if (cd.gameObject.tag == "Room1")
        {
            transform.position = room1.transform.position;
            door.Play();
        }
        if (cd.gameObject.tag == "Room2")
        {
            transform.position = room2.transform.position;
            door.Play();
        }
        if (cd.gameObject.tag == "Room3")
        {
            transform.position = room3.transform.position;
            door.Play();
        }
        if (cd.gameObject.tag == "Room4")
        {
            transform.position = room4.transform.position;
            door.Play();
        }
        if (cd.gameObject.tag == "Room5")
        {
            transform.position = room5.transform.position;
            door.Play();
        }
        if (cd.gameObject.tag == "Room6")
        {
            transform.position = room6.transform.position;
            door.Play();
        }
        if (cd.gameObject.tag == "Room7")
        {
            transform.position = room7.transform.position;
            door.Play();
        }
        if (cd.gameObject.tag == "Room8")
        {
            transform.position = room8.transform.position;
            door.Play();
        }
        if (cd.gameObject.tag == "Room9")
        {
            transform.position = room9.transform.position;
            door.Play();
        }
        if(cd.gameObject.tag=="GameOver")
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
