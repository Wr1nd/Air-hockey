using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public int speed = 1;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {
        var worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPos.z = 0;

        var target = Vector3.MoveTowards(transform.position, worldPos, speed * Time.fixedDeltaTime);

        rb.MovePosition(target);
    }
}
