
//Pablo Alejandro ortiz Montes-A01802689
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Regresar: MonoBehaviour
{
    private UIDocument Menu2; //recibe tooda la interfazx que hice en la escena de mario
    private Button ButtonRE; //nombre de la varaible 
 

    void OnEnable()
    {
        Menu2 = GetComponent<UIDocument>();
        var root = Menu2.rootVisualElement;

        ButtonRE = root.Q<Button>("ButtonR");//Asi llame al boton en el UI de mario que ya lo realciona con la vfariable de ButtonRe
   
        ButtonRE.clicked += AbrirJugar;
  
    }

    private void AbrirJugar() //En este metodo hace un cambio de escena al menu principal
    {
        SceneManager.LoadScene("Menu");//asi se llama la escena "Menu"
    }

}