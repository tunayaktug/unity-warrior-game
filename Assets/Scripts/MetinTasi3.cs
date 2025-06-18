using UnityEngine;
public class MetinTasi3 : MetinTasiBase
{
    public int experienceReward = 30;

    protected override void Start()
    {
        maxHealth = 300;
        base.Start();
    }

    protected override void Die(GameObject attacker)
    {
        base.Die(attacker);
        Debug.Log("Level 3 Metin Taþý yok oldu. XP ver: " + experienceReward);
    }

    protected override int GetXPReward()
    {
        return 25;
    }
}
