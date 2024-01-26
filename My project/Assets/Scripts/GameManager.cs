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
        // creates first room with the first monster
        InitialSetup();
    }

    void InitialSetup()
    {
        // map index to choose from the array or whatever 
        int map = 1;
        AddEnemy(enemy, enemySpawnCoordinates);
        AddBackground(map);
    }

    void AddEnemy(GameObject prefab, Vector2 spawnCoordinates)
    {
        // just adds the enemy in the scene
        Instantiate(prefab, spawnCoordinates, Quaternion.identity);
    }

    void AddBackground(int map)
    {
        //creates a background which has the index you send
        roomsController.SetupBackground();
    }

    public void WhatButton(int but)
    {
        Debug.Log(but);
    }
}
