using UnityEngine;
using System.Collections;

public class jumping : MonoBehaviour {
    public GameObject CharacterMotor;
    private CharacterMotor personcharacter;

	// Use this for initialization
	void Start () {
        personcharacter = CharacterMotor.GetComponent<CharacterMotor>();
        personcharacter.jumping.baseHeight = 15;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
