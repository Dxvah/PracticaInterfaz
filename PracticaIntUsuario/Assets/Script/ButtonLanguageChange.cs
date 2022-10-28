using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class OpcionIdioma : MonoBehaviour
{
    int idiomaActual;

    void SelectCurrentLang()
    {

        UnityEngine.Localization.Locale searcher = LocalizationSettings.AvailableLocales.Locales[idiomaActual];

        while (searcher != LocalizationSettings.SelectedLocale && idiomaActual < LocalizationSettings.AvailableLocales.Locales.Count)
        {

            idiomaActual++;
            searcher = LocalizationSettings.AvailableLocales.Locales[idiomaActual];



        }


    }
    private void Awake()
    {
        //Array con los diferentes idiomas que tiene el juego configurado
        //LocalizationSettings.AvailableLocales.Locales
        //Idiomas = {Español, Inglés, Francés, Italiano, Aleman,...}

        //El idioma que se está utilizando
        //LocalizationSettings.SelectedLocale

        int idiomaAleatorio = Random.Range(0, 5); //Genero número aleatorio

        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[idiomaAleatorio];

        //Total de idiomas disponibles
        int langAvailables = LocalizationSettings.AvailableLocales.Locales.Count;
    }

    //Funcion Next Language

    /*
     
        arrayNumeros = {5 10 15 0 2 8}
        

        arrayNumeros[4] => 2
        arrayNumeros[1] => 10
      */


    public void NextLanguage()
    {
       

        idiomaActual++;
        if (idiomaActual >= LocalizationSettings.AvailableLocales.Locales.Count)
        {

            idiomaActual = 0;
           

        }
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[idiomaActual];

    }


    public void PreviousLanguage()
    {

        idiomaActual--;

    }
}