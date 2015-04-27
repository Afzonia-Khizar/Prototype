using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    public GameObject characterMotor;
    private CharacterMotor playerMotor;

	// Use this for initialization
	void Start () {
        playerMotor = characterMotor.GetComponent<CharacterMotor>();
        playerMotor.jumping.baseHeight = 15;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
