using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainMenuButtons : MonoBehaviour
{
    public Image ObjectwithImage;

    public Sprite spriteToChangeItTo;
    void Start()
    {
        ObjectwithImage.sprite = spriteToChangeItTo;
    }
}



