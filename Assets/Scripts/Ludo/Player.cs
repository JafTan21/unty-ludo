using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool canMove;
    public int stepsToMove;
    public int alreadyMoved = 0;
    public string PlayerColor;

    public IEnumerator MoveNSteps(int n, PathPoint[] pathPoints)
    {
        for (int i = alreadyMoved; i < alreadyMoved + n; i++)
        {
            yield return new WaitForSeconds(0.20f);
            transform.position = pathPoints[i].transform.position;
            Debug.Log("pos changed");
        }
        alreadyMoved = alreadyMoved + n;
    }
}
