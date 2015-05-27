using UnityEngine;
using System.Collections;

public class running : MonoBehaviour {
    public GameObject CharacterMotor;
    private CharacterMotor personcharacter;

	// Use this for initialization
	void Start () {
        personcharacter = CharacterMotor.GetComponent<CharacterMotor>();
        personcharacter.movement.maxForwardSpeed=150;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
