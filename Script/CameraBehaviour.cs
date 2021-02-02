using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public Transform room1Pos;
    public Transform room2Pos;
    public Transform room3Pos;
    public Transform room4Pos;
    public Transform room5Pos;
    public Transform room6Pos;
    public Transform room7Pos;
    public Transform room8Pos;
    public Transform room9Pos;

    public GameObject player;

    public PlayerBehaviour _pB;
    void Start()
    {
        
    }
    void Update()
    {
        Position();
    }
    void Position()
    {
        if (_pB.room1Stay)
        {
            transform.position = Vector3.Slerp(transform.position, room1Pos.position, 10 * Time.deltaTime);
        }
        if (_pB.room2Stay)
        {
            transform.position = Vector3.Slerp(transform.position, room2Pos.position, 10 * Time.deltaTime);
        }
        if (_pB.room3Stay)
        {
            transform.position = Vector3.Slerp(transform.position, room3Pos.position, 10 * Time.deltaTime);
        }
        if (_pB.room4Stay)
        {
            transform.position = Vector3.Slerp(transform.position, room4Pos.position, 10 * Time.deltaTime);
        }
        if (_pB.room5Stay)
        {
            transform.position = Vector3.Slerp(transform.position, room5Pos.position, 10 * Time.deltaTime);
        }
        if (_pB.room6Stay)
        {
            transform.position = Vector3.Slerp(transform.position, room6Pos.position, 10 * Time.deltaTime);
        }
        if (_pB.room7Stay)
        {
            transform.position = Vector3.Slerp(transform.position, room7Pos.position, 10 * Time.deltaTime);
        }
        if (_pB.room8Stay)
        {
            transform.position = Vector3.Slerp(transform.position, room8Pos.position, 10 * Time.deltaTime);
        }
        if (_pB.room9Stay)
        {
            transform.position = Vector3.Slerp(transform.position, room9Pos.position, 10 * Time.deltaTime);
        }
    }

}
