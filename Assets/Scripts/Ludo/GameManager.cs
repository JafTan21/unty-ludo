using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public PathPoint[] bluePathPoints;
    public PathPoint[] yellowPathPoints;
    public PathPoint[] greenPathPoints;
    public PathPoint[] redPathPoints;
    public int number_got = 0;
    public string rolled_dice;
    public Sprite[] diceSprites;


    public static GameManager gameManager;

    private void Awake()
    {
        if (!gameManager)
            gameManager = this;
    }
}
