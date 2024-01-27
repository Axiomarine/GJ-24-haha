using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamagable
{
    public float MaxHealth { get; set; }
    public float CurrentHealth { get; set; }

    private void Start()
    {
        MaxHealth = 100f;
        CurrentHealth = MaxHealth;
        StateMachine.Initialize(IdleState);
    }

    public void Damage(float damageAmount)
    {
        CurrentHealth -= damageAmount;
        if (CurrentHealth <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
        Destroy(gameObject);
    }


    public EnemyStateMachine StateMachine { get; set; }
    public EnemyIdleState IdleState { get; set;}

    private void Awake()
    {
        StateMachine = new EnemyStateMachine();
        IdleState = new EnemyIdleState(this, StateMachine);
    }

    private void Update()
    {
        StateMachine.CurrentEnemyState.LogicUpdate();
    }

    private void FixedUpdate()
    {
        StateMachine.CurrentEnemyState.PhysicsUpdate();
    }

    private void AnimationTriggerEvent(Enemy.AnimationTriggerType triggerType)
    {
        StateMachine.CurrentEnemyState.AnimationTriggerEvent(triggerType);
    }

    public enum AnimationTriggerType
    {
        EnemyAppear,
        EnemyDamaged,
        EnemyDie
    }
}
