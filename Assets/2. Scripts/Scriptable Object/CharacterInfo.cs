using UnityEngine;

[CreateAssetMenu(fileName = "CharacterInfo", menuName = "CharacterInfo", order = int.MaxValue)]

public class CharacterInfo : ScriptableObject
{
    [Header("ĳ���� �̸�")]
    [SerializeField]
    private string charName;
    public string CharName { get { return charName; } }

    [Header("ĳ���� �̹���")]
    [SerializeField]
    private Sprite charImage;
    public Sprite CharImage { get { return charImage; } }

    [Header("ĳ���� ����")]
    [SerializeField]
    private string charDescription;
    public string CharDescription { get { return charDescription; } }

    [Header("ĳ���� ����")]
    [SerializeField]
    private int level;
    public int Level { get { return level; } }

    [Header("ĳ���� ����ġ")]
    [SerializeField]
    private int experience;
    public int Experience { get { return experience; } }

    [Header("ĳ���� �ִ� ����ġ")]
    [SerializeField]
    private int maxExperience;
    public int MaxExperience { get { return maxExperience; } }

    [Header("���ݷ�")]
    [SerializeField]
    private float attack;
    public float Attack { get { return attack; } }

    [Header("����")]
    [SerializeField]
    private float defense;
    public float Defense { get { return defense; } }

    [Header("ü��")]
    [SerializeField]
    private float health;
    public float Health { get { return health; } }

    [Header("ġ��Ÿ")]
    [SerializeField]
    private float crit;
    public float Crit { get { return crit; } }
}
