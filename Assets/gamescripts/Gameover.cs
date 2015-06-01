using UnityEngine;
using System.Collections;


public class Gameover : MonoBehaviour {
    private bool label = true;
    public GUIStyle mystyle;
    public GUIStyle mystyle1;
    GUIText text;
    public GUIText guiscore;
    private  static int score;

	void Start () {
        guiscore.text = "Score: 0";
     
        text = GetComponent<GUIText>();
        StartCoroutine(Blinktext());
	}
   
    void OnGUI()
    {
        
        score = pickingobjects.score;
        guiscore.text = "Total Score: " + score;
        //guiscore.font.material.color = Color.black;
        Rect r = new Rect((Screen.width/3)+43, (Screen.height/4)-40, 600, 500);
        GUI.Label(r, "Game Over", mystyle);
        mystyle.fontSize = 50;
        mystyle.normal.textColor = Color.black;
        mystyle.fontStyle = FontStyle.BoldAndItalic;

        Rect r1 = new Rect((Screen.width/3)+70, (Screen.width/3)-80, 200, 100);
        GUI.Box(r1, "Do you want to play again?",mystyle1);
        mystyle1.fontSize = 17;
        mystyle1.normal.textColor = Color.black;
        
        GUIStyle YES = new GUIStyle(GUI.skin.button);
        YES.fontStyle = FontStyle.BoldAndItalic;
        YES.fontSize = 20;
        YES.normal.textColor = Color.green;
        YES.hover.textColor = Color.white;
        if (GUI.Button(new Rect((Screen.width/3)+80, (Screen.height/2)+120, 70, 30), "YES",YES))
        {
            Application.LoadLevel("scene1");
          int myscore = pickingobjects.score = 0;
        }
        GUIStyle NO = new GUIStyle(GUI.skin.button);
        NO.fontStyle = FontStyle.BoldAndItalic;
        NO.fontSize = 20;
        NO.normal.textColor = Color.red;
        NO.hover.textColor = Color.white;
        if (GUI.Button(new Rect((Screen.width / 3) + 170, (Screen.height / 2) + 120, 70, 30), "NO", NO))
        {
            Application.LoadLevel("scene0");
        }
       


    }
   public IEnumerator Blinktext()
  
    {
        if (pickingobjects.islose == true)
        {
            while (true)
            {
                text.text = "";
                yield return new WaitForSeconds(.3f);

                text.text = "You win the game! :)";
                yield return new WaitForSeconds(.3f);
                text.font.material.color = Color.red;
            }
        }
           if (pickingobjects.iswin == false)
        {
            while (true)
            {
                text.text = "";
                yield return new WaitForSeconds(.3f);

                text.text = "Time Elapsed!";
                yield return new WaitForSeconds(.3f);
                text.font.material.color = Color.red;
            }
        }
        else
        {
            while (true)
            {
                text.text = "";
                yield return new WaitForSeconds(.3f);

                text.text = "You lose the game! :(";
                yield return new WaitForSeconds(.3f);
                text.font.material.color = Color.red;
            }
        }
        
    }
  
	// Update is called once per frame
   
	}

