using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCenario : MonoBehaviour
{
    private Rigidbody2D rb2D;
    public float velocidade = -2;
    public float offset = 20;

    void Start()
    {
        rb2D= GetComponent<Rigidbody2D>();
        rb2D.velocity = Vector2.right * velocidade;
    }

    void Update()
    {
        if(transform.position.x <= -offset)
        {
            transform.position += Vector3.right * 2 * offset;
        }
    }
}
