//Pablo Alejandro Ortiz Montes-A01802689

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;


public class Menu : MonoBehaviour// El scriopt se llama Menu
{
    private UIDocument menu;//Guarda el documento donde defini los botones y texto
    private Button Jugar; //decimos que existe un Boton que en el codigo se identifca como Jugar 
    private Button Ayuda;
    private Button Creditos;
    private Button CerrarAyuda;
    private Button CerrarCreditos; //hasta aqui lo mismo de mi comnetario anterior

    private VisualElement panelAyuda;//panel donde muestro la ayuda 
    private VisualElement panelCreditos;//panel donde muesto los creditos

    void OnEnable() //cuando menu se ejecuta.
    {
        menu = GetComponent<UIDocument>(); //esto es la interfaz completa.
        var root = menu.rootVisualElement; //aqui puedo biscar todos los botoens o paneles de la interfaz.


        Jugar = root.Q<Button>("Jugar");//tengo que asociar las cariables con el nombre que les di en la UI
        Ayuda = root.Q<Button>("Ayuda");
        Creditos = root.Q<Button>("Creditos");

      
        panelAyuda = root.Q<VisualElement>("PanelAyuda");
        CerrarAyuda = root.Q<Button>("CerrarAyuda");

       //root.Q encuentra elementos
        panelCreditos = root.Q<VisualElement>("PanelCreditos");
        CerrarCreditos = root.Q<Button>("CerrarCreditos");//aqui se repite lo mismo de mi ultimo comentario.

      
        if (panelAyuda != null)
            panelAyuda.style.display = DisplayStyle.None;// Si existe el panel se oculta

        if (panelCreditos != null)
            panelCreditos.style.display = DisplayStyle.None;//pasa lo mismo

     
        if (Jugar != null)
            Jugar.clicked += AbrirJugar;//si deteca que es difernte de un valor nulo (le dieron click) activa el metodo AbrirJugar

        if (Ayuda != null)
            Ayuda.clicked += AbrirAyuda;

        if (Creditos != null)
            Creditos.clicked += AbrirCreditos;

        if (CerrarAyuda != null) //.clicked += conecta botones
            CerrarAyuda.clicked += CerrarVentanaAyuda;

        if (CerrarCreditos != null)
            CerrarCreditos.clicked += CerrarVentanaCreditos;//pasa lo mismo solo que cada uno con sus respectivos metodos.
    }

    private void AbrirJugar()
    {
        SceneManager.LoadScene("SampleScene"); //cambia de escenario al del juego de mario 
    }

    private void AbrirAyuda() //.Flex hace visible un elemento
    {
        if (panelAyuda != null)
            panelAyuda.style.display = DisplayStyle.Flex; //hace visible el pabel de ayuda
    }

    private void CerrarVentanaAyuda()
    {
        if (panelAyuda != null)
            panelAyuda.style.display = DisplayStyle.None;//cierra el panel de ayuda  o no lo hace visisble
    }

    private void AbrirCreditos()
    {
        if (panelCreditos != null)
            panelCreditos.style.display = DisplayStyle.Flex;//hace visible pabel de creditos
    }

    private void CerrarVentanaCreditos()
    {
        if (panelCreditos != null)
            panelCreditos.style.display = DisplayStyle.None;//cierra el panel de creditos  o no lo hace visisble
    }
}