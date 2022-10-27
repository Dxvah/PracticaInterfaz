using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroAnimation : MonoBehaviour
{
    [SerializeField]
    GameObject logo;


    [SerializeField]
    GameObject interfaz;

    void Start()
    {
        //Oculto mi logo de manera inmediata, en cero segundos
        LeanTween.moveLocalY(logo, -561f, 0.0f);
        //Hago aparecer el logo desde su posición inicial hacia la posicion 52 del eje Y
        LeanTween.moveLocalY(logo, 52f, 7f).setEaseInOutQuint().setOnComplete(Latido);
        //LeanTween.moveLocal(logo, new Vecto3(xf, yf, zf), tiempo f) - para moverlo en diversos ejes al mismo tiempo 


    }


    void Latido()
    {


        LeanTween.scale(logo, Vector3.one, 1f).setEaseOutBack().setOnComplete(() =>
       {

           LeanTween.alphaCanvas(gameObject.GetComponent<CanvasGroup>(), 0.0f, 0.75f).setOnComplete(Desactivar);

       });

        void Desactivar()
        {
            interfaz.SetActive(true);
            //Activar el menu principal

        }

    }

    void OnEnable()
    {
        
        LeanTween.moveLocalX(interfaz, -622f, 10f).setEaseInExpo().setOnComplete(Menu);

    }


    void Menu()
    {

        gameObject.SetActive(true);
    }
}
