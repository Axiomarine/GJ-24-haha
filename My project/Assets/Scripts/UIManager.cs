using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameManager gameManager;
    public Button jokeButton1;
    public Button jokeButton2;
    public Button jokeButton3;

    void Start()
    {
        // Add onClick listeners to the joke buttons
        jokeButton1.onClick.AddListener(() => ChooseJoke(1));
        jokeButton2.onClick.AddListener(() => ChooseJoke(2));
        jokeButton3.onClick.AddListener(() => ChooseJoke(3));
    }

    void ChooseJoke(int jokeIndex)
    {
        GameManager.instance.WhatButton(jokeIndex);
    }
}
