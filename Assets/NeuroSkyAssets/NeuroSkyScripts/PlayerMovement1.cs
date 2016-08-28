using UnityEngine;
using System.Collections;

public class PlayerMovement1 : MonoBehaviour{

	private Vector3 _startPosition;
	ThinkGearController controller;
	private int Attention;
	public int Meditation;
	private bool noAttention;
	private bool isTouch;
	AudioSource audi;
	public GameObject enemy;




	// Use this for initialization
	void Start () {

		isTouch = false;

		_startPosition = this.transform.position;
		controller = GameObject.Find ("ThinkGear").GetComponent<ThinkGearController> ();
		controller.UpdateAttentionEvent += OnUpdateAttention;
		controller.UpdateMeditationEvent += OnUpdateMeditation;
		noAttention = false;
		audi = GetComponent <AudioSource> ();
	}

	void OnUpdateAttention(int value){
		Attention = value;
	}
	void OnUpdateMeditation(int value){
		Meditation = value;
	}

	
	// Update is called once per frame
	void FixedUpdate () {
		//Vector3 pos_Forward = new Vector3 (0,0,-transform.position.z+movSpeed);
		if (Attention > 40 && audi.isPlaying == false && isTouch == false) {
			transform.position += Vector3.forward * Attention * Time.deltaTime;
			audi.volume = Random.Range (0.8f, 1f);
			audi.pitch = Random.Range (0.8f, 1.2f);
			audi.Play ();
		} 
		if (isTouch == true && Meditation > 50) {
			Destroy (enemy);
		}
			


}
	void OnTriggerEnter(Collider other) {
		//1. on trigger stop the player & start considering the meditation level
		

		if (other.tag == "enemy" ) {
			isTouch = true;
			}
	}
		

}