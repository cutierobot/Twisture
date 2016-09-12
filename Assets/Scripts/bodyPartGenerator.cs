using UnityEngine;
using System.Collections;

public class bodyPartGenerator : MonoBehaviour {


//create a array with body part gameobjects
	//use random

	public GameObject[] bodyParts = new GameObject[8];
	private int left = 0;
	private int right = 0;
	private bool pressed = false;
	private PlayerManager player;

	private GameObject leftFoot;
	private GameObject rightFoot;
	private GameObject leftKnee;
	private GameObject rightKnee;
	private GameObject leftElbow;
	private GameObject rightElbow;
	private GameObject leftHand;
	private GameObject rightHand;

	void Start() {
		leftFoot.SetActive(false);
		rightFoot.SetActive(false);
		leftKnee.SetActive(false);
		rightKnee.SetActive(false);
		leftElbow.SetActive(false);
		rightElbow.SetActive(false);
		leftHand.SetActive(false);
		rightHand.SetActive(false);
	}

	// Use this for initialization
	void Awake () {
		leftFoot = GameObject.Find("leftFoot");
		rightFoot = GameObject.Find("rightFoot");
		leftKnee = GameObject.Find("leftKnee");
		rightKnee = GameObject.Find("rightKnee");
		leftElbow = GameObject.Find("leftElbow");
		rightElbow = GameObject.Find("rightElbow");
		leftHand = GameObject.Find("leftHand");
		rightHand = GameObject.Find("rightHand");

		
		bodyParts[0] = leftFoot;
		bodyParts[1] = leftKnee;
		bodyParts[2] = leftElbow;
		bodyParts[3] = leftHand;
		bodyParts[4] = rightFoot;
		bodyParts[5] = rightKnee;		
		bodyParts[6] = rightElbow;
		bodyParts[7] = rightHand;

		GameObject playerManager = GameObject.Find("PlayerManager");
		player = playerManager.GetComponent<PlayerManager>();
	}
	
	void reset() {
		bodyParts[0].SetActive(false);
		bodyParts[1].SetActive(false);
		bodyParts[2].SetActive(false);
		bodyParts[3].SetActive(false);
		bodyParts[4].SetActive(false);
		bodyParts[5].SetActive(false);
		bodyParts[6].SetActive(false);
		bodyParts[7].SetActive(false);
		} 

	void newBodyParts() {
		left = Random.Range(0, 4);
		right = Random.Range(4, 8);
		if(Input.GetKeyDown(KeyCode.B)) {
			bodyParts[left].SetActive(true);
			bodyParts[right].SetActive(true);
			pressed = true;
		} else if(Input.GetKeyDown(KeyCode.N)) {
			reset();
		}
	}

	// Update is called once per frame
	void Update () {
		newBodyParts();
		if(player) {

		}
	}

	bool aPressed(bool pressed) {
		return pressed;
	}

	 
}
