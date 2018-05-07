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
        for (int i =0; i <wholeText.Length; i++)
        {
            currentText = wholeText.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(wait);
        }
    }
		
}

