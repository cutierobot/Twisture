 using UnityEngine;
using System.Collections;

public class DotManager : MonoBehaviour {


	private DotScript dotScript;

	//List of all dot GameObjects
	private GameObject dotOne;
	private GameObject dotTwo;
	private GameObject dotThree;
	private GameObject dotFour;
	private GameObject dotFive;
	private GameObject dotSix;
	private GameObject dotSeven;
	private GameObject dotEight;
	private GameObject dotNine;
	private GameObject dotTen;
	private GameObject dotEleven;
	private GameObject dotTwelve;
	private GameObject dotThirteen;
	private GameObject dotFourteen;
	private GameObject dotFifteen;
	private GameObject dotSixteen;

	private GameObject dotManager;
	private DotManager dotManagerScript;

	private string mouse1;
	private string mouse2;
	private int count = 1;

	//floats used for creating Vector3.
	/*private float x;
	private float y;
	private float z;
	*/

	private int clickCount;

	void Awake() {
		//initialise dot GameObjects.
		dotOne = GameObject.FindGameObjectWithTag("dotOne");
		dotTwo = GameObject.FindGameObjectWithTag("dotTwo");
		dotThree = GameObject.FindGameObjectWithTag("dotThree");
		dotFour = GameObject.FindGameObjectWithTag("dotFour");
		dotFive = GameObject.FindGameObjectWithTag("dotFive");
		dotSix = GameObject.FindGameObjectWithTag("dotSix");
		dotSeven = GameObject.FindGameObjectWithTag("dotSeven");
		dotEight = GameObject.FindGameObjectWithTag("dotEight");
		dotNine = GameObject.FindGameObjectWithTag("dotNine");
		dotTen = GameObject.FindGameObjectWithTag("dotTen");
		dotEleven = GameObject.FindGameObjectWithTag("dotEleven");
		dotTwelve = GameObject.FindGameObjectWithTag("dotTwelve");
		dotThirteen = GameObject.FindGameObjectWithTag("dotThirteen");
		dotFourteen = GameObject.FindGameObjectWithTag("dotFourteen");
		dotFifteen = GameObject.FindGameObjectWithTag("dotFifteen");
		dotSixteen = GameObject.FindGameObjectWithTag("dotSixteen");

		//dotManager is the GameObject that contains the DotScript.cs file
		dotScript = dotOne.GetComponent<DotScript>();
		
		//Debug.Log("dotOne" + mouse1);
	}

	bool SameDot() {
		if (mouse1 == mouse2) {
			return true;
		}
		return false;
	}

	/*
		Checks for errors and mistake made by player or system. Returns true if
		mistake and false otherwise.
	*/
	bool DotManagerCheck() {
		if (mouse1 == string.Empty || mouse2 == string.Empty || SameDot()) {
			//Debug.Log("dotCheck");
			return true;
		}
		//Debug.Log("return false");
		return false;
	}

	/*
		Creates and returns a Vector3 for mouse1 to be used by the 
		LineManager.cs script.
	*/
	public string Mouse1() {
		//Clicked(mouse1);
		
		return mouse1;
	} 

	/*
		Creates and returns a Vector3 for mouse2 to be used by the 
		LineManager.cs script.
	*/
	public string Mouse2() {
		//Clicked(mouse2);
		
		return mouse2;
	}

	public int getCount() {
		return dotScript.getCount();
	}
	
	// Update is called once per frame		
	void Update() { 
		clickCount = dotScript.getCount();
		if(clickCount == 1) {
			mouse1 = dotScript.mouse1();
		} else {
			mouse2 = dotScript.mouse2();
		}
		//mouse2 = dotScript.mouse2();
		if (!DotManagerCheck()) {
			//Debug.Log("doCheck");
			if (count == 1) {
				Mouse1();
				//Debug.Log("mouse1 " + Mouse1());
				count = 2;
			} else {
				Mouse2();
				//Debug.Log("mouse2 " + Mouse2());
				count = 1;
			}
		}
	}
}

	/*
		Compares the given string mouse collider name with GameObjects. Used for
		assigning vector coordinates to Mouse1() and Mouse2().

		mouse: string variable that contains the name of the clicked GameObject.
	*/
	/*private void Clicked(string mouse) {
		 switch(mouse) {
			case "dotOne" :
				x = dotOne.transform.position.x;
				y = dotOne.transform.position.y;
				z = dotOne.transform.position.z;
				break;
			case "dotTwo" : 
				x = dotTwo.transform.position.x;
				y = dotTwo.transform.position.y;
				z = dotTwo.transform.position.z;
				break;
			case "dotThree" : 
				x = dotThree.transform.position.x;
				y = dotThree.transform.position.y;
				z = dotThree.transform.position.z;
				break;
			case "dotFour" : 
				x = dotFour.transform.position.x;
				y = dotFour.transform.position.y;
				z = dotFour.transform.position.z;
				break;
			case "dotFive" : 
				x = dotFive.transform.position.x;
				y = dotFive.transform.position.y;
				z = dotFive.transform.position.z;
				break;
			case "dotSix" : 
				x = dotSix.transform.position.x;
				y = dotSix.transform.position.y;
				z = dotSix.transform.position.z;
				break;
			case "dotSeven" : 
				x = dotSeven.transform.position.x;
				y = dotSeven.transform.position.y;
				z = dotSeven.transform.position.z;
				break;
			case "dotEight" : 
				x = dotEight.transform.position.x;
				y = dotEight.transform.position.y;
				z = dotEight.transform.position.z;
				break;
			case "dotNine" : 
				x = dotNine.transform.position.x;
				y = dotNine.transform.position.y;
				z = dotNine.transform.position.z;
				break;
			case "dotTen" : 
				x = dotTen.transform.position.x;
				y = dotTen.transform.position.y;
				z = dotTen.transform.position.z;
				break;
			case "dotEleven" : 
				x = dotEleven.transform.position.x;
				y = dotEleven.transform.position.y;
				z = dotEleven.transform.position.z;
				break;
			case "dotTwelve" : 
				x = dotTwelve.transform.position.x;
				y = dotTwelve.transform.position.y;
				z = dotTwelve.transform.position.z;
				break;
			case "dotThirteen" : 
				x = dotThirteen.transform.position.x;
				y = dotThirteen.transform.position.y;
				z = dotThirteen.transform.position.z;
				break;
			case "dotFourteen" : 
				x = dotFourteen.transform.position.x;
				y = dotFourteen.transform.position.y;
				z = dotFourteen.transform.position.z;
				break;
			case "dotFifteen" : 
				x = dotFifteen.transform.position.x;
				y = dotFifteen.transform.position.y;
				z = dotFifteen.transform.position.z;
				break;	
			case "dotSixteen" : 
				x = dotSixteen.transform.position.x;
				y = dotSixteen.transform.position.y;
				z = dotSixteen.transform.position.z;
				break;
		} 
	}*/
