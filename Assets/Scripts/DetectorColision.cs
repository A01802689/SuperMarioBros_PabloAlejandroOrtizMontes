//Pablo Alejandro Ortiz Montes-A01802689
using UnityEngine;

public class DetectorColision : MonoBehaviour
{
    private MoverHongo hongo;//esto es una instancia del otro script MoverHongo

    void Start()
    {
        hongo = GetComponentInParent<MoverHongo>();//busaca el escript que esta en el padre HongoMalo.
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        hongo.CambiarDireccion();//se va a la funcion de cambiar de CambiarDireccion(), que viene del scritp MoverHongo.
    }
}