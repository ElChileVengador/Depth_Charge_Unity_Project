using UnityEngine;
using System.Collections;

public class GridManager : MonoBehaviour {

	/****************
	 * This method is in charge of creating the grid and storing
	 * the position of each cell
	 * **************/

	/// <summary>
	/// The horizontal & vertical grid size.
	/// </summary>
	public int numOfColumns;
	public int numOfRows;

	/// <summary>
	/// The space between cells; it is the same for columns and rows
	/// </summary>
	public float spaceBetweenCells;

	// a 2d array that contains all the cells
	private Vector3[ , ] cells;

	//what is the depth of the grid in the scene space
	private float zDepth;

	// Use this for initialization
	void Awake () {
		CreateGrid();
		zDepth = 0;
	}

	void CreateGrid()
	{
		//initialize grid
		cells = new Vector3[numOfColumns, numOfRows];

		//populate grid
		for(int i = 0; i < numOfColumns; i++){
			for(int j = 0; j < numOfRows; j ++){
			
				cells[i,j] = new Vector3( i * spaceBetweenCells, j * spaceBetweenCells, zDepth);

			}//end for numOfRows
		}//end for numOfColumns
	}//end Create Grid


	void OnDrawGizmos()
	{
		if(cells != null)
		{
			Gizmos.color = Color.magenta;
			for(int i = 0; i < numOfColumns; i++){
				for(int j = 0; j < numOfRows; j ++){
					//draw 1-radius shperes on each node
					Gizmos.DrawWireSphere( cells[i,j], 1);
				}//end for numOfRows
			}//end for numOfColumns
		}//end if
	}//end OnDrawGizmos


	public Vector2 GetCenterPosition()
	{
		return new Vector2( spaceBetweenCells * (numOfColumns - 1)  / 2, spaceBetweenCells * (numOfRows - 1)  /2);
	
	}//end getCenterPosition
}
