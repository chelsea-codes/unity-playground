using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePieceFactory : GameObjectFactory<PuzzlePiece>
{
    public static PuzzlePiece Create(Sprite pieceSprite)
    {
        PuzzlePiece puzzlePiece = GameObjectFactory<PuzzlePiece>.Create();
        puzzlePiece.name = "PuzzlePiece";
        SpriteRenderer puzzlePieceRenderer = puzzlePiece.gameObject.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
        puzzlePieceRenderer.sprite = pieceSprite;
        return puzzlePiece;
    }
}
