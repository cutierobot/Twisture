using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;


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




	//private GameObject 
	//import collaborators for this class
	//private DotScript dotScript;
	private DotManager dotManagerScript;

	private Line lineScript;
	private GameObject line;
	private List<Line> lineList;
	
	private	LineLibrary lineLibraryScript;
	private List<List<Line>> lineLibraryList;

	private string mouse1;
	private string mouse2;

	private int lineCount = 0;// counts what line you are on in lineList
	private int lineNumber = 0; //the number of lines in the lineList

	private PlayerManager player;
	private int playerID;

	private bool[,] horizontalArray;
	private bool[,] verticalArray;

	private int mouse1Int;
	private int mouse2Int;
	private int clickCount;
	private int doubleClick;


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


		//Retrieve DotManager.cs script from GameObject DotManager.
		GameObject dotManager = GameObject.Find("DotManager");
		dotManagerScript = dotManager.GetComponent<DotManager>();

		//creates a reference to PlayerManager
		GameObject playerManager = GameObject.Find("PlayerManager");
		player = playerManager.GetComponent<PlayerManager>();

		
		line = GameObject.Find("line");
		lineScript = line.GetComponent<Line>();
		lineList = new List<Line>();

		GameObject lineLibrary = GameObject.Find("lineLibrary");
		lineLibraryScript = lineLibrary.GetComponent<LineLibrary>();
		lineLibraryList = new List<List<Line>>();

		mouse1 = dotManagerScript.Mouse1();
		mouse2 = dotManagerScript.Mouse2();
		playerID = player.getPlayerID();
		convertMouse1(mouse1);
		convertMouse2(mouse2);
		
	}

	void convertMouse1(string mouse1) {
		switch(mouse1) {
			case "dotOne" :
				mouse1Int = 1;
				break;
			case "dotTwo" : 
				mouse1Int = 2;
				break;
			case "dotThree" : 
				mouse1Int = 3;
				break;
			case "dotFour" : 
				mouse1Int = 4;
				break;
			case "dotFive" : 
				mouse1Int = 5;
				break;
			case "dotSix" : 
				mouse1Int = 6;
				break;
			case "dotSeven" : 
				mouse1Int = 7;
				break;
			case "dotEight" : 
				mouse1Int = 8;
				break;
			case "dotNine" : 
				mouse1Int = 9;
				break;
			case "dotTen" : 
				mouse1Int = 10;
				break;
			case "dotEleven" : 
				mouse1Int = 11;
				break;
			case "dotTwelve" : 
				mouse1Int = 12;
				break;
			case "dotThirteen" : 
				mouse1Int = 13;
				break;
			case "dotFourteen" : 
				mouse1Int = 14;
				break;
			case "dotFifteen" : 
				mouse1Int = 15;
				break;	
			case "dotSixteen" : 
				mouse1Int = 16;
				break;
		}
	}

	void convertMouse2(string mouse2) {
		switch(mouse2) {
			case "dotOne" :
				mouse2Int = 1;
				break;
			case "dotTwo" : 
				mouse2Int = 2;
				break;
			case "dotThree" : 
				mouse2Int = 3;
				break;
			case "dotFour" : 
				mouse2Int = 4;
				break;
			case "dotFive" : 
				mouse2Int = 5;
				break;
			case "dotSix" : 
				mouse2Int = 6;
				break;
			case "dotSeven" : 
				mouse2Int = 7;
				break;
			case "dotEight" : 
				mouse2Int = 8;
				break;
			case "dotNine" : 
				mouse2Int = 9;
				break;
			case "dotTen" : 
				mouse2Int = 10;
				break;
			case "dotEleven" : 
				mouse2Int = 11;
				break;
			case "dotTwelve" : 
				mouse2Int = 12;
				break;
			case "dotThirteen" : 
				mouse2Int = 13;
				break;
			case "dotFourteen" : 
				mouse2Int = 14;
				break;
			case "dotFifteen" : 
				mouse2Int = 15;
				break;	
			case "dotSixteen" : 
				mouse2Int = 16;
				break;
		}
	}

	bool isHorizontal() {
		if(mouse1 == "dotOne" && mouse2 == "dotTwo") {
			return true;
		} else if(mouse1 == "dotTwo" && mouse2 == "dotOne") {
			return true;
		} else if(mouse1 == "dotTwo" && mouse2 == "dotThree") {
			return true;
		} else if(mouse1 == "dotThree" && mouse2 == "dotTwo") {
			return true;
		} else if(mouse1 == "dotThree" && mouse2 == "dotFour") {
			return true;
		} else if(mouse1 == "dotFour" && mouse2 == "dotThree") {
			return true;
		} else if(mouse1 == "dotFive" && mouse2 == "dotSix") {
			return true;
		} else if(mouse1 == "dotSix" && mouse2 == "dotFive") {
			return true;
		} else if(mouse1 == "dotSix" && mouse2 == "dotSeven") {
			return true;
		} else if(mouse1 == "dotSeven" && mouse2 == "dotSix") {
			return true;
		} else if(mouse1 == "dotSeven" && mouse2 == "dotEight") {
			return true;
		} else if(mouse1 == "dotEight" && mouse1 == "dotSeven") {
			return true;
		} else if(mouse1 == "dotNine" && mouse2 == "dotTen") {
			return true;
		} else if(mouse1 == "dotTen" && mouse2 == "dotNine") {
			return true;
		} else if(mouse1 == "dotTen" && mouse2 == "dotEleven") {
			return true;
		} else if(mouse1 == "dotEleven" && mouse2 == "dotTen") {
			return true;
		} else if(mouse1 == "dotEleven" && mouse2 == "dotTwelve") {
			return true;
		} else if(mouse1 == "dotTwelve" && mouse2 == "dotEleven") {
			return true;
		} else if(mouse1 == "dotThirteen" && mouse2 == "dotFourteen") {
			return true;
		} else if(mouse1 == "dotFourteen" && mouse2 == "dotThirteen") {
			return true;
		} else if(mouse1 == "dotFourteen" && mouse2 == "dotFifteen") {
			return true;
		} else if(mouse1 == "dotFifteen" && mouse2 == "dotFourteen") {
			return true;
		} else if(mouse1 == "dotFifteen" && mouse2 == "dotSixteen") {
			return true;
		} else if(mouse1 == "dotSixteen" && mouse2 == "dotFifteen") {
			return true;
		} else {
			return false;
		}
	}


	bool isVertical() {
		if(mouse1 == "dotOne" && mouse2 == "dotFive") {
			return true;
		} else if(mouse1 == "dotFive" && mouse2 == "dotOne") {
			return true;
		} else if(mouse1 == "dotTwo" && mouse2 == "dotSix") {
			return true;
		} else if(mouse1 == "dotSix" && mouse2 == "dotTwo") {
			return true;
		} else if(mouse1 == "dotThree" && mouse2 == "dotSeven") {
			return true;
		} else if(mouse1 == "dotSeven" && mouse2 == "dotThree") {
			return true;
		} else if(mouse1 == "dotFour" && mouse2 == "dotEight") {
			return true;
		} else if(mouse1 == "dotEight" && mouse2 == "dotFour") {
			return true;
		} else if(mouse1 == "dotFive" && mouse2 == "dotNine") {
			return true;
		} else if(mouse1 == "dotNine" && mouse2 == "dotFive") {
			return true;
		} else if(mouse1 == "dotSix" && mouse2 == "dotTen") {
			return true;
		} else if(mouse1 == "dotTen" && mouse2 == "dotSix") {
			return true;
		} else if(mouse1 == "dotSeven" && mouse2 == "dotEleven") {
			return true;
		} else if(mouse1 == "dotEleven" && mouse2 == "dotSeven") {
			return true;
		} else if(mouse1 == "dotEight" && mouse2 == "dotTwelve") {
			return true;
		} else if(mouse1 == "dotTwelve" && mouse2 == "dotEight") {
			return true;
		} else if(mouse1 == "dotNine" && mouse2 == "dotThirteen") {
			return true;
		} else if(mouse1 == "dotThirteen" && mouse2 == "dotNine") {
			return true;
		} else if(mouse1 == "dotTen" && mouse2 == "dotFourteen") {
			return true;
		} else if(mouse1 == "dotFourteen" && mouse2 == "dotTen") {
			return true;
		} else if(mouse1 == "dotEleven" && mouse2 == "dotFifteen") {
			return true;
		} else if(mouse1 == "dotFifteen" && mouse2 == "dotEleven") {
			return true;
		} else if(mouse1 == "dotTwelve" && mouse2 == "dotSixteen") {
			return true;
		} else if(mouse1 == "dotSixteen" && mouse2 == "dotTwelve") {
			return true;
		} else {
			return false;
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
	}

	/*void clearMouse() {
		mouse1Int = 333;
	}*/
	
	// Update is called once per frame
	void Update() {
		clickCount = dotManagerScript.getCount();
		if(clickCount == 1) {
			mouse1 = dotManagerScript.Mouse1();
			doubleClick = doubleClick + 1;
			//Debug.Log("1");
		} else if (clickCount == 2){
			mouse2 = dotManagerScript.Mouse2();
			doubleClick = doubleClick + 1;
			//Debug.Log("2");
		}
		//Debug.Log("doubleClick" + doubleClick);
		convertMouse1(mouse1);
		convertMouse2(mouse2);
		if(doubleClick == 2) {
			if(isHorizontal()) {
				//Debug.Log("is called");
				if (horizontalArray[mouse1Int,mouse2Int] == false) {
					createLine(mouse1, mouse2);
					doubleClick = 0;
					//Debug.Log("horizontalArray");
				}
			} else if(isVertical()){
				if(verticalArray[mouse1Int,mouse2Int] == false){
					createLine(mouse1, mouse2);
					doubleClick = 0;
					//Debug.Log("verticalArray");
				}
			}
		}
	}

	void createHorizontalArrayList() {
		horizontalArray = new bool[,] {
			{false, false, false},
			{false, false, false},
			{false, false, false}
		};
	}

	void createVerticalArrayList() {
		verticalArray = new bool[,] {
			{false, false, false},
			{false, false, false},
			{false, false, false}
		};
	}

	/*
		Records the mouse1, mouse2 and playerID of the current line.

		newMouse1: Vector3 position to be added to the list.
		newMouse2: Vector3 position to be added to the list.
		newPlayerID: intenger representing the player that drew the line. 1
			represents player1 and 2 represetns player2.
	*/
	void recordLine(string newMouse1, string newMouse2, int newPlayerID) {
		lineList.Add(new Line(newMouse1, newMouse2, newPlayerID));
		lineNumber= lineNumber + 1;
	}


	/*
		Checks the list for dublicate values. If a duplicate if found method
		returns true otherwise false.
	*/
	bool checkList(string newMouse1, string newMouse2) {
		for (int list = 0; list < lineNumber; list = list + 1) {
			if (lineList[lineCount].GetMouse1().Equals(newMouse1) || 
				lineList[lineCount].GetMouse1().Equals(newMouse2)) {
				if (lineList[lineCount].GetMouse2().Equals(newMouse2) || 
					lineList[lineCount].GetMouse2().Equals(newMouse2)) {
					return true;
				}
			}
			lineCount = lineCount + 1;
		}
		lineCount = 0;
		return false;
	}
	//green is player1 blue is player 2
	private void createLine(string mouse1, string mouse2) {
		if(mouse1 == "dotOne") {
			if(mouse2 == "dotTwo") {
				if(playerID == 1) {
					greenHOne.SetActive(true);
				} else {
					blueHOne.SetActive(true);
				}
				horizontalArray[0,0] = true;
			} else if(mouse2 == "dotFive") {
				if(playerID == 1) {
					greenVOne.SetActive(true);
				} else {
					blueVOne.SetActive(true);
				}
				verticalArray[0,0] = true;
			}
		} else if(mouse1 == "dotTwo") {
			if(mouse2 == "dotThree") {
				if(playerID == 1) {
					greenHTwo.SetActive(true);
				} else {
					blueHTwo.SetActive(true);
				}
				horizontalArray[0,1] = true;
			} else if(mouse2 == "dotSix") {
				if(playerID == 1) {
					greenVTwo.SetActive(true);
				} else {
					blueVTwo.SetActive(true);
				}
				verticalArray[0,1] = true;
			} else if(mouse2 == "dotOne") {
				if(playerID == 1) {
					greenHOne.SetActive(true);
				} else {
					blueHOne.SetActive(true);
				}
				horizontalArray[0,0] = true;
			}
		} else if(mouse1 == "dotThree") {
			if(mouse2 == "dotFour") {
				if(playerID == 1) {
					greenHThree.SetActive(true);
				} else {
					blueHThree.SetActive(true);
				}
				horizontalArray[0,2] = true;
			} else if(mouse2 == "dotSeven") {
				if(playerID == 1) {
					greenVThree.SetActive(true);
				} else {
					blueVThree.SetActive(true);
				}
				verticalArray[0,2] = true;
			} else if(mouse2 == "dotTwo") {
				if(playerID == 1) {
					greenHTwo.SetActive(true);
				} else {
					blueHTwo.SetActive(true);
				}
				horizontalArray[0,1] = true;
			}
		} else if(mouse1 == "dotFour") {
			if(mouse2 == "dotEight") {
				if(playerID == 1) {
					greenVFour.SetActive(true);
				} else {
					blueVFour.SetActive(true);
				}
				verticalArray[0,3] = true;
			} else if(mouse2 == "dotThree")  {
				if(playerID == 1) {
					greenHThree.SetActive(true);
				} else {
					blueHThree.SetActive(true);
				}
				horizontalArray[0,2] = true;
			}
		} else if(mouse1 == "dotFive") {
			if(mouse2 == "dotSix") {
				if(playerID == 1) {
					greenHFour.SetActive(true);
				} else {
					blueHFour.SetActive(true);
					horizontalArray[1,0] = true;
				}
			} else if(mouse2 == "dotNine") {
				if(playerID == 1) {
					greenVFive.SetActive(true);
				} else {
					blueVFive.SetActive(true);
				}
				verticalArray[1,0] = true;
			} else if(mouse2 == "dotOne") {
				if(playerID == 1) {
					greenVOne.SetActive(true);
				} else {
					blueVOne.SetActive(true);
				}

			}
		} else if(mouse1 == "dotSix") {
			if(mouse2 == "dotSeven") {
				if(playerID == 1) {
					greenHFive.SetActive(true);
				} else {
					blueHFive.SetActive(true);
				}
				horizontalArray[1,1] = true;
			} else if(mouse2 == "dotTen") {
				if(playerID == 1) {
					greenVSix.SetActive(true);
				} else {
					blueVSix.SetActive(true);
				}
				verticalArray[1,1] = true;
			} else if(mouse2 == "dotFive") {
				if(playerID == 1) {
					greenHFour.SetActive(true);
				} else {
					blueHFour.SetActive(true);
				}
				horizontalArray[1,0] = true;
			} else if(mouse2 == "dotTwo") {
				if(playerID == 1) {
					greenVTwo.SetActive(true);
				} else {
					blueVTwo.SetActive(true);
				}
			}
		} else if(mouse1 == "dotSeven") {
			if(mouse2 == "dotEight") {
				if(playerID == 1) {
					greenHSix.SetActive(true);
				} else {
					blueHSix.SetActive(true);
				}
				horizontalArray[1,2] = true;
			} else if(mouse2 == "dotEleven") {
				if(playerID == 1) {
					greenVSeven.SetActive(true);
				} else {
					blueVSeven.SetActive(true);
				}
				verticalArray[1,2] = true;
			} else if(mouse2 == "dotSix") {
				if(playerID == 1) {
					greenHFive.SetActive(true);
				} else {
					blueHFive.SetActive(true);
				}
				horizontalArray[1,1] = true;
			} else if(mouse2 == "dotThree") {
				if(playerID == 1) {
					greenVThree.SetActive(true);
				} else {
					blueVThree.SetActive(true);
				}
				verticalArray[0,2] = true;
			}
		} else if(mouse1 == "dotEight") {
			if(mouse2 == "dotTwelve") {
				if(playerID == 1) {
					greenVEight.SetActive(true);
				} else {
					blueVEight.SetActive(true);
				}
				verticalArray[1,3] = true;
			} else if(mouse2 == "dotSeven") {
				if(playerID == 1) {
					greenHSix.SetActive(true);
				} else {
					blueHSix.SetActive(true);
				}
				horizontalArray[1,2] = true;
			} else if(mouse2 == "dotFour") {
				if(playerID == 1) {
					greenVFour.SetActive(true);
				} else {
					blueVFour.SetActive(true);
				}
				verticalArray[0,3] = true;
			}
		} else if(mouse1 == "dotNine") {
			if(mouse2 == "dotTen") {
				if(playerID == 1) {
					greenHSeven.SetActive(true);
				} else {
					blueHSeven.SetActive(true);
				}
				horizontalArray[2,0] = true;
			} else if(mouse2 == "dotThirteen") {
				if(playerID == 1) {
					greenVNine.SetActive(true);
				} else {
					blueVNine.SetActive(true);
				}
				verticalArray[3,0] = true;
			} else if(mouse2 == "dotFive") {
				if(playerID == 1) {
					greenVFive.SetActive(true);
				} else {
					blueVFive.SetActive(true);
				}
				verticalArray[1,0] = true;
			}
		} else if(mouse1 == "dotTen") {
			if(mouse2 == "dotEleven") {
				if(playerID == 1) {
					greenHEight.SetActive(true);
				} else {
					blueHEight.SetActive(true);
				}
				horizontalArray[2,1] = true;
			} else if(mouse2 == "dotFourteen") {
				if(playerID == 1) {
					greenVTen.SetActive(true);
				} else {
					blueVTen.SetActive(true);
				}
				verticalArray[2,1] = true;
			} else if(mouse2 == "dotNine") {
				if(playerID == 1) {
					greenHSeven.SetActive(true);
				} else {
					blueHSeven.SetActive(true);
				}
				horizontalArray[2,0] = true;
			} else if(mouse2 == "dotSix") {
				if(playerID == 1) {
					greenVSix.SetActive(true);
				} else {
					blueVSix.SetActive(true);
				}
				verticalArray[1,1] = true;
			}
		} else if(mouse1 == "dotEleven") {
			if(mouse2 == "dotTwelve") {
				if(playerID == 1) {
					greenHNine.SetActive(true);
				} else {
					blueHNine.SetActive(true);
				}
				horizontalArray[2,2] = true;
			} else if(mouse2 == "dotFifteen") {
				if(playerID == 1) {
					greenVEleven.SetActive(true);
				} else {
					blueVEleven.SetActive(true);
				}
				verticalArray[2,2] = true;
			} else if(mouse2 == "dotTen") {
				if(playerID == 1) {
					greenHEight.SetActive(true);
				} else {
					blueHEight.SetActive(true);
				}
				horizontalArray[1,2] = true;
			} else if(mouse2 == "dotSeven") {
				if(playerID == 1) {
					greenVSeven.SetActive(true);
				} else {
					blueVSeven.SetActive(true);
				}
				verticalArray[1,2] = true;
			}
		} else if(mouse1 == "dotTwelve") {
			if(mouse2 == "dotSixteen") {
				if(playerID == 1) {
					greenVTwelve.SetActive(true);
				} else {
					blueVTwelve.SetActive(true);
				}
				verticalArray[2,3] = true;
			} else if(mouse2 == "dotEight") {
				if(playerID == 1) {
					greenVEight.SetActive(true);
				} else {
					blueVEight.SetActive(true);
				}
				verticalArray[1,3] = true;
			} else if(mouse2 == "dotEleven") {
				if(playerID == 1) {
					greenHNine.SetActive(true);
				} else {
					blueHNine.SetActive(true);
				}
				horizontalArray[2,2] = true;
			}
		} else if(mouse1 == "dotThirteen") {
			if(mouse2 == "dotFourteen") {
				if(playerID == 1) {
					greenHTen.SetActive(true);
				} else {
					blueHTen.SetActive(true);
				}
				horizontalArray[3,0] = true;
			} else if(mouse2 == "dotNine") {
				if(playerID == 1) {
					greenVNine.SetActive(true);
				} else {
					blueVNine.SetActive(true);
				}
				verticalArray[2,0] = true;
			}
		} else if(mouse1 == "dotFourteen") {
			if(mouse2 == "dotFifteen") {
				if(playerID == 1) {
					greenHEleven.SetActive(true);
				} else {
					blueHEleven.SetActive(true);
				}
				horizontalArray[3,1] = true;
			} else if(mouse2 == "dotTen") {
				if(playerID == 1) {
					greenVTen.SetActive(true);
				} else {
					blueVTen.SetActive(true);
				}
				verticalArray[2,1] = true;
			} else if(mouse2 == "dotThirteen") {
				if(playerID == 1) {
					greenHTen.SetActive(true);
				} else {
					blueHTen.SetActive(true);
				}
				horizontalArray[3,0] = true;
			}
		} else if(mouse1 == "dotFifteen") {
			if(mouse2 == "dotSixteen") {
				if(playerID == 1) {
					greenHTwelve.SetActive(true);
				} else {
					blueHTwelve.SetActive(true);
				}
				horizontalArray[3,2] = true;
			} else if(mouse2 == "dotEleven") {
				if(playerID == 1) {
					greenVEleven.SetActive(true);
				} else {
					blueVEleven.SetActive(true);
				}
				verticalArray[2,2] = true;
			} else if(mouse2 == "dotFourteen") {
				if(playerID == 1) {
					greenHEleven.SetActive(true);
				} else {
					blueHEleven.SetActive(true);
				}
				horizontalArray[3,2] = true;
			}
		} else if(mouse1 == "dotSixteen") {
			if(mouse2 == "dotTwelve") {
				if(playerID == 1) {
					greenVTwelve.SetActive(true);
				} else {
					blueVTwelve.SetActive(true);
				}
				verticalArray[2,3] = true;
			} else if(mouse2 == "dotFifteen") {
				if(playerID == 1) {
					greenHTwelve.SetActive(true);
				} else {
					blueHTwelve.SetActive(true);
				}
				verticalArray[2,3] = true;
			}
		}
	}
}
