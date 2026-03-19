using UnityEngine;
using UnityEngine.InputSystem;

public class MoverPersonaje : MonoBehaviour
{
    [SerializeField] private InputAction accionMover;
    [SerializeField] private InputAction accionSaltar;

    private float velocidadX = 6.5f;
    private float fuerzaSalto = 6.5f;

    private Rigidbody2D rb;

    private EstadoPersonaje estado;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        estado = GetComponentInChildren<EstadoPersonaje>();
    }

    void OnEnable()
    {
        accionMover.Enable();
        accionSaltar.Enable();
        accionSaltar.performed += saltar;
    }

    void OnDisable()
    {
        accionMover.Disable();
        accionSaltar.performed -= saltar;
    }

    void Update()
    {
        Vector2 movimiento = accionMover.ReadValue<Vector2>();
        rb.linearVelocityX = movimiento.x * velocidadX;
    }

    void saltar(InputAction.CallbackContext context)
    {
        if (estado.estaEnPiso)  
        {
            rb.linearVelocityY = fuerzaSalto;
        }
    }
}