using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

/*
	Class used for creating a line. A line is defined as having two Vector3 
	positions and a ID for the player that drew the line. 
	
	mouse1: First Vector3 in line where the player clicked to start drawing a 
	line. Start position for drawing a line.

	mouse2: Second Vector3 in line where player clicked to finish drawing a 
	line. End position for drawing a line.

	playerID: Identifies the player that drew the line. 1 identifies player1 and
	2 identifies player2 as drawing the line.
*/

public class Line : MonoBehaviour, IEquatable<Line> {

	//the two mouse clicks on the GameObjects
	private string mouse1;
	private string mouse2;
	//playerID is player1 or player2
	private int playerID;

	public Line(string newMouse1, string newMouse2, int newPlayerID) {
		mouse1 = newMouse1;
		mouse2 = newMouse2;
		playerID = newPlayerID;
	}

	/*
		Checks to see if the two dots clicked by the player are the same. If they 
		are then returns true, false otherwise.
	*/
	bool SameDot() {
		if (mouse1 == mouse2) {
			return true;
		}
		return false;
	}

	/*
		Retrieves mouse1 value and returns it.
	*/
	public string GetMouse1() {
		return mouse1;
	}

	/*
		Retrieves mouse2 value and returns it.
	*/
	public string GetMouse2() {
		return mouse2;
	}


	public bool Equals(Line other) {
		if (other == null) {
			return false;
		}
		if (this.mouse1.Equals(other.mouse1)) {
			if (this.mouse2.Equals(other.mouse2)) {
					return true;
			}
		}
		if (other.SameDot()) {
			return true;
		}
		return false;
	}
}
