using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class HeaderExample : MonoBehaviour
{
    [Header("Health settings")]
    [Range(0, 100f)]
    public int health;
    [Min(0)]public int maxHealth;
    [Space(10)]
    public int shield; 
    public int maxShield;

    [Header("Damage settings")]
    [SerializeField] private int damage;

    [Header("array")]
    public RoomType[][] array = new RoomType[5][];

    private void Start()
    {
        Direction d = (Direction)Random.Range(0, 4);
        if (d == Direction.North)
        {

        }

        for (int i = 0; i < 5; i++)
        {

        }
    }
}

public enum RoomType
{
    Empty=0,
    Kitchen,
    LivingRoom,
    Bedroom,
    Bathroom
}

public struct RoomData
{
    Direction direction;
    public int prefabIndex;
}
public enum Direction
{
    North=0,
    South=1,
    East,
    West
}