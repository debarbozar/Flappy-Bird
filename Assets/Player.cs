using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Iniciando o jogo
    
    private Animator anim;
    private Rigidbody2D rb2D;
    public float forca = 300;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb2D = GetComponent<Rigidbody2D>();

    }


    // O que o jogo vai fazer a cada bloco
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            anim.SetTrigger("Flappy"); // bater assas
            rb2D.AddForce(Vector2.up * forca); // para o passaro pular 
        } 
    }
}
