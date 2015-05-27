using UnityEngine;
using System.Collections;

public class pickup : MonoBehaviour {
    public float timer = 0.0f;
	void Update () {
        transform.Rotate(new Vector3(15, 30, 45)* Time.deltaTime);
        timer += Time.deltaTime;
        if (timer >= 2.0f)
        {
            Color newcolor = new Color(Random.value, Random.value, Random.value, 1.0f);
            renderer.material.color = newcolor;
            timer = 0;
        }
	}
   
}
