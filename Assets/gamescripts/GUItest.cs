using UnityEngine;
using System.Collections;

public class guitest : MonoBehaviour {

    void ONGUI()
    {
        Rect r = new Rect(10,10, 150, 100);
        GUI.Box(r, "Loader Menu");
        //if (GUI.Button(new Rect(20, 40, 80, 20), "Level 1"))
        //{
        //    //Application.LoadLevel(1);
        //}
    }
}
