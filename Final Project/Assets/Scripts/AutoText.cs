using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoText : MonoBehaviour {

    //how long the delay should be
    public float wait = 0.5f;
    //the whole text to be displayed
    public string wholeText;
    //current text position
    private string currentText = "";

	// Use this for initialization
	void Start () {
        StartCoroutine(DisplayText());
		
	}
	
    //to read and display the text
    IEnumerator DisplayText()
    {
        int i = 0;
        while (i < wholeText.Length)//value of i is less than length of text
        {
            currentText = wholeText.Substring(0, i);//start at 0 index, end at value of i
            this.GetComponent<Text>().text = currentText;
            i++;
            yield return new WaitForSeconds(wait);//speed of writing
            
        }

       
        
    }
		
}

