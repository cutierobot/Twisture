using UnityEngine;
using System.Collections;

public class DotScript : MonoBehaviour {
	
	public string clicked = "";
	//public string m1;
	//public string m2;
	//counts how many times the mouse has been clicked
	private int count = 0;
		
	// Update is called once per frame
	void Update () {
		mouseDown();
	}

	/*Detects when the mouse button is pressed on a GameObject*/
	void mouseDown() {
		if (Input.GetMouseButtonDown(0)){
			RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint
				(Input.mousePosition), Vector2.zero);
			if (hit.collider != null) {
				clicked = hit.collider.name;
				//Debug.Log("is this happening");
				count = count + 1;		
			}
		}
	}

	public string mouse1() {
		//mouse1Position = Input.mousePosition;
		//return mouse1Position;
		return clicked;
	}

	public string mouse2() {
		//mouse2Position = Input.mousePosition;
		//return mouse2Position;
		return clicked;
	}

	public int getCount() {
		return count;
	}

	void OnMouseDown() {
		if (count == 1) {
			mouse1();
			//Debug.Log("onmouse 1 " + mouse1());
		} else {
			mouse2();
			//Debug.Log("onmouse 2 " + mouse2());
			count = 0;
		}
	}
}