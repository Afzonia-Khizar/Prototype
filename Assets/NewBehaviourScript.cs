using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    public Texture playnormal;
    public Texture playhover;
	// Use this for initialization
    void OnMouseEnter()
    {
        guiTexture.texture = playhover;
        //Application.LoadLevel("scene1");
    }

    // Update is called once per frame
    void OnMouseExit()
    {
        guiTexture.texture = playnormal;

    }
    void OnMouseDown()
    {
        Application.LoadLevel("scene1");
    }
}
