using UnityEngine;
using System.Collections;

public class ChangeAlpha : MonoBehaviour {

	//所有遮罩
	public SpriteRenderer[] sprs;

	//起始颜色，透明度是70
	Color startColor = new Color (0,0,0,0.27f);
	//点击后的颜色，完全透明
	Color endColor = new Color(0,0,0,0);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Android平台，主要检测Touch事件
		if (Application.platform == RuntimePlatform.Android) {

		} 
		//mac平台，主要检测鼠标事件
		if (Application.platform == RuntimePlatform.OSXEditor && Input.GetMouseButtonDown (0)) {
			Vector3 pos = Camera.main.ScreenToWorldPoint (Input.mousePosition); //获取鼠标点击坐标并转为世界坐标
			RaycastHit2D hit = Physics2D.Raycast (pos,-Vector3.up);//碰撞点
			if (hit.collider != null && hit.collider.gameObject.tag.Equals("zhezhao")) {
				//Debug.Log ("Touched!!!!!");
				ResetAlpha (); //每次点击前先把之前点击过的给还原
				GameObject zhezhao = hit.collider.gameObject as GameObject; //获取点击的物体
				zhezhao.GetComponent<SpriteRenderer> ().color = endColor; //设置物体的颜色为全透明
				zhezhao.GetComponent<ZhezhaoControl> ().PlaySound (); //获取物体的脚本并且开始播放声音
				GlobalVar.modelIndex = zhezhao.GetComponent<ZhezhaoControl> ().index;	//获取物体的脚本然后把物体索引赋予全局索引。
			}
		}

	}

	void ResetAlpha () {
		foreach (var spr in sprs) {
			spr.color = startColor;
		}
		GlobalVar.modelIndex = 0;
	}
}
