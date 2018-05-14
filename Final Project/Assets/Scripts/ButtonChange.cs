using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;



public class ButtonChange : MonoBehaviour
{
    public Sprite originalImage;
    public Sprite highlightedImage;

    private void Start()
    {
        originalImage = GetComponent<Sprite>();
    }
    void OnMouseEnter()
    {
        originalImage = highlightedImage;

    }

    void OnMouseExit()
    {
        highlightedImage = originalImage;
    }
}



