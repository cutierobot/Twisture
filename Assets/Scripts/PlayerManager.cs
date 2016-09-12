using UnityEngine;
using System.Collections;

public struct Playerz{
	public int playerID;
	public bool playerTurn;
};

public class PlayerManager : MonoBehaviour {

	private int turn;
	private int id;
	private int otherPlayerID;
	private Playerz playerOne;
	private Playerz playerTwo;
	

	void Start() {
		Playerz playerOne = new Playerz();
		Playerz playerTwo = new Playerz();
		playerOne.playerTurn = true;
		playerTwo.playerTurn = false;
		playerOne.playerID = 1;
		playerTwo.playerID = 2;
	}

	void Update() {
		playerID(playerOne, playerTwo);
		otherPlayer(playerOne, playerTwo);
	}
	/*
		Changes current players turn. Switches player.
	*/
	private void changeTurn(Playerz playerOne, Playerz playerTwo) {
		if (playerOne.playerTurn) {
			playerOne.playerTurn = false;
			playerTwo.playerTurn = true;
			id = 2;
			turn = 2;
			otherPlayerID = 1;
		} else {
			playerOne.playerTurn = true;
			playerTwo.playerTurn = false;
			turn = 1;
			id = 1;
			otherPlayerID = 2;
		}
	}

	/*
		Returns which players turn it is. 
		For use in isPlayerChanged in bodyPartGenerator.
	*/
	public int getTurn() {
		return turn;
	}

	/*
		Retrieves the current players playerID.
	*/
	private void playerID(Playerz playerOne, Playerz playerTwo) {
		if (playerOne.playerTurn) {
			id = 1;
		} else {
			id = 2;
		}
	}

	/*
		Returns the current players playerID. For use in
		recordLine.
	*/
	public int getPlayerID() {
		return id;
	}

	private void otherPlayer(Playerz playerOne, Playerz playerTwo) {
		if(playerOne.playerTurn) {
			otherPlayerID = 2;
		} else {
			otherPlayerID = 1;
		}
	}

	public int getOtherPlayerID() {
		return otherPlayerID;
	}
}
