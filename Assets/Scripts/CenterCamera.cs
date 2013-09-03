using UnityEngine;
using System.Collections;

public class CenterCamera : MonoBehaviour {

	/*************************
	 * This script centers the camera depending on the size of the grid
	 * ***********************/

	public GridManager gridManager;
	// Use this for initialization
	void Awake () {
		this.transform.position = new Vector3( gridManager.GetCenterPosition().x, gridManager.GetCenterPosition().y, -20);

		//TODO: Make it so z axis changes with size of grid
	}

}
