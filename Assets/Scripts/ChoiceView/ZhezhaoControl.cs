using UnityEngine;
using System.Collections;

public class ZhezhaoControl : MonoBehaviour {

	//当前的角色索引
	public int index;

	//点击后需要播放声音
	AudioSource audio;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PlaySound () {
		audio.Play ();
	}
}
