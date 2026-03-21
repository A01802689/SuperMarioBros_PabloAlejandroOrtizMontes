using UnityEngine;

public class CamaraSeguir : MonoBehaviour
{
    public Transform objetivo; // objetivo en mi caso es Mario.
    public float suavizado = 2f;
    public float offsetX = 1f;   //el ofste es uqetanta discia queiro qeue tenga del objetivo.
    public float alturaFija = 0f; // esto es para que no se vea hacia arriba o abajo la camara.

    void LateUpdate()
    {
        if (objetivo == null) return;

        Vector3 posicionDeseada = new Vector3(
            objetivo.position.x + offsetX,
            alturaFija,
            transform.position.z
        );

        transform.position = Vector3.Lerp(transform.position, posicionDeseada, suavizado * Time.deltaTime);
    }
}