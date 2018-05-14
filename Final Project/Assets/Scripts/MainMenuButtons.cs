using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenuButtons : MonoBehaviour
{
    public Button button;
    public Sprite normalImage;
    public Sprite highlightedImage;
    public bool mouseOver = false;
     public string nextLevel;
    public bool quit = false;

    
  /*  void Start()
    {
        button = GetComponent<Button>();

    }

    public void OnMouseEnter()
    {
        mouseOver = true;
        button.image.overrideSprite = highlightedImage; 
    }

    public void OnMouseExit()
    {
        mouseOver = false;
        button.image.overrideSprite = normalImage;
    } */

   public void LoadLevel()
    {
        SceneManager.LoadScene(nextLevel);
   
    }
}



