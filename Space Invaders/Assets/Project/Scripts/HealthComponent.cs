using System;
using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    [SerializeField]
    private float _maxHealth;

    [SerializeField]
    private float _startingHealth;

    public float Health { get; private set; }

    public bool IsDead { get; private set; }

    // Broadcast health
    public Action<float> OnHealthChanged;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Health = Mathf.Min(_startingHealth, _maxHealth);
        IsDead = Health <= 0f;
    }

    public void dealDamage(float amount)
    {
        float newHealth = Mathf.Clamp(Health - amount, 0, _maxHealth);
        if (newHealth != Health)
        {
            Health = newHealth;
            IsDead = Health == 0f;
            OnHealthChanged?.Invoke(Health);
        }
    }

    public void giveHealth(float amount)
    {
        if (!IsDead)
        {
            float newHealth = Mathf.Clamp(Health + amount, 0, _maxHealth);
            if (newHealth != Health)
            {
                Health = newHealth;
                OnHealthChanged?.Invoke(Health);
            }
        }
    }
}
