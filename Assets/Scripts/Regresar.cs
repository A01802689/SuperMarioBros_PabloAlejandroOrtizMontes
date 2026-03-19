using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Regresar: MonoBehaviour
{
    private UIDocument Menu2;
    private Button ButtonRE;
 

    void OnEnable()
    {
        Menu2 = GetComponent<UIDocument>();
        var root = Menu2.rootVisualElement;

        ButtonRE = root.Q<Button>("ButtonR");
   
        ButtonRE.clicked += AbrirJugar;
  
    }

    private void AbrirJugar()
    {
        SceneManager.LoadScene("Menu");
    }


    void Start()
    {
        
    }

    void Update()
    {
        
    }
}