using UnityEngine;
using System.Collections;

public class collidingwall : MonoBehaviour {

	// Use this for initialization
    //void Start () {
	
    //}
	
    //// Update is called once per frame
    //void Update () {
	
    //}
    void OnCollisionEnter(Collision c)
    {
        //if (c.gameObject.name == "First Person Controller")
        //{
            Debug.Log("hit!");
        //}
    }
}
