using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int currentXP = 0;

    public void AddXP(int xpAmount)
    {
        currentXP += xpAmount;
        Debug.Log("XP kazan�ld�: " + xpAmount + "  Toplam XP: " + currentXP);
    }
}
