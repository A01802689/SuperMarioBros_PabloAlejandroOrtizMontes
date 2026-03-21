using UnityEngine;

public class MoverHongo : MonoBehaviour
{
    public float velocidad = 2f;
    private int direccion = 1; 

    void Update()
    {
        transform.Translate(Vector2.right * direccion * velocidad * Time.deltaTime);
    }

    public void CambiarDireccion()
    {
        direccion *= -1;
    }
}