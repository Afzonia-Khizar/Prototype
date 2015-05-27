using UnityEngine;
using System.Collections;

public class pickingobjects : MonoBehaviour {
  
    private int newjump = 20;
    private int oldjump = 5;
    string message = "Time Elapsed!";
    private int score = 0;
    public GUIText guiscore ;
    public GUIText guitimer;
  
    public float time;
    private static bool b = false;
  public GameObject CharacterMotor;
  public CharacterMotor personcharacter;

  void Start()
  {
      guiscore.text = "Score: 0";
      guiscore.font.material.color = Color.black;
      personcharacter = CharacterMotor.GetComponent<CharacterMotor>();
  }

  void Update()
  {
      time = time - Time.deltaTime;
      float minutes = time / 60; float minutes1 = 0;
      float seconds = time % 60; float seconds1 = 0;
      float fraction = (time * 100) % 100; float fraction1 = 0;
      if (time > 0)
      {
          guitimer.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, fraction);
          guitimer.font.material.color = Color.black;
          if (b == true)
          {
              time = 0;
              guitimer.text = string.Format("{0:00}:{1:00}:{2:00}", minutes1, seconds1, fraction1);
            
             
          }
      }
     
      else
      {
          if (b == false)
          {
              //Object.Destroy(other.gameObject, 2.0f);
              guitimer.text = message;
              guitimer.font.material.color = Color.red;
              guitimer.fontSize = 60;
          }

      }
   
    
  }

  void OnTriggerEnter(Collider other)
  {
      //personcharacter = CharacterMotor.GetComponent<CharacterMotor>();

      if (time > 0)
      {

          if (other.gameObject.collider.isTrigger)
          {


              Destroy(other.gameObject);
              score += 10;
              guiscore.text = "Score: " + score;
              b = true;

              personcharacter.jumping.baseHeight = newjump;

          }
      }
      else
          {
              Object.Destroy(gameObject, 1.0f);
              b = false;

          }
  }
          //if (other.gameObject.collider.name == "wall")
          //{
          //    personcharacter.jumping.baseHeight = oldjump;
          //}

  }

           
           
       

      
       

        
  
