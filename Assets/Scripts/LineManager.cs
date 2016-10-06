
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
//using System;

public struct Players {
	public int playerID;
	public bool playerTurn;
	public int score;
};

public class LineManager : MonoBehaviour {

	//private GameObject lineName;
	private GameObject greenHOne;
	private GameObject greenHTwo;
	private GameObject greenHThree;
	private GameObject greenHFour;
	private GameObject greenHFive;
	private GameObject greenHSix;
	private GameObject greenHSeven;
	private GameObject greenHEight;
	private GameObject greenHNine;
	private GameObject greenHTen;
	private GameObject greenHEleven;
	private GameObject greenHTwelve;
	private GameObject greenVOne;
	private GameObject greenVTwo;
	private GameObject greenVThree;
	private GameObject greenVFour;
	private GameObject greenVFive;
	private GameObject greenVSix;
	private GameObject greenVSeven;
	private GameObject greenVEight;
	private GameObject greenVNine;
	private GameObject greenVTen;
	private GameObject greenVEleven;
	private GameObject greenVTwelve;
	private GameObject blueVOne;
	private GameObject blueVTwo;
	private GameObject blueVThree;
	private GameObject blueVFour;
	private GameObject blueVFive;
	private GameObject blueVSix;
	private GameObject blueVSeven;
	private GameObject blueVEight;
	private GameObject blueVNine;
	private GameObject blueVTen;
	private GameObject blueVEleven;
	private GameObject blueVTwelve;
	private GameObject blueHOne;
	private GameObject blueHTwo;
	private GameObject blueHThree;
	private GameObject blueHFour;
	private GameObject blueHFive;
	private GameObject blueHSix;
	private GameObject blueHSeven;
	private GameObject blueHEight;
	private GameObject blueHNine;
	private GameObject blueHTen;
	private GameObject blueHEleven;
	private GameObject blueHTwelve;
	Players playerOne;
	Players playerTwo;

	//public bodyPartGenerator bodyParts;
	private BodyPartsManager bodyPartsScript;
	private GameObject bodyPartsManager;



	//popups
	private GameObject playerOnePopUp;
	private GameObject playerTwoPopUp;
	private GameObject playerOneWins;
	private GameObject playerTwoWins;
	private GameObject difChoose;
	public Text changePlayerText;

	public Text playerOneCount;
	public Text playerTwoCount;
	private bool[,] horizontalArray;
	private bool[,] verticalArray;
	private bool[] boxCheckArray;


