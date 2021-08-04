using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler: MonoBehaviour
{

    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("GameHandler.Start");
        Puzzle puzzle = PuzzleFactory.Create("test-image", 36);

        //make the puzzle object a child of GameHandler
        puzzle.transform.parent = gameObject.transform;

        //move the puzzle object 
        puzzle.transform.localPosition = new Vector2(10, 10);
        
    }

    // Update is called once per frame
    private void Update()
    {
        //Debug.Log("GameHandler.Update");
    }
}
