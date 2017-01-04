using UnityEngine;
using System.Collections;

public class SlideMove : MonoBehaviour {

	public UIPlayTween pt;
	int num;

	// Use this for initialization
	void Start () {
		pt = GetComponent<UIPlayTween> ();
		if (PlayerPrefs.GetInt ("LevelNum") >= 0) {
			GlobalVar.currentLevelNum = PlayerPrefs.GetInt ("LevelNum");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//动画播放完成后进入下一个Scene
	public void OnButtonClickFinish () {
		//pt.Play (false);
		//Debug.Log ("Enter other level");
		Application.LoadLevel("ChoiceScene");
	}
}
