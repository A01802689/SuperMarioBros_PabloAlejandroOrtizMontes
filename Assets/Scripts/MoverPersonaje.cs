//Pablo Alejandro Ortiz Montes-A01802689
using UnityEngine;
using UnityEngine.InputSystem;

public class MoverPersonaje : MonoBehaviour //nombre de mi script es MoverPersonaje 
{
    [SerializeField] private InputAction accionMover; // me deja colocar los botones desde la seccion de inspector.
    [SerializeField] private InputAction accionSaltar;// ocurre lo mismo que mi comentario de arriba

    private float velocidadX = 6.5f;//que tan rapido se movera el personaje 
    private float fuerzaSalto = 6.5f;//con cuanta fuerza saltara.

    private Rigidbody2D rb;// llamaos al rigid boy que le colocaremos al sprite y este nos da como la fisica que tendra el sprite

    private EstadoPersonaje estado; //Llamamos a otros Script llamdo EstadoPersoanje que es hijo del sprite que tendra esto.

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();//obtenemos el rigidBody del Sprite
        estado = GetComponentInChildren<EstadoPersonaje>();//obtenemos el  hijo del sprite que tendra esto.
    }

    void OnEnable() //cuando el objeto se activa
    {
        accionMover.Enable();//caundo se presione algunso de los botones de accionMover, se activa los inputs 
        accionSaltar.Enable();//caundo se presione saltar, se activa el inputs 
        accionSaltar.performed += saltar;
    }

    void OnDisable() //este hace todo lo contrario que OnEnable
    {
        accionMover.Disable();
        accionSaltar.Disable();
        accionSaltar.performed -= saltar;
    }

    void Update()
    {
        Vector2 movimiento = accionMover.ReadValue<Vector2>();// obtiene la direccion de los inputs flecha izqueirda=-1, derecha =1, sin moverme 0
        rb.linearVelocityX = movimiento.x * velocidadX; // si el movimiento va a la izquierda el valor sera-1, si va a la derecha sera 1
        //linear VelocityX es la velocidad en el eje x = direccion del input multipliacdo por la velocidad base.
    }

    void saltar(InputAction.CallbackContext context)//esto se ejecuta cuando detecta que tecle el boton que le asigne a salto en inspector.
    {
        if (estado.estaEnPiso)  //Esto me dice que si el sprote esta en el piso me dejara saltar
        {
            rb.linearVelocityY = fuerzaSalto;// esta es la fuerza con la que me dejara saltar en el eje y
        }
    }
}