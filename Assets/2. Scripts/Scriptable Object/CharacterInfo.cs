using UnityEngine;

[CreateAssetMenu(fileName = "CharacterInfo", menuName = "CharacterInfo", order = int.MaxValue)]

public class CharacterInfo : ScriptableObject
{
    [Header("캐릭터 이름")]
    [SerializeField]
    private string charName;
    public string CharName { get { return charName; } }

    [Header("캐릭터 이미지")]
    [SerializeField]
    private Sprite charImage;
    public Sprite CharImage { get { return charImage; } }

    [Header("캐릭터 설명")]
    [SerializeField]
    private string charDescription;
    public string CharDescription { get { return charDescription; } }

    [Header("캐릭터 레벨")]
    [SerializeField]
    private int level;
    public int Level { get { return level; } }

    [Header("캐릭터 경험치")]
    [SerializeField]
    private int experience;
    public int Experience { get { return experience; } }

    [Header("캐릭터 최대 경험치")]
    [SerializeField]
    private int maxExperience;
    public int MaxExperience { get { return maxExperience; } }

    [Header("공격력")]
    [SerializeField]
    private float attack;
    public float Attack { get { return attack; } }

    [Header("방어력")]
    [SerializeField]
    private float defense;
    public float Defense { get { return defense; } }

    [Header("체력")]
    [SerializeField]
    private float health;
    public float Health { get { return health; } }

    [Header("치명타")]
    [SerializeField]
    private float crit;
    public float Crit { get { return crit; } }
}
