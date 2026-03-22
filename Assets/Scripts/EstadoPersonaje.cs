//Pablo Alejandro Ortiz Montes-A01802689
using UnityEngine;

public class EstadoPersonaje : MonoBehaviour//nombre de este script es EstadoPersonaje el cual lo usara el Hijo de mario_01_7
{

public bool estaEnPiso{get; private set;} =false; //get signifca que otros scripts pueden leerlo, Private Set: dice que solo este script puede editarlo
//es falso al inicio del juego mario no esta en el piso.

    void OnTriggerEnter2D(Collider2D collision)
    {
        estaEnPiso = true;//si el coldier del hijo detecta al otro colider (por el trigger)esto es verdaero
    }


    void OnTriggerExit2D(Collider2D collision)
    {
        estaEnPiso = false;//sino significa que esta en el aire
    }

}