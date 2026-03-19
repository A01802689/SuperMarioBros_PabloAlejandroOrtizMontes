using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Menu : MonoBehaviour
{
    private UIDocument menu;
    private Button Jugar;
    private Button Ayuda;
    private Button Creditos;

    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;

        Jugar = root.Q<Button>("Jugar");
        Ayuda = root.Q<Button>("Ayuda");
        Creditos = root.Q<Button>("Creditos");

        Jugar.clicked += AbrirJugar;
        Ayuda.clicked += AbrirAyuda;
        Creditos.clicked += AbrirCreditos;
    }

    private void AbrirJugar()
    {
        SceneManager.LoadScene("SampleScene");
    }

    private void AbrirAyuda()
    {
        Debug.Log("Abrir menú de ayuda");

    }

    private void AbrirCreditos()
    {
        Debug.Log("Abrir créditos");

    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}