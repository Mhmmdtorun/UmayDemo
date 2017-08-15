using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class objectname : MonoBehaviour {
	
	RaycastHit hit;
	public Text yazi;
	void Start () {
	
	}
	
	
	void Update () {
		if (Physics.Raycast(Camera.main.transform.position,Camera.main.transform.forward,out hit,2))
	{
			if (hit.transform.gameObject.tag=="vida") {
				Debug.Log (hit.transform.gameObject.tag);
				yazi.text=hit.transform.gameObject.tag;
			}
	}
	}
}
