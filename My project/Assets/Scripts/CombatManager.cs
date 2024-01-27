using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    // this class is for creating combat situation: letters flies, player presses buttons
    public void TheCombatStarts(char[] letters) // some other parametrs can be add here as well, for eample number of the room
    {
        // letters are attacking!
    }
    // checks if he is succesful

    void Victory()
    {
        GameManager.instance.PassingLevel();
    }

    void Looser()
    {
        GameManager.instance.LoosingLevel();
    }
}
