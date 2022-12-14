using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance { set; get; }

    //Spawn levels

    //Pieces list
    public List<Piece> ramps = new List<Piece>();
    public List<Piece> longblocks = new List<Piece>();
    public List<Piece> jump = new List<Piece>();
    public List<Piece> slide = new List<Piece>();
    public List<Piece> pieces = new List<Piece>(); // All pieces in the game

    public Piece GetPiece(PieceType pt, int visualIndex)
    {
        Piece p = pieces.Find(x => x.type == pt && x.visualIndex == visualIndex && !x.gameObject.activeSelf);

        if(p == null)
        {
            GameObject go = null;
            if (pt == PieceType.ramp)
                go = ramps[visualIndex].gameObject;
            else if (pt == PieceType.longblock)
                go = longblocks[visualIndex].gameObject;
            else if (pt == PieceType.jump)
                go = jump[visualIndex].gameObject;
            else if (pt == PieceType.slide)
                go = slide[visualIndex].gameObject;

            go = Instantiate(go);
            p = go.GetComponent<Piece>();
            pieces.Add(p);
        }
        return p;
    }
}
