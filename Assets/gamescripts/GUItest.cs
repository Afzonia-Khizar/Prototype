using UnityEngine;
using System.Collections;

public class guitest : MonoBehaviour
{
    private bool b = false;
    private bool x = false;
    private static int copyscore;
    public GUIStyle mystyle;
    public GUIStyle mystyle1;
    public GUIStyle mystyle2;
    public GUIStyle mystyle3;
    private float myslider = 1.0f;
    private Rect myrect = new Rect((Screen.width / 2)-50, (Screen.height / 2)+70, 100, 50);
    private Rect myrect1 = new Rect((Screen.width / 2) - 50, (Screen.height / 2)+150, 320, 80);
    void OnGUI()
    {
       
        if (b == true)
        {
            myrect = GUI.Window(0, myrect, Dialog, "HighScore");
        }
        if (x == true)
        {
            myrect1 = GUI.Window(1, myrect1, Help, "Instructions");
        }
        //mystyle1.fontSize = 40;
        //mystyle1.normal.textColor = Color.magenta;
        //mystyle1.fontStyle = FontStyle.BoldAndItalic;
        Rect r1 = new Rect(120, 70, 400, 500);
        GUI.Box(r1, "Menu", mystyle2);
        mystyle2.fontSize = 20;
        mystyle2.normal.textColor = Color.black;
        mystyle2.fontStyle = FontStyle.BoldAndItalic;
        Rect r = new Rect(Screen.width / 2, 200, 600, 500);
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

        if (GUI.Button(new Rect(100, 130, 100, 40), "PLAY", PLAY))
        {

            Application.LoadLevel("scene1");

            int score = pickingobjects.score = 0;
        }
        HIGHSCORE.fontSize = 20;
        HIGHSCORE.normal.textColor = Color.yellow;
        HIGHSCORE.hover.textColor = Color.white;
        HIGHSCORE.fontStyle = FontStyle.BoldAndItalic;
        if (GUI.Button(new Rect(100, 180, 100, 50), "BEST\nSCORE", HIGHSCORE))
        {
            b = true;

            
            //Application.LoadLevel("scene0");
        }
        INSTRUCTIONS.fontSize = 20;
        INSTRUCTIONS.normal.textColor = Color.blue;
        INSTRUCTIONS.hover.textColor = Color.white;
        INSTRUCTIONS.fontStyle = FontStyle.BoldAndItalic;
        if (GUI.Button(new Rect(100, 240, 100, 50), "HELP", INSTRUCTIONS))
        {
            x = true;
            //Application.LoadLevel("scene0");
        }
        QUIT.fontStyle = FontStyle.BoldAndItalic;
        QUIT.fontSize = 20;
        QUIT.normal.textColor = Color.red;
        QUIT.hover.textColor = Color.white;
        if (GUI.Button(new Rect(100, 300, 100, 40), "QUIT", QUIT))
        {

            if (UnityEditor.EditorUtility.DisplayDialog("Message", "Are you sure you want to Quit? ", "Yes", "No"))
            {
                Application.LoadLevel("scene0");
            }
            else
            {
                Application.Quit();
            }
            Rect rect1 = new Rect(150, 300, 200, 100);
            GUI.Box(rect1, "Are you sure you want to Quit?");
            mystyle3.fontSize = 17;
            mystyle3.normal.textColor = Color.black;
            //Application.Quit();
        }

        myslider = Labelslider(new Rect(100, 400, 80, 50), myslider, 0.0f, "volume");


    }
    float Labelslider(Rect screenrect, float slidervalue, float slidermaxval, string labeltext)
    {
        GUI.Label(screenrect, labeltext);
        screenrect.x += screenrect.width;
        slidervalue = GUI.HorizontalSlider(screenrect, slidervalue, 0.0f, 10.0f);

        AudioListener.volume = 10 * slidervalue;
        return slidervalue;
    }
   
    void Dialog(int Windowid)
    {
        pickingobjects.Awake();
        float y = 20;

        GUI.Label(new Rect(5, y, myrect.width, 20), "HighScore :" + pickingobjects.highscore);

    }

    void Help(int Windowid)
    {

        float y = 20;

        GUI.Label(new Rect(5, y, myrect1.width, 20), "By crossing the hurdles you have to get Best scores");
      
    }

   
}