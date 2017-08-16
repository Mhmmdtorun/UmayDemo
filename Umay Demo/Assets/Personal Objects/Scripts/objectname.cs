using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class objectname : MonoBehaviour {
	
	RaycastHit hit;
	public Text yazi;
	void Start () {
	
	}
	
	
	void Update () {
		if (Physics.Raycast(Camera.main.transform.position,Camera.main.transform.forward,out hit,3))
	{
			if (hit.transform.gameObject.tag=="Untagged") {
				yazi.text = "";

			}else 
			
			{
				yazi.text = hit.transform.gameObject.tag;
			}
	}
	}
}
