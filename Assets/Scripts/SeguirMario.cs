//Pablo Alejandro Ortiz Montes-A01802689
using UnityEngine;
public class CamaraSeguir : MonoBehaviour
{
    public Transform objetivo; // objetivo en mi caso es Mario.
    public float suavizado = 2f; //en si es que tan rapido se mueve la camara.
    public float offsetX = 1f;   //el ofste es uqetanta discia queiro qeue tenga del objetivo. (1= derecha, -1=izqueirda)
    public float alturaFija = 0f; // esto es para que no se vea hacia arriba o abajo la camara.

    void LateUpdate()//porimeor se mueve se mueva mario y despues se mueve la camara.
    {
        if (objetivo == null) return; //si no le asigne esto a mario o a algo no se ejecuta nada del codigo.

        Vector3 posicionDeseada = new Vector3(
            objetivo.position.x + offsetX, //esto sigue a mario de forma horizontal mas el offset
            alturaFija,//la altura no cambia
            transform.position.z// hace que se mantenga en 2d
        );

        transform.position = Vector3.Lerp(transform.position, posicionDeseada, suavizado * Time.deltaTime);
        /*lerp mueve la camara de poco en poco hasta la posicon que le diga
          Lerp(Posicion Actual, Posicion de Mario/objetivo, que tan rapido deberia acercarse)*/
    }
}