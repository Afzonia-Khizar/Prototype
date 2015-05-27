using UnityEngine;
using System.Collections;


public class Gameover : MonoBehaviour {
    private bool label = true;
    GUIText text;
	// Use this for initialization
 
	void Start () {
        
        text = GetComponent<GUIText>();
        StartCoroutine(Blinktext());
	}
   public IEnumerator Blinktext()
  
    {
        while (true)
        {
            text.text = "";
            yield return new WaitForSeconds(.5f);
            text.text = "Game Over!";
            yield return new WaitForSeconds(.5f);
            text.font.material.color = Color.red;
        }
    }
	// Update is called once per frame
	
	}

