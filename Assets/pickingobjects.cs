using UnityEngine;
using System.Collections;

public class pickingobjects : MonoBehaviour {

	// Use this for initialization
    void OnTriggerEvent(Collider other)
    {
        if (other.gameObject.CompareTag("pickup"))
        {
            other.gameObject.SetActiveRecursively(false);
        }
        //Destroy(other.gameObject);
    }
}
