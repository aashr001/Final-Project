using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButtons : MonoBehaviour {

    public string nextLevel;
    public Texture2D originalTexture;
    public Texture2D highlightedTexture;
    //public AudioClip clickSound;

    private new GUITexture guiTexture;

    void Start()
    {
        guiTexture = GetComponent<GUITexture>();
    }

    void OnMouseEnter()
    {
        guiTexture.texture = highlightedTexture;
    }

    void OnMouseExit()
    {
        guiTexture.texture = originalTexture;
    }


}
	

