using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    public bool canRoll;
    public int result;

    public GameObject rolling_dice;

    public GameObject dice;
    protected SpriteRenderer spriteRenderer;


    private void OnMouseDown()
    {
        if (!canRoll) return;
        GameManager.gameManager.rolled_dice = dice.tag;
        StartCoroutine(RollDiceAndShowResult());
    }

    private IEnumerator RollDiceAndShowResult()
    {
        canRoll = false;

        dice.SetActive(false);
        rolling_dice.SetActive(true);

        GameManager.gameManager.number_got = (new System.Random()).Next(1, 7);

        yield return new WaitForSeconds(1f);

        dice.SetActive(true);
        rolling_dice.SetActive(false);
        spriteRenderer.sprite = GameManager.gameManager.diceSprites[GameManager.gameManager.number_got - 1];
        Debug.Log("end");

        canRoll = true;
    }


}
