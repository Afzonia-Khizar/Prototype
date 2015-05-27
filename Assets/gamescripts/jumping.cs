using UnityEngine;
using System.Collections;

public class jumping : MonoBehaviour {
    public GameObject CharacterMotor;
    public CharacterMotor personcharacter;

    
	// Use this for initialization
	void Start () {
        personcharacter = CharacterMotor.GetComponent<CharacterMotor>();
        personcharacter.jumping.baseHeight = 5;
        
       
	
	}
	
  
	
	}

