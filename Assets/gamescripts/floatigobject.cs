using UnityEngine;
using System.Collections;

public class floatigobject : MonoBehaviour {
    public float movementspeed=1;
    //public float upwardforce = 12.72f;
    //private bool isinwater = false;
    //public GameObject water;
    //public int force;
	// Use this for initialization
	void Start () {
       
    
	}
    void Update()
    {
        transform.Translate(Vector3.up * movementspeed * Time.deltaTime);

        transform.Translate(Vector3.down * movementspeed * Time.deltaTime);
    }
    //void OnTriggerEnter()
    //{
    //    isinwater = true;
    //    rigidbody.drag =5f;
    //}


    //void OnTriggerExit()
    //{
    //    isinwater = false;
    //    rigidbody.drag = 0.05f;
    //}
    
	// Update is called once per frame
    //void FixedUpdate () {
    //    //if (transform.position.y > water.transform.position.y)
    //    //{
    //    //    rigidbody.AddForce(transform.up * force * 10);
    //    //}
    //    //if (transform.position.y <water.transform.position.y)
    //    //{
    //    //    rigidbody.AddForce(transform.up * force * 10);
    //    //}
    //    if (isinwater)
    //    {
    //        Vector3 force = transform.up * upwardforce;
    //        this.rigidbody.AddRelativeForce(force, ForceMode.Acceleration);

    //    }
    //}
}
