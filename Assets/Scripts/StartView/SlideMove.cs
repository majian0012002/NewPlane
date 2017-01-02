using UnityEngine;
using System.Collections;

public class SlideMove : MonoBehaviour {

	public UIPlayTween pt;
	int num;

	// Use this for initialization
	void Start () {
		pt = GetComponent<UIPlayTween> ();
		num = PlayerPrefs.GetInt ("LeveNum");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnButtonClick () {
		Debug.Log ("Click");
	}
}
