using UnityEngine;

public class DetectorColision : MonoBehaviour
{
    private MoverHongo hongo;

    void Start()
    {
        hongo = GetComponentInParent<MoverHongo>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        hongo.CambiarDireccion();
    }
}