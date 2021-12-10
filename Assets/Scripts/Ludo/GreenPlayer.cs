using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPlayer : Player
{
    PathPoint[] pathPoints;

    private void Start()
    {
        PlayerColor = "green";
    }

    private void OnMouseDown()
    {

        if (GameManager.gameManager.number_got == 6)
        {
            canMove = true;
            stepsToMove = 1;
        }
        else
        {
            stepsToMove = GameManager.gameManager.number_got;
        }

        if (!canMove || GameManager.gameManager.rolled_dice != PlayerColor) { return; }
        pathPoints = GameManager.gameManager.greenPathPoints;
        GameManager.gameManager.number_got = 0;

        if (stepsToMove + alreadyMoved <= pathPoints.Length)
        {
            StartCoroutine(MoveNSteps(stepsToMove, pathPoints));
        }
    }



}
