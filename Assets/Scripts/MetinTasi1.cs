using UnityEngine;

public class MetinTasi1 : MetinTasiBase
{
    public int experienceReward = 10;

    protected override void Start()
    {
        maxHealth = 100; 
        base.Start();
    }

    protected override void Die(GameObject attacker)
    {
        base.Die(attacker); 
        Debug.Log("Level 1 Metin Taþý yok oldu. XP ver: " + experienceReward);
       
    }

    protected override int GetXPReward()
    {
        return 15;
    }
}
