using UnityEngine;

public class Gui : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
  void onGui()
    {
        if (GUI.Button(Rect (10 ,10, 150, 100), "Button"))
        {
            print("clicked");
        }
    }

  private Rect Rect(int p, int p_2, int p_3, int p_4)
  {
      throw new System.NotImplementedException();
  }

    
}
