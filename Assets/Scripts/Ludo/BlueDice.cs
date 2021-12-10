using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueDice : Dice // nothing to do with *blue* name in the class, all dice use the same class
{
    private void Awake()
    {
        spriteRenderer = dice.GetComponent<SpriteRenderer>();
        rolling_dice.SetActive(false);
        canRoll = true;
    }

}