	void Awake() {
		//LineName = GameObject.Find("lineName");
		greenHOne = GameObject.Find("greenHOne");
		greenHTwo = GameObject.Find("greenHTwo");
		greenHThree = GameObject.Find("greenHThree");
		greenHFour = GameObject.Find("greenHFour");
		greenHFive = GameObject.Find("greenHFive");
		greenHSix = GameObject.Find("greenHSix");
		greenHSeven = GameObject.Find("greenHSeven");
		greenHEight = GameObject.Find("greenHEight");
		greenHNine = GameObject.Find("greenHNine");
		greenHTen = GameObject.Find("greenHTen");
		greenHEleven = GameObject.Find("greenHEleven");
		greenHTwelve = GameObject.Find("greenHTwelve");
		greenVOne = GameObject.Find("greenVOne");
		greenVTwo = GameObject.Find("greenVTwo");
		greenVThree = GameObject.Find("greenVThree");
		greenVFour = GameObject.Find("greenVFour");
		greenVFive = GameObject.Find("greenVFive");
		greenVSix = GameObject.Find("greenVSix");
		greenVSeven = GameObject.Find("greenVSeven");
		greenVEight = GameObject.Find("greenVEight");
		greenVNine = GameObject.Find("greenVNine");
		greenVTen = GameObject.Find("greenVTen");
		greenVEleven = GameObject.Find("greenVEleven");
		greenVTwelve = GameObject.Find("greenVTwelve");
		blueVOne = GameObject.Find("blueVOne");
		blueVTwo = GameObject.Find("blueVTwo");
		blueVThree = GameObject.Find("blueVThree");
		blueVFour = GameObject.Find("blueVFour");
		blueVFive = GameObject.Find("blueVFive");
		blueVSix = GameObject.Find("blueVSix");
		blueVSeven = GameObject.Find("blueVSeven");
		blueVEight = GameObject.Find("blueVEight");
		blueVNine = GameObject.Find("blueVNine");
		blueVTen = GameObject.Find("blueVTen");
		blueVEleven = GameObject.Find("blueVEleven");
		blueVTwelve = GameObject.Find("blueVTwelve");
		blueHOne = GameObject.Find("blueHOne");
		blueHTwo = GameObject.Find("blueHTwo");
		blueHThree = GameObject.Find("blueHThree");
		blueHFour = GameObject.Find("blueHFour");
		blueHFive = GameObject.Find("blueHFive");
		blueHSix = GameObject.Find("blueHSix");
		blueHSeven = GameObject.Find("blueHSeven");
		blueHEight = GameObject.Find("blueHEight");
		blueHNine = GameObject.Find("blueHNine");
		blueHTen = GameObject.Find("blueHTen");
		blueHEleven = GameObject.Find("blueHEleven");
		blueHTwelve = GameObject.Find("blueHTwelve");

		//popups
		playerOnePopUp = GameObject.Find("playerOnePopUp");
		playerTwoPopUp = GameObject.Find("playerTwoPopUp");
		playerOneWins = GameObject.Find("playerOneWins");
		playerTwoWins = GameObject.Find("playerTwoWins");
		difChoose = GameObject.Find("difChoose");
		boxCheckArray = new bool[9];
		bodyPartsManager = GameObject.Find("BodyPartsManager");
		bodyPartsScript = bodyPartsManager.GetComponent<BodyPartsManager>();
		changePlayerText = GetComponent<Text>();
	}


	bool gameOver() {
		int check = 0;
		for (int i = 0; i < 9; ++i) {
			if (boxCheckArray[i] == false) {
				check = 1;
			}
		}
		if (check == 0) {
			return true;
		} else {
			return false;
		}
	}

	void boxCheckArrayInit() {
		for (int i = 0; i < 9; ++i) {
			boxCheckArray[i] = false;
		}
	}

	void boxOneCheck() {
		if (boxCheckArray[0] != true) {
			if (horizontalArray[0, 0] == true && horizontalArray[1, 0] == true) {
				if (verticalArray[0, 0] == true && verticalArray[0, 1] == true) {
					boxCheckArray[0] = true;
					setScore();
				}
			}
		}
	}

	void boxTwoCheck() {
		if (boxCheckArray[1] != true) {
			if (horizontalArray[0, 1] == true && horizontalArray[1, 1] == true) {
				if (verticalArray[0, 1] == true && verticalArray[0, 2] == true) {
					boxCheckArray[1] = true;
					setScore();

				}
			}
		}
	}

	void boxThreeCheck() {
		if (boxCheckArray[2] != true) {
			if (horizontalArray[0, 2] == true && horizontalArray[1, 2] == true) {
				if (verticalArray[0, 2] == true && verticalArray[0, 3] == true) {
					boxCheckArray[2] = true;
					setScore();
				}
			}
		}
	}

	void boxFourCheck() {
		if (boxCheckArray[3] != true) {
			if (horizontalArray[1, 0] == true && horizontalArray[2, 0] == true) {
				if (verticalArray[1, 0] == true && verticalArray[1, 1] == true) {
					boxCheckArray[3] = true;
					setScore();

				}
			}
		}
	}

	void boxFiveCheck()	 {
		if (boxCheckArray[4] != true) {
			if (horizontalArray[1, 1] == true && horizontalArray[2, 1] == true) {
				if (verticalArray[1, 1] == true && verticalArray[1, 2] == true) {
					boxCheckArray[4] = true;
					setScore();
				}
			}
		}
	}

