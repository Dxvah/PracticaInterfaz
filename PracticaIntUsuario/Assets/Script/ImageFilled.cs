using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageFilled : MonoBehaviour
{

    Image image;

    

    bool attack;


    
    void Start()
    {
        image = GetComponent<Image>();
        image.fillAmount = 0.5f;
    }

    public void Fill(float valor)
    {

        image.fillAmount += valor;

    }
}
