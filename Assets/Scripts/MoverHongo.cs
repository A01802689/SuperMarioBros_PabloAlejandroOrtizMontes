
//Pablo Alejandro Ortiz Montes-A01802689
using UnityEngine;
public class MoverHongo : MonoBehaviour
{
    public float velocidad = 2f;//velocidad del movimiento del hongo
    private int direccion = 1; // -1 es izqueirda, 1 es derecha y 0 es sin movimiento, le decimos que empiece a camniar de lado derecho

    void Update()
    {
        transform.Translate(Vector2.right * direccion * velocidad * Time.deltaTime);
    }                      //muestra (1,0)"derecha" |direccion puede ser -1 o 1| * velocidad que se tiene 
    public void CambiarDireccion()
    {
        direccion *= -1; //hace que la direccion ahora sea negativa haciendo que se mueva hacia la izaqueirda.
    }
}