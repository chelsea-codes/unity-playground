using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Don't use code in constructor of MonoBehaviors because Unity uses it in a specific way that should not be overridden. See http://ilkinulas.github.io/development/unity/2016/05/30/monobehaviour-constructor.html
public class Puzzle : MonoBehaviour
{
    //SerializeField keeps the property private, but allows it to be controled through unity UI
    [SerializeField] private int numberOfPieces;
    [SerializeField] private string imageFilePath;
    [SerializeField] private List<PuzzlePiece> puzzlePieces;
    [SerializeField] private Texture2D puzzleTexture;

    public int NumberOfPieces { get => numberOfPieces; set => numberOfPieces = value; }
    public string ImageFilePath { get => imageFilePath; set => imageFilePath = value; }
    public List<PuzzlePiece> PuzzlePieces { get => puzzlePieces; set => puzzlePieces = value; }
    public Texture2D PuzzleTexture { get => PuzzleTexture; set => PuzzleTexture = value; }

    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer puzzleRenderer = this.gameObject.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
        //file path is relative to Assets/Resources folder - no file extension needed
        this.puzzleTexture = Resources.Load<Texture2D>(this.imageFilePath);
        Debug.Log("texture width: " + puzzleTexture.width);
        Sprite puzzleSprite = Sprite.Create(
            puzzleTexture,
            new Rect(0, 0, puzzleTexture.width, puzzleTexture.height),
            new Vector2(0, 0),
            100.0f,
            0,
            SpriteMeshType.FullRect
        );

        puzzleRenderer.sprite = puzzleSprite;

        //global position is the position in relation to the entire scenes
        //local position is the position in relation to the game objects 'parent' objects position
        Debug.Log(this.transform.localScale.x);

        this.CutPuzzle();
    }

    private void CutPuzzle()
    {
        double pieceCountSquareRoot = Math.Sqrt(this.numberOfPieces);
        double pieceWidth = this.puzzleTexture.width / pieceCountSquareRoot;
        double pieceHeight = this.puzzleTexture.height / pieceCountSquareRoot;

        for (double x = 0; x < this.puzzleTexture.width; x += pieceWidth)
        {
            for (double y = 0; y < this.puzzleTexture.height; y += pieceHeight)
            {
                Debug.Log("x=" + x + " y=" + y);
                Sprite pieceSprite2 = Sprite.Create(
                    this.puzzleTexture,
                    new Rect((float)x, (float)y, (float)pieceWidth, (float)pieceHeight),
                    new Vector2(0, 0),
                    100.0f,
                    0,
                    SpriteMeshType.FullRect
                );
                PuzzlePiece newPiece2 = PuzzlePieceFactory.Create(pieceSprite2);
                newPiece2.transform.parent = this.transform;
                newPiece2.transform.localPosition = new Vector2(UnityEngine.Random.Range(-10, 10), UnityEngine.Random.Range(-10, 10));
               
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
