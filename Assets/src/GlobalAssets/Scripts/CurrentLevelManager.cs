using UnityEngine;

public class CurrentLevelManager : MonoBehaviour
{
    public int health = 100;
    public int[] enemies = {};
    public LevelData currentLevel;

    void Awake()
    {
        LoadLevel();
    }


    public void LoadLevel()
    {
        currentLevel = LevelDataStore.GetLevel();
        health = currentLevel.initialHealth;
        enemies = currentLevel.enemyTypes;
    }

    public void ResetLevelLevel()
    {
        GlobalVariables.selected_level = 0;
        health = 100;
        enemies = new int[] {};
        currentLevel = null;
    }
}
