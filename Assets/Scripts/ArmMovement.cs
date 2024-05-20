using UnityEngine;
using System.Collections;
//using UnityEngine.InputSystem;

//ASSUME RIGHT HAND USAGE
public class ArmMovement : MonoBehaviour
{
    private Rigidbody2D rb;


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {//fjaskdn
        Vector2 mPos = Input.mousePosition;
        Vector2 direction = new Vector2(mPos.x-rb.position.x,mPos.y-rb.position.y);
        Debug.Log(direction.x + " " + direction.y);
        rb.AddForce(direction.normalized);
    }
}