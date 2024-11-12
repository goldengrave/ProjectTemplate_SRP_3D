using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "GameData", menuName = "GameData", order = 0)]
public class GameData : ScriptableObject
{

    public enum GameState { Act1, Act2, Act3, Act4, Act5, Act6 };


    public GameState gameState;


}
