using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class LineLibrary : MonoBehaviour, IEquatable<LineLibrary> {

	private Line lineScript;
	private List<Line> lineList;
	private GameObject line;
	
	void Awake() {
		//imports Line.cs from GameObject line.
		line = GameObject.Find("line");
		lineScript = line.GetComponent<Line>();
		lineList = new List<Line>();
	}

	/*Creates the LineLibrary*/
	public LineLibrary(List<Line> newLineList) {
		//probably wrong
		lineList = newLineList;
	}

	public bool Equals(LineLibrary other)  {
		if (other == null) {
			return false;
		}
		if (this.lineList == other.lineList) {
			return true;
		} 
		if (this.lineList.Equals(other)) {
			return true;
		}
		return false;
	}
}
