using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    //캐릭터의 초기 정보 (이후 변화하는 스텟에는 참여하지 않고 오직 초기 정보만 줌)
    public CharacterInfo cInfo;

    [Header("캐릭터 이름")]
    public string charName;

    [Header("캐릭터 이미지")]
    public Sprite charImage;

    [Header("캐릭터 설명")]
    public string charDescription;

    [Header("캐릭터 레벨")]
    public int level;

    [Header("캐릭터 경험치")]
    public int experience;

    [Header("캐릭터 최대 경험치")]
    public int maxExperience;

    [Header("공격력")]
    public float attack;

    [Header("방어력")]
    public float defense;

    [Header("체력")]
    public float health;

    [Header("치명타")]
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