	void boxSixCheck() {
		if (boxCheckArray[5] != true) {
			if (horizontalArray[1, 1] == true && horizontalArray[2, 2] == true) {
				if (verticalArray[1, 2] == true && verticalArray[1, 3] == true) {
					boxCheckArray[5] = true;
					setScore();

				}
			}
		}
	}

	void boxSevenCheck() {
		if (boxCheckArray[6] != true) {
			if (horizontalArray[2, 0] == true && horizontalArray[3, 0] == true) {
				if (verticalArray[2, 0] == true && verticalArray[2, 1] == true) {
					boxCheckArray[6] = true;
					setScore();
				}
			}
		}
	}

	void boxEightCheck() {
		if (boxCheckArray[7] != true) {
			if (horizontalArray[2, 1] == true && horizontalArray[3, 1] == true) {
				if (verticalArray[2, 1] == true && verticalArray[2, 2] == true) {
					boxCheckArray[7] = true;
					setScore();
				}
			}
		}
	}

	void boxNineCheck() {
		if (boxCheckArray[8] != true) {
			if (horizontalArray[2, 2] == true && horizontalArray[3, 2] == true) {
				if (verticalArray[2, 2] == true && verticalArray[2, 3] == true) {
					boxCheckArray[8] = true;
					setScore();
				}
			}
		}
	}

	// Use this for initialization
	void Start() {
		//lineName.SetActive(false);
		greenHOne.SetActive(false);
		greenHTwo.SetActive(false);
		greenHThree.SetActive(false);
		greenHFour.SetActive(false);
		greenHFive.SetActive(false);
		greenHSix.SetActive(false);
		greenHSeven.SetActive(false);
		greenHEight.SetActive(false);
		greenHNine.SetActive(false);
		greenHTen.SetActive(false);
		greenHEleven.SetActive(false);
		greenHTwelve.SetActive(false);
		greenVOne.SetActive(false);
		greenVTwo.SetActive(false);
		greenVThree.SetActive(false);
		greenVFour.SetActive(false);
		greenVFive.SetActive(false);
		greenVSix.SetActive(false);
		greenVSeven.SetActive(false);
		greenVEight.SetActive(false);
		greenVNine.SetActive(false);
		greenVTen.SetActive(false);
		greenVEleven.SetActive(false);
		greenVTwelve.SetActive(false);
		blueVOne.SetActive(false);
		blueVTwo.SetActive(false);
		blueVThree.SetActive(false);
		blueVFour.SetActive(false);
		blueVFive.SetActive(false);
		blueVSix.SetActive(false);
		blueVSeven.SetActive(false);
		blueVEight.SetActive(false);
		blueVNine.SetActive(false);
		blueVTen.SetActive(false);
		blueVEleven.SetActive(false);
		blueVTwelve.SetActive(false);
		blueHOne.SetActive(false);
		blueHTwo.SetActive(false);
		blueHThree.SetActive(false);
		blueHFour.SetActive(false);
		blueHFive.SetActive(false);
		blueHSix.SetActive(false);
		blueHSeven.SetActive(false);
		blueHEight.SetActive(false);
		blueHNine.SetActive(false);
		blueHTen.SetActive(false);
		blueHEleven.SetActive(false);
		blueHTwelve.SetActive(false);
		createHorizontalArrayList();
		createVerticalArrayList();

		playerOne.playerID = 1;
		playerTwo.playerID = 2;
		playerOne.playerTurn = true;
		playerTwo.playerTurn = false;
		playerOne.score = 0;
		playerTwo.score = 0;
		boxCheckArrayInit();

		playerOnePopUp.SetActive(false);
		playerTwoPopUp.SetActive(false);
		playerOneWins.SetActive(false);
		playerTwoWins.SetActive(false);
		difChoose.SetActive(false);
		displayScore();
		bodyPartsScript.newBodyParts();
		changePlayerText.text = "";
		changePlayerText.fontSize = 48;



	}


