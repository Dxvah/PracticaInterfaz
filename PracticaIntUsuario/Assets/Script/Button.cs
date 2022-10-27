using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    
    public void ScaleUp()
    {
        LeanTween.scale(gameObject, Vector3.one * 1.5f, 0.3f).setEaseSpring();
    }
    public void ScaleDown()
    {
        LeanTween.scale(gameObject, Vector3.one, 0.7f);
    }
}
