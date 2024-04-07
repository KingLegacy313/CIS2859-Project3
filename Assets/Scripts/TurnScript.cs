using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnScript : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    GameObject board;
    public Sprite[] images;
    bool unplayed = true;
    public int index;

    private void Start()
    {
        spriteRenderer.sprite = null;
    }

    private void OnMouseDown()
    {
        if (unplayed)
        {
            index = board.GetComponent<GameController>().PlayerTurn();
            spriteRenderer.sprite = images[index];
            unplayed = false;
        }

    }


    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        board = GameObject.Find("Board");
    }
}
