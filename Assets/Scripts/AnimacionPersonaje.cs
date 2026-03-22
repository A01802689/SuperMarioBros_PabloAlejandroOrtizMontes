//Pablo Alejandro Ortiz Montes-A01802689

using System;
using UnityEngine;

public class AnimacionPersonaje : MonoBehaviour //mi Script se llama AnimacionPersonaje
{
    private Animator animator; //Animator es lo que usamos para controlar las animaciones, como el conectarlas.
    private Rigidbody2D rb; //controla la fisica
    private SpriteRenderer sr; //Controla el como se dbuja el sprite

    private EstadoPersonaje estado; // este srive como referencia a otro script que llame EstadoPersonaje.

    void Start()//esto se ejecuata en el inicio
    {
        animator = GetComponent<Animator>(); //Busca el componente de animator en el objeto,sprite
        rb = GetComponent<Rigidbody2D>();// Busca lo que le asigne el rigidbody.
        sr = GetComponent<SpriteRenderer>();//con esto obtiene el sprite

        estado = GetComponentInChildren<EstadoPersonaje>();//Busca al hijo que creamos de Mario que es el Estado de personaje el cual detecta si esta en el suelo o no
    }

    void Update() //esto se ejectua por cada cambio de frame
    {
        float velocidad = MathF.Abs(rb.linearVelocityX);//rb.linearVelocity: hace que la velocidad sea lineal, el MathF.Abs, nos da el valor absoluto.(qeu tan rapido se mueve)
        //basicamnete es para ignroar si va a la izquierda o a la derecha

        animator.SetFloat("velocidad", velocidad);//"velocidad"es el nombre del parametro que coloque en mi animator 

        sr.flipX = rb.linearVelocityX < 0;// esto detecta que si detecta que si la velocidad se vuelve negativa hcaae qeu el personaje cambie de posicion.

        animator.SetBool("enPiso", estado.estaEnPiso);//"enPiso"es el nombre del parametro que coloque en mi animator
    }
}