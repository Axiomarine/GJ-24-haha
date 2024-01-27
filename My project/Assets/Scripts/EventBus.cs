using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventBus : MonoBehaviour
{
    public static EventBus current;
    private void Awake()
    {
        current = this;
    }

    // scores
    public event Action<int> AddScore;
    // scenes
    public event Action NextRoom;
    // monmsters
    public event Action NextMonstr;
    //health
    public event Action<int> RemoveHelth;
    //damage
    public event Action<int> Damage;
    // Vitory and loss
    public event Action Victory;
    public event Action Loss;
}
