using UnityEngine;
public class MetinTasi2 : MetinTasiBase
{
    public int experienceReward = 20;

    protected override void Start()
    {
        maxHealth = 200;
        base.Start();
    }

    protected override void Die(GameObject attacker)
    {
        base.Die(attacker);
        Debug.Log("Level 2 Metin Taþý yok oldu. XP ver: " + experienceReward);
    }

    protected override int GetXPReward()
    {
        return 20;
    }
}
