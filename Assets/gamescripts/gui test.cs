using UnityEngine;
using System.Collections;

public class guitest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void ongui()
    {
        if (GUI.Button(new Rect (10,10,100,150), "Button"))
        {
            print("clicked");
        }
    }

   
}
