using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Launcher : MonoBehaviour
{
    Rigidbody2D rb;
    public float thrust = 10f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            leftClick();

    }
    private void leftClick(){
        rb.AddForce(transform.up * thrust, ForceMode2D.Impulse);
        Debug.Log("Guh?");
    }
}