	private void changeTurn() {
		if (playerOne.playerTurn) {
			//Debug.Log("being printf");
			playerTwo.playerTurn = true;
			playerOne.playerTurn = false;
			//playerTwoPopUp.SetActive(true);
			//StartCoroutine(popUps(2));
		} else {
			//Debug.Log("chafjdhkjf");
			playerTwo.playerTurn = false;
			playerOne.playerTurn = true;
			//playerOnePopUp.SetActive(true);
			//StartCoroutine(popUps(1));
		}
		bodyPartsScript.newBodyParts();
	}

	/*Displays the score for both players*/
	void displayScore() {
		playerOneCount.text = "Count: " + playerOne.score.ToString();
		playerTwoCount.text = "Count: " + playerTwo.score.ToString();
	}

	void setScore() {
		if (playerOne.playerTurn) {
			playerOne.score += 1;
		}
		if (playerTwo.playerTurn) {
			playerTwo.score += 1;
		}
		//displayScore();
	}

	IEnumerator popUps(int number) {
		if (number == 1) {
			changePlayerText.text = "Player One's Turn";
			yield return new WaitForSeconds(3);
			changePlayerText.text = " ";
		} else if (number == 2) {
			changePlayerText.text = "Player Two's Turn";
			yield return new WaitForSeconds(3);
			changePlayerText.text = " ";
		} else if (number == 0) {
			changePlayerText.text = "Player One Start's";
			yield return new WaitForSeconds(3);
			changePlayerText.text = " ";
		}
		/*switch (number) {
		case 1:
		yield return new WaitForSeconds(5);
		playerOneWins.SetActive(false);
		break;
		case 2:
		yield return new WaitForSeconds(5);
		playerTwoWins.SetActive(false);
		break;
		case 3:
		yield return new WaitForSeconds(5);
		playerOnePopUp.SetActive(false);
		Debug.Log("player one");
		break;
		case 4:
		yield return new WaitForSeconds(5);
		playerTwoPopUp.SetActive(false);
		Debug.Log("player2");
		break;
		case 5:
		yield return new WaitForSeconds(5);
		difChoose.SetActive(false);
		break;
		}*/





		/*if (number == 3) {
			yield return new WaitForSeconds(5);
			playerOnePopUp.SetActive(false);
			Debug.Log("player one");
		} else if (number == 4) {
			yield return new WaitForSeconds(5);
			playerTwoPopUp.SetActive(false);
			Debug.Log("player2");
		}*/
	}




	// Update is called once per frame
	void Update() {
		if (playerOne.playerTurn) {
			if (createLine(playerOne.playerID)) {
				Debug.Log("player one");
				changeTurn();

			}
			//Debug.Log("player one");
		} else {
			if (createLine(playerTwo.playerID)) {
				Debug.Log("player Two");
				changeTurn();
			}
		}
		boxOneCheck();
		boxTwoCheck();
		boxThreeCheck();
		boxFourCheck();
		boxFiveCheck();
		boxSixCheck();
		boxSevenCheck();
		boxEightCheck();
		boxNineCheck();
		//finishTurn();
		if (gameOver()) {
			winner();
		}
		displayScore();
	}

	void createHorizontalArrayList() {
		horizontalArray = new bool[,] {
			{false, false, false},
			{false, false, false},
			{false, false, false},
			{false, false, false}
		};
	}

	void createVerticalArrayList() {
		verticalArray = new bool[,] {
			{false, false, false, false},
			{false, false, false, false},
			{false, false, false, false}
		};
	}

	int winner() {
		if (playerOne.score > playerTwo.score) {
			return 1;
		}
		if (playerOne.score < playerTwo.score) {
			return 2;
		}
		return 0;
	}

