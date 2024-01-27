using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JokeManager : MonoBehaviour
{   
    private List<string> jokeType1 = new List<string> {"Joke1", "Joke2", "Joke3", "Joke4", "Joke5", "Joke6", "Joke7", "Joke8", "Joke9", "Joke10"};
    private List<string> jokeType2 = new List<string> {"Joke11", "Joke12", "Joke13", "Joke14", "Joke15", "Joke16", "Joke17", "Joke18", "Joke19", "Joke20"};
    private List<string> jokeType3 = new List<string> {"Joke21", "Joke22", "Joke23", "Joke24", "Joke25", "Joke26", "Joke27", "Joke28", "Joke29", "Joke30"};

    // this class after receiving what type of joke player chose, randomly picks one joke same type from its joke pool and returns it to the GameManager as a string, after the joke was taken it can't be used again!
    public string ChoosingJokeFromTheDatabase(int jokeType)
    {
        string joke = "";
        int index;
        switch(jokeType)
        {
            case 1:
                index = Random.Range(0, jokeType1.Count);
                joke = jokeType1[index];
                jokeType1.RemoveAt(index);
                break;
            case 2:
                index = Random.Range(0, jokeType2.Count);
                joke = jokeType2[index];
                jokeType2.RemoveAt(index);
                break;
            case 3:
                index = Random.Range(0, jokeType3.Count);
                joke = jokeType3[index];
                jokeType3.RemoveAt(index);
                break;
            default:
                Debug.Log("Invalid joke type");
                break;
        }
        return joke;
    }
}
