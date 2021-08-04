using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzlePiece : MonoBehaviour
{
    private Image image;

    PuzzlePiece(Image image)
    {
        this.image = image;
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Piece initialized.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
