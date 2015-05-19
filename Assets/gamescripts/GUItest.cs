using UnityEngine;
using System.Collections;

public class guitest : MonoBehaviour {
    public GUIStyle mystyle;
    public GUIStyle mystyle1;
    private float myslider = 1.0f;
    

    void OnGUI()
    {
        //mystyle1.fontSize = 40;
        //mystyle1.normal.textColor = Color.magenta;
        //mystyle1.fontStyle = FontStyle.BoldAndItalic;
        Rect r1 = new Rect(80, 60, 400, 500);
        GUI.Box(r1, "Menu");
        Rect r = new Rect(800, 150, 600, 500);
        GUI.Label(r, "Panda Thriller", mystyle);

        //GUI.contentColor = Color.green;
        mystyle.fontSize = 80;
        mystyle.normal.textColor = Color.cyan;
        mystyle.fontStyle = FontStyle.BoldAndItalic;


        GUIStyle PLAY = new GUIStyle(GUI.skin.button);
        GUIStyle HIGHSCORE = new GUIStyle(GUI.skin.button);
        GUIStyle INSTRUCTIONS = new GUIStyle(GUI.skin.button);
        GUIStyle QUIT = new GUIStyle(GUI.skin.button);
        PLAY.fontStyle = FontStyle.BoldAndItalic;
        PLAY.fontSize = 20;
        PLAY.normal.textColor = Color.green;
        PLAY.hover.textColor = Color.white;

        if (GUI.Button(new Rect(240, 130, 80, 40), "PLAY", PLAY))
        {
            Application.LoadLevel("scene1");
        }
        HIGHSCORE.fontSize = 20;
        HIGHSCORE.normal.textColor = Color.yellow;
        HIGHSCORE.hover.textColor = Color.white;
        HIGHSCORE.fontStyle = FontStyle.BoldAndItalic;
        if (GUI.Button(new Rect(160, 210, 100, 50), "HIGH\nSCORE", HIGHSCORE))
        {
            //Application.LoadLevel("scene0");
        }
        INSTRUCTIONS.fontSize = 20;
        INSTRUCTIONS.normal.textColor = Color.blue;
        INSTRUCTIONS.hover.textColor = Color.white;
        INSTRUCTIONS.fontStyle = FontStyle.BoldAndItalic;
        if (GUI.Button(new Rect(290, 210, 100, 50), "HELP", INSTRUCTIONS))
        {
            //Application.LoadLevel("scene0");
        }
        QUIT.fontStyle = FontStyle.BoldAndItalic;
        QUIT.fontSize = 20;
        QUIT.normal.textColor = Color.red;
        QUIT.hover.textColor = Color.white;
        if (GUI.Button(new Rect(240, 300, 80, 40), "QUIT", QUIT))
        {

            Application.Quit();
        }
        myslider = Labelslider(new Rect(240, 400, 80, 50), myslider, 0.0f, "volume");

    }
    float Labelslider(Rect screenrect, float slidervalue, float slidermaxval, string labeltext)
    {
        GUI.Label(screenrect, labeltext);
        screenrect.x += screenrect.width;
        slidervalue = GUI.HorizontalSlider(screenrect, slidervalue, 5.0f, slidermaxval);
        return slidervalue;
    }
    
}
