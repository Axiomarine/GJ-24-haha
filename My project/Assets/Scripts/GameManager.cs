using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject enemy;

    public RoomsController roomsController;
    private Vector2 enemySpawnCoordinates = Vector2.zero;


    private void Awake()
    {
        instance = this; // creating a singleton for GameManager object with script attached to it
    }
    void Start()
    {
        InitialSetup();
    }

    void InitialSetup()
    {
        int map = 1;
        AddEnemy(enemy, enemySpawnCoordinates);
        AddBackground(map);
    }

    void AddEnemy(GameObject prefab, Vector2 spawnCoordinates)
    {
        Instantiate(prefab, spawnCoordinates, Quaternion.identity);
    }

    void AddBackground(int map)
    {
        roomsController.SetupBackground();
    }
}
