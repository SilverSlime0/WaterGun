using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Launcher : MonoBehaviour
{
    public float forceS = 10f;

    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;
        Vector3 direction = mousePos - transform.position;
        transform.up = direction.normalized;
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().AddForce(-transform.up * forceS, ForceMode2D.Impulse);
        }
    }
}
