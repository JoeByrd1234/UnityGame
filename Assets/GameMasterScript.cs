using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMasterScript : MonoBehaviour {
    
    public GameObject squarePrefab;

    public int GRID_SIZE = 5;

    public float SIDE_LENGTH = 1;

	void Start () {
		Debug.Log("Game Master init...");

        GameObject[,] grid = generateRandomGrid(GRID_SIZE);
        displayGrid(grid);
	}
	
	void Update () {

	}

    /*
     * Generates a random grid of variable size.
     * */
     GameObject[,] generateRandomGrid(int gridSize) {
        GameObject[,] newGrid = new GameObject[gridSize, gridSize];

        for (int r = 0; r < gridSize; r++) {
            for (int c = 0; c < gridSize; c++) {
                // Calling our method below to get a random square
                newGrid[r,c] = generateRandomSquare();
            }
        }

        return newGrid;
    }

    /*
     * When we generate random grids, we need to generate random squares
     * as well. This method shows how this can be done at runtime.
     * */
    GameObject generateRandomSquare() {
        // The square we return is spawned with the "Instantiate" method
        // It accepts a prefab (linked in the editor), a Vector3 for position, and a rotation description
        GameObject ret = Instantiate(squarePrefab, new Vector3(), Quaternion.identity);
        ret.GetComponent<SpriteRenderer>().color = new Color(Random.value, Random.value, Random.value);
        return ret;
    }

    /*
     * Displays the grid by placing all the squares in their rightful
     * locations.
     * */
    void displayGrid(GameObject[,] grid) {
        for (int r = 0; r < GRID_SIZE; r++) {
            for (int c = 0; c < GRID_SIZE; c++) {
                grid[r,c].transform.position = new Vector3(c * SIDE_LENGTH, -r * SIDE_LENGTH, 0);
            }
        }
    }
}
