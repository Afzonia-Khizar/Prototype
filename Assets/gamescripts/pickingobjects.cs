using UnityEngine;
using System.Collections;

public class pickingobjects : MonoBehaviour
{
  public Animation doorclip;
   GameObject door;
    private int newjump = 15;
    private int oldjump = 5;
    string message = "Time Elapsed!";
    public static int score = 0;
    public GUIText guiscore;
    public GUIText guitimer;
    //public float jumptime;
    private float timer = 5f;
    public float time;
    private static bool b = false;
    public static bool iswin = false;
    public static bool islose = false;
    public GameObject CharacterMotor;
    public CharacterMotor personcharacter;
    GameObject player;
   public static int highscore;
   //public static int copyscore;
    public GUIText guihighscore;
   private static bool fire=true;
  
    void Start()
    {
        guiscore.text = "Score: 0";
        guiscore.font.material.color = Color.red;
        player = GameObject.Find("Player");
        personcharacter = CharacterMotor.GetComponent<CharacterMotor>();
        Awake();
    }

    void Update()
    {
        time = time - Time.deltaTime;
        float minutes = time / 60;
        float seconds = time % 60;
        float fraction = (time * 100) % 100;
        if (time > 0)
        {
            guitimer.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, fraction);
            guitimer.font.material.color = Color.black;

        }


        else 
        {
            if (fire == true)
            {

                guitimer.text = message;
                guitimer.font.material.color = Color.red;
                guitimer.fontSize = 60;
            }

            Application.LoadLevel("scene3");

        }


        guihighscore.text = "HighScore : " + PlayerPrefs.GetInt("HighScore");
        guihighscore.font.material.color = Color.red;

    }

    void OnTriggerEnter(Collider other)
    {
        


        if (time > 0)
        {

            if (other.gameObject.isStatic && other.gameObject.collider.isTrigger)
            {
                score += 90;
                b = true;
            }
            else
            {
                b = false;
            }
           

            if ((other.gameObject.rigidbody && other.gameObject.collider.isTrigger) || (other.gameObject.rigidbody && 
                other.gameObject.collider.isTrigger && other.gameObject.isStatic))
            {
                
                iswin = true;
                time = 0;
                fire = false;

            }
            if (other.constantForce && other.gameObject.collider.isTrigger)
            {
               
                islose = true;
                time = 0;
                fire = false;
            }
            if (other.gameObject.collider.isTrigger)
            {


                Destroy(other.gameObject);
                score += 10;
                guiscore.text = "Score: " + score;
             

                personcharacter.jumping.baseHeight = newjump;

            }
        }
        if (b == true)
        {
            doorclip.Play("dooropen");
        }

        guihighscore.text = "HighScore : " + highscore ;
        Awake();
       

    }

   public static void Awake()
        
    {
        highscore = PlayerPrefs.GetInt("HighScore"); 
        
        if (score >highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("HighScore", highscore);
            PlayerPrefs.Save();
           
           
           
        }
        //copyscore = highscore;
    }
    
}

           
           
       

      
       

        
  
