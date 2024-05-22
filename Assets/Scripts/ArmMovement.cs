using UnityEngine;
using System.Collections;
//using UnityEngine.InputSystem;

//should work for any rb actually
public class ArmMovement : MonoBehaviour
{
    private Rigidbody2D rb;


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {//fjaskdn
        /*Vector2 mPos = Input.mousePosition;
        Vector2 direction = new Vector2(mPos.x-rb.position.x,mPos.y-rb.position.y);
        Debug.Log(direction.x + " " + direction.y);
        rb.AddForce(direction.normalized);*/
        var targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 dir =  new Vector2(targetPos.x,targetPos.y)- new Vector2(rb.position.x, rb.position.y);
        Debug.Log(dir.x + " " + dir.y);
        rb.AddForce(dir.normalized *5);
    }
}