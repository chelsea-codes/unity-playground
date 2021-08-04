using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleFactory : GameObjectFactory<Puzzle>
{
    public static Puzzle Create(string imageFilePath, int numberOfPieces)
    {
        Puzzle puzzle = GameObjectFactory<Puzzle>.Create();
        puzzle.name = "Puzzle";
        puzzle.ImageFilePath = imageFilePath;
        puzzle.NumberOfPieces = numberOfPieces;
        puzzle.PuzzlePieces = new List<PuzzlePiece>();
        return puzzle;
    }

}
