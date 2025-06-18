using UnityEngine;

public class MetinTasiBase : MonoBehaviour
{
    public int maxHealth = 100;
    protected int currentHealth;

    protected virtual void Start()
    {
        currentHealth = maxHealth;
    }

    public virtual void TakeDamage(int damage, GameObject attacker)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die(attacker);
        }
    }

    protected virtual void Die(GameObject attacker)
    {
       
        PlayerStats stats = attacker.GetComponent<PlayerStats>();
        if (stats != null)
        {
            stats.AddXP(GetXPReward());
        }

        Destroy(gameObject);
    }

    protected virtual int GetXPReward()
    {
        return 0; 
    }
}
