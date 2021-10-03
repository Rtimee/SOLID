using UnityEngine;

[CreateAssetMenu(fileName = "Player Status", menuName = "Player Status")]
public class PlayerStatus : ScriptableObject
{
    public int maxHp;
    public int currentHp;
    public int armor;
    public int speed;
    public int bulletCount;
}
