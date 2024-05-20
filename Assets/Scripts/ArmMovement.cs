using UnityEngine;
using System.Collections;
//using UnityEngine.InputSystem;

//ASSUME RIGHT HAND USAGE
public class ArmMovement : MonoBehaviour
{
    public Rigidbody2D rb;


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 mPos = Input.mousePosition;
        Vector2 direction = mPos - rb.position;
        Debug.Log(direction.x + " " + direction.y);
        rb.AddForceAtPosition(direction.normalized, mPos);
    }
}