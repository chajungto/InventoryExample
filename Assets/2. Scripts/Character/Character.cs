using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    //ĳ������ �ʱ� ���� (���� ��ȭ�ϴ� ���ݿ��� �������� �ʰ� ���� �ʱ� ������ ��)
    public CharacterInfo cInfo;

    [Header("ĳ���� �̸�")]
    public string charName;

    [Header("ĳ���� �̹���")]
    public Sprite charImage;

    [Header("ĳ���� ����")]
    public string charDescription;

    [Header("ĳ���� ����")]
    public int level;

    [Header("ĳ���� ����ġ")]
    public int experience;

    [Header("ĳ���� �ִ� ����ġ")]
    public int maxExperience;

    [Header("���ݷ�")]
    public float attack;

    [Header("����")]
    public float defense;

    [Header("ü��")]
    public float health;

    [Header("ġ��Ÿ")]
    public float crit;

    public List<ItemInfo> inventory;

    private void Awake()
    {
        charName = cInfo.CharName;
        charImage = cInfo.CharImage;
        charDescription = cInfo.CharDescription;
        level = cInfo.Level;
        experience = cInfo.Experience;
        maxExperience = cInfo.MaxExperience;
        attack = cInfo.Attack;
        defense = cInfo.Defense;
        health = cInfo.Health;
        crit = cInfo.Crit;

        inventory = new List<ItemInfo>();
    }

    public void AddItem()
    {
        inventory.Add(UIManager.Instance.Inventory.NewItem());
    }
}