	//green is player1 blue is player 2
	private bool createLine(int playerID) {
		//private void createLine() {
		if (Input.GetKey(KeyCode.W)) {
			if (Input.GetKey(KeyCode.A)) {
				/*if (greenHOne.activeSelf == true || blueHOne.activeSelf == true) {
					StartCoroutine(popUps(5));
				} else {*/


				if (playerID == 1) {
					/*if set active do nothing else set active*/
					horizontalArray[0, 0] = true;
					greenHOne.SetActive(true);
					return true;
				} else {
					blueHOne.SetActive(true);
					horizontalArray[0, 0] = true;
					return true;
				}


				//}
				//checkKey(int one, int two, char axis)
			} else if (Input.GetKey(KeyCode.F)) {
				/*if (greenVOne.activeSelf == true || blueVOne.activeSelf == true) {
					StartCoroutine(popUps(5));
				} else {*/

				if (playerID == 1) {
					verticalArray[0, 0] = true;
					greenVOne.SetActive(true);
					return true;
				} else {
					verticalArray[0, 0] = true;
					blueVOne.SetActive(true);
					return true;
				}
				//}
			}
		}

		if (Input.GetKey(KeyCode.A)) {
			if (Input.GetKey(KeyCode.W)) {
				/*if (greenHOne.activeSelf == true || blueHOne.activeSelf == true) {
					StartCoroutine(popUps(5));
				} else {*/


				if (playerID == 1) {
					horizontalArray[0, 0] = true;
					greenHOne.SetActive(true);
					return true;
				} else {
					horizontalArray[0, 0] = true;
					blueHOne.SetActive(true);
					return true;
				}


				//}
			} else if (Input.GetKey(KeyCode.S)) {
				if (playerID == 1) {
					horizontalArray[0, 1] = true;
					greenHTwo.SetActive(true);
					return true;
				} else {
					horizontalArray[0, 1] = true;
					blueHTwo.SetActive(true);
					return true;
				}
			} else if (Input.GetKey(KeyCode.G)) {
				if (playerID == 1) {
					verticalArray[0, 1] = true;
					greenVTwo.SetActive(true);
					return true;
				} else {
					verticalArray[0, 1] = true;
					blueVTwo.SetActive(true);
					return true;
				}
			}
		}

		if (Input.GetKey(KeyCode.S)) {
			if (Input.GetKey(KeyCode.A)) {
				if (playerID == 1) {
					horizontalArray[0, 1] = true;
					greenHTwo.SetActive(true);
					return true;
				} else {
					horizontalArray[0, 1] = true;
					blueHTwo.SetActive(true);
					return true;
				}
			} else if (Input.GetKey(KeyCode.D)) {
				if (playerID == 1) {
					horizontalArray[0, 2] = true;
					greenHThree.SetActive(true);
					return true;
				} else {
					horizontalArray[0, 2] = true;
					blueHThree.SetActive(true);
					return true;
				}
			} else if (Input.GetKey(KeyCode.H)) {
				if (playerID == 1) {
					verticalArray[0, 2] = true;
					greenVThree.SetActive(true);
					return true;
				} else {
					verticalArray[0, 2] = true;
					blueVThree.SetActive(true);
					return true;
				}
 			}
		}

		if (Input.GetKey(KeyCode.D)) {
			if (Input.GetKey(KeyCode.S)) {
				if (playerID == 1) {
					horizontalArray[0, 2] = true;
					greenHThree.SetActive(true);
					return true;
				} else {
					horizontalArray[0, 2] = true;
					blueHThree.SetActive(true);
					return true;
				}
			} else if (Input.GetKey(KeyCode.J)) {
				if (playerID == 1) {
					verticalArray[0, 3] = true;
					greenVFour.SetActive(true);
					return true;
				} else {
					verticalArray[0, 3] = true;
					blueVFour.SetActive(true);
					return true;
				}
			}
		}

		if (Input.GetKey(KeyCode.F)) {
			if (Input.GetKey(KeyCode.W)) {
				if (playerID == 1) {
					verticalArray[0, 0] = true;
					greenVOne.SetActive(true);
					return true;
				} else {
					verticalArray[0, 0] = true;
					blueVOne.SetActive(true);
					return true;
				}
			} else if (Input.GetKey(KeyCode.G)) {
				if (playerID == 1) {
					horizontalArray[1, 0] = true;
					greenHFour.SetActive(true);
					return true;
				} else {
					horizontalArray[1, 0] = true;
					blueHFour.SetActive(true);
					return true;
				}
			} else if (Input.GetKey(KeyCode.K)) {
				if (playerID == 1) {
					verticalArray[1, 0] = true;
					greenVFive.SetActive(true);
					return true;
				} else {
					verticalArray[1, 0] = true;
					blueVFive.SetActive(true);
					return true;
				}
			}
		}

		if (Input.GetKey(KeyCode.G)) {
			if (Input.GetKey(KeyCode.F)) {
				if (playerID == 1) {
					horizontalArray[1, 0] = true;
					greenHFour.SetActive(true);
					return true;
				} else {
					horizontalArray[1, 0] = true;
					blueHFour.SetActive(true);
					return true;
				}
			} else if (Input.GetKey(KeyCode.A)) {
				if (playerID == 1) {
					verticalArray[0, 1] = true;
					greenVTwo.SetActive(true);
					return true;
				} else {
					verticalArray[0, 1] = true;
					blueVTwo.SetActive(true);
					return true;
				}
			} else if (Input.GetKey(KeyCode.H)) {
				if (playerID == 1) {
					horizontalArray[1, 1] = true;
					greenHFive.SetActive(true);
					return true;
				} else {
					horizontalArray[1, 1] = true;
					blueHFive.SetActive(true);
					return true;
				}
			} else if (Input.GetKey(KeyCode.L)) {
				if (playerID == 1) {
					verticalArray[1, 1] = true;
					greenVSix.SetActive(true);
					return true;
				} else {
					verticalArray[1, 1] = true;
					blueVSix.SetActive(true);
					return true;
				}
			}
		}

		if (Input.GetKey(KeyCode.H)) {
			if (Input.GetKey(KeyCode.S)) {
				if (playerID == 1) {
					verticalArray[0, 2] = true;
					greenVThree.SetActive(true);
					return true;
				} else {
					verticalArray[0, 2] = true;
					blueVThree.SetActive(true);
					return true;
				}
			} else if (Input.GetKey(KeyCode.G)) {
				if (playerID == 1) {
					horizontalArray[1, 1] = true;
					greenHFive.SetActive(true);
					return true;
				} else {
					horizontalArray[1, 1] = true;
					blueHFive.SetActive(true);
					return true;
				}
			} else if (Input.GetKey(KeyCode.Z)) {
				if (playerID == 1) {
					verticalArray[1, 2] = true;
					greenVSeven.SetActive(true);
					return true;
				} else {
					verticalArray[1, 2] = true;
					blueVSeven.SetActive(true);
					return true;
				}
			} else if (Input.GetKey(KeyCode.J)) {
				if (playerID == 1) {
					greenHSix.SetActive(true);
					return true;
				} else {
					blueHSix.SetActive(true);
					return true;
				}
				//horizontalArray[1, 2] = true;
			}
		}

		if (Input.GetKey(KeyCode.J)) {
			if (Input.GetKey(KeyCode.D)) {
				if (playerID == 1) {
					verticalArray[0, 3] = true;
					greenVFour.SetActive(true);
					return true;
				} else {
					verticalArray[0, 3] = true;
					blueVFour.SetActive(true);
					return true;
				}
			} else if (Input.GetKey(KeyCode.H)) {
				if (playerID == 1) {
					horizontalArray[1, 2] = true;
					greenHSix.SetActive(true);
					return true;
				} else {
					horizontalArray[1, 2] = true;
					blueHSix.SetActive(true);
					return true;
				}
			} else if (Input.GetKey(KeyCode.X)) {
				if (playerID == 1) {
					verticalArray[1, 3] = true;
					greenVEight.SetActive(true);
					return true;
				} else {
					verticalArray[1, 3] = true;
					blueVEight.SetActive(true);
					return true;
				}
			}
		}

		if (Input.GetKey(KeyCode.K)) {
			if (Input.GetKey(KeyCode.F)) {
				//Debug.Log("4");
				if (playerID == 1) {
					verticalArray[1, 0] = true;
					greenVFive.SetActive(true);
					return true;
				} else {
					verticalArray[1, 0] = true;
					blueVFive.SetActive(true);
					return true;
				}
			} else if (Input.GetKey(KeyCode.L)) {
				if (playerID == 1) {
					horizontalArray[2, 0] = true;
					greenHSeven.SetActive(true);
					return true;
				} else {
					horizontalArray[2, 0] = true;
					blueHSeven.SetActive(true);
					return true;
				}
			} else if (Input.GetKey(KeyCode.Space)) {
				if (playerID == 1) {
					verticalArray[2, 0] = true;
					greenVNine.SetActive(true);
					return true;
				} else {
					verticalArray[2, 0] = true;
					blueVNine.SetActive(true);
					return true;
				}
			}
		}

		if (Input.GetKey(KeyCode.L)) {
			if (Input.GetKey(KeyCode.G)) {
				if (playerID == 1) {
					verticalArray[1, 1] = true;
					greenVSix.SetActive(true);
					return true;
				} else {
					verticalArray[1, 1] = true;
					blueVSix.SetActive(true);
					return true;
				}
			} else if (Input.GetKey(KeyCode.Z)) {
				if (playerID == 1) {
					horizontalArray[2, 1] = true;
					greenHEight.SetActive(true);
					return true;
				} else {
					horizontalArray[2, 1] = true;
					blueHEight.SetActive(true);
					return true;
				}
			} else if (Input.GetKey(KeyCode.UpArrow)) {
				if (playerID == 1) {
					verticalArray[2, 1] = true;
					greenVTen.SetActive(true);
					return true;
				} else {
					verticalArray[2, 1] = true;
					blueVTen.SetActive(true);
					return true;
				}
			}
		}

		if (Input.GetKey(KeyCode.Z)) {
			if (Input.GetKey(KeyCode.H)) {
				if (playerID == 1) {
					verticalArray[1, 2] = true;
					greenVSeven.SetActive(true);
					return true;
				} else {
					verticalArray[1, 2] = true;
					blueVSeven.SetActive(true);
					return true;
					//verticalArray[1, 2] = true;
				}
			} else if (Input.GetKey(KeyCode.L)) {
				if (playerID == 1) {
					horizontalArray[2, 1] = true;
					greenHEight.SetActive(true);
					return true;
				} else {
					horizontalArray[2, 1] = true;
					blueHEight.SetActive(true);
					return true;
				}
				//horizontalArray[2, 1] = true;

			} else if (Input.GetKey(KeyCode.X)) {
				if (playerID == 1) {
					horizontalArray[2, 2] = true;
					greenHNine.SetActive(true);
					return true;
				} else {
					horizontalArray[2, 2] = true;
					blueHNine.SetActive(true);
					return true;
				}
				//horizontalArray[2, 2] = true;
			} else if (Input.GetKey(KeyCode.DownArrow)) {
				if (playerID == 1) {
					verticalArray[2, 2] = true;
					greenVEleven.SetActive(true);
					return true;
				} else {
					verticalArray[2, 2] = true;
					blueVEleven.SetActive(true);
					return true;
				}
				//verticalArray[2, 2] = true;
			}
		}

		if (Input.GetKey(KeyCode.X)) {
			if (Input.GetKey(KeyCode.J)) {
				if (playerID == 1) {
					verticalArray[1, 3] = true;
					greenVEight.SetActive(true);
					return true;
				} else {
					verticalArray[1, 3] = true;
					blueVEight.SetActive(true);
					return true;
				}
				//verticalArray[1, 3] = true;
			} else if (Input.GetKey(KeyCode.Z)) {
				if (playerID == 1) {
					horizontalArray[2, 2] = true;
					greenHNine.SetActive(true);
					return true;
				} else {
					horizontalArray[2, 2] = true;
					blueHNine.SetActive(true);
					return true;
				}
				//horizontalArray[2, 2] = true;
			} else if (Input.GetKey(KeyCode.LeftArrow)) {
				if (playerID == 1) {
					verticalArray[2, 3] = true;
					greenVTwelve.SetActive(true);
					return true;
				} else {
					verticalArray[2, 3] = true;
					blueVTwelve.SetActive(true);
					return true;
				}
				//verticalArray[2, 3] = true;
			}
		}

		if (Input.GetKey(KeyCode.Space)) {
			if (Input.GetKey(KeyCode.K)) {
				if (playerID == 1) {
					verticalArray[2, 0] = true;
					greenVNine.SetActive(true);
					return true;
				} else {
					verticalArray[2, 0] = true;
					blueVNine.SetActive(true);
					return true;
				}
				//verticalArray[2, 0] = true;
			} else if (Input.GetKey(KeyCode.UpArrow)) {
				if (playerID == 1) {
					horizontalArray[3, 0] = true;
					greenHTen.SetActive(true);
					return true;
				} else {
					horizontalArray[3, 0] = true;
					blueHTen.SetActive(true);
					return true;
				}
				//horizontalArray[3, 0] = true;
			}
		}

		if (Input.GetKey(KeyCode.UpArrow)) {
			if (Input.GetKey(KeyCode.L)) {
				if (playerID == 1) {
					verticalArray[2, 1] = true;
					greenVTen.SetActive(true);
					return true;
				} else {
					verticalArray[2, 1] = true;
					blueVTen.SetActive(true);
					return true;
				}
				//verticalArray[2, 1] = true;
			} else if (Input.GetKey(KeyCode.Space)) {
				if (playerID == 1) {
					horizontalArray[3, 0] = true;
					greenHTen.SetActive(true);
					return true;
				} else {
					horizontalArray[3, 0] = true;
					blueHTen.SetActive(true);
					return true;
				}
				//horizontalArray[3, 0] = true;
			} else if (Input.GetKey(KeyCode.DownArrow)) {
				if (playerID == 1) {
					horizontalArray[3, 1] = true;
					greenHEleven.SetActive(true);
					return true;
				} else {
					horizontalArray[3, 1] = true;
					blueHEleven.SetActive(true);
					return true;
				}
				//horizontalArray[3, 1] = true;
			}
		}

		if (Input.GetKey(KeyCode.DownArrow)) {
			if (Input.GetKey(KeyCode.Z)) {
				if (playerID == 1) {
					verticalArray[2, 2] = true;
					greenVTwelve.SetActive(true);
					return true;
				} else {
					verticalArray[2, 2] = true;
					blueVTwelve.SetActive(true);
					return true;
				}
				//verticalArray[2, 2] = true;
			} else if (Input.GetKey(KeyCode.UpArrow)) {
				if (playerID == 1) {
					horizontalArray[3, 1] = true;
					greenHEleven.SetActive(true);
					return true;
				} else {
					horizontalArray[3, 1] = true;
					blueHEleven.SetActive(true);
					return true;
				}
				//horizontalArray[3, 1] = true;
			} else if (Input.GetKey(KeyCode.LeftArrow)) {
				if (playerID == 1) {
					horizontalArray[3, 2] = true;
					greenHTwelve.SetActive(true);
					return true;
				} else {
					horizontalArray[3, 2] = true;
					blueHTwelve.SetActive(true);
					return true;
				}
				//horizontalArray[3, 2] = true;
			}
		}

		if (Input.GetKey(KeyCode.LeftArrow)) {
			if (Input.GetKey(KeyCode.X)) {
				if (playerID == 1) {
					verticalArray[2, 3] = true;
					greenVTwelve.SetActive(true);
					return true;
				} else {
					verticalArray[2, 3] = true;
					blueVTwelve.SetActive(true);
					return true;
				}
				//verticalArray[2, 3] = true;
			} else if (Input.GetKey(KeyCode.DownArrow)) {
				if (playerID == 1) {
					horizontalArray[3, 2] = true;
					greenHTwelve.SetActive(true);
					return true;
				} else {
					horizontalArray[3, 2] = true;
					blueHTwelve.SetActive(true);
					return true;
				}
				//horizontalArray[3, 2] = true;
			}
		}
		return false;
	}
}
