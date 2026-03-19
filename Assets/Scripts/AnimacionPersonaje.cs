using System;
using UnityEngine;

public class AnimacionPersonaje : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rb;
    private SpriteRenderer sr;

    private EstadoPersonaje estado;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();

        estado = GetComponentInChildren<EstadoPersonaje>();
    }

    void Update()
    {
        float velocidad = MathF.Abs(rb.linearVelocityX);

        animator.SetFloat("velocidad", velocidad);

        sr.flipX = rb.linearVelocityX < 0;

        animator.SetBool("enPiso", estado.estaEnPiso);
    }
}