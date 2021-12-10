using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlayer : Player
{
    PathPoint[] pathPoints;

    private void Start()
    {
        PlayerColor = "red";
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
        pathPoints = GameManager.gameManager.redPathPoints;
        GameManager.gameManager.number_got = 0;

        if (stepsToMove + alreadyMoved <= pathPoints.Length)
        {
            StartCoroutine(MoveNSteps(stepsToMove, pathPoints));
        }
    }



}
