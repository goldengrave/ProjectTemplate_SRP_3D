using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "PlayerData", menuName = "PlayerData", order = 0)]

public class PlayerData : ScriptableObject
{
    public string playerName;
    public int health;
    public int level;

    public UnityAction<int> updateHealth, updateLevel;


    public void SetHealth(int amt, bool increment = true)
    {
        //Either increment the health up and down, or set it
        if (increment)
            health += amt;
        else
            health = amt;

        //Call the Unity Action 
        if (updateHealth != null)
            updateHealth(amt);
    }

    public void SetLevel(int amt, bool increment = true)
    {
        //Either increment the level up and down, or set it
        if (increment)
            level += amt;
        else
            level = amt;

        //Call the Unity Action 
        if (updateLevel != null)
            updateLevel(amt);
    }

}
