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
    {//agility is affected by obj mass drag and the multiplier at the add force function
        var targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 dir =  new Vector2(targetPos.x,targetPos.y)- new Vector2(rb.position.x, rb.position.y);
        Debug.Log(dir.x + " " + dir.y);
        rb.AddForce(dir.normalized *2);
    }
}