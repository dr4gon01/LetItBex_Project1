using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour{

	private Vector3 _startPosition;
	ThinkGearController controller;
	private int Attention = 0;

	// Use this for initialization
	void Start () {
		_startPosition = this.transform.position;
		controller = GameObject.Find("ThinkGear").GetComponent<ThinkGearController>();
		controller.UpdateAttentionEvent += OnUpdateAttention;

		
	
	}
	void OnUpdateAttention(int value){
		Attention = value;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//Vector3 pos_Forward = new Vector3 (0,0,-transform.position.z+movSpeed);
		if (Attention > 40)
			transform.position += Vector3.up/10 * Attention * Time.deltaTime;
	}
}
