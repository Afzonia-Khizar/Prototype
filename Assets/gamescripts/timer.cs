//using UnityEngine;
//using System.Collections;

//public class timer : MonoBehaviour
//{


//    public float time;
//    //private float interval;
//    private bool b = false;
//    string message = "Time Elapsed!";

//    // Use this for initialization
//    void Start()
//    {


//    }

//    // Update is called once per frame
//    void Update()
//    {
//        time = time - Time.deltaTime;
//        float minutes = time / 60;
//        float seconds = time % 60;
//        float fraction = (time * 100) % 100;

//        if (time > 0)
//        {
//            guiText.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, fraction);
//            guiText.font.material.color = Color.black;
//        }
//        else
//        {

//            guiText.text = message;
//            guiText.font.material.color = Color.red;
//            guiText.fontSize = 60;

//            //Application.LoadLevel("scene3");



//        }

//        //if (b == true)
//        //{
//        //    Application.LoadLevel("scene3");
//        //}

//    }



//}
