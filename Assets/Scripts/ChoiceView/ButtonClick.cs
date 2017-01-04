using UnityEngine;
using System.Collections;

public class ButtonClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnQianghuaClick () {
		Debug.Log ("qianghua!!!");
		PlayerPrefs.SetInt ("ModelIndex",GlobalVar.modelIndex);
		Debug.Log (PlayerPrefs.GetInt("ModelIndex"));
	}

	public void OnExitClick () {
		Debug.Log ("Exit!!!");
		Debug.Log (PlayerPrefs.GetInt("ModelIndex"));
	}

	public void OnStartClick () {
		Debug.Log ("Start!!!");
		PlayerPrefs.SetInt ("ModelIndex",GlobalVar.modelIndex);
		Debug.Log (PlayerPrefs.GetInt("ModelIndex"));
	}
}
