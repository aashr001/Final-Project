using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoText : MonoBehaviour {

    public float wait = 0.5f;
    public string wholeText;
    private string currentText = "";

	// Use this for initialization
	void Start () {
        StartCoroutine(DisplayText());
		
	}
	
    IEnumerator DisplayText()
    {
        int i = 0;
        while (i < wholeText.Length)
        {
            currentText = wholeText.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            i++;
            yield return new WaitForSeconds(wait);
            
        }

       
        
    }
		
}

