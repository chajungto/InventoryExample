using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Item", menuName = "Item", order = int.MaxValue)]

public class Item : ScriptableObject
{
    [Header("아이템 이름")]
    [SerializeField]
    private string itemName;
    public string ItemName { get { return itemName; } }

    [Header("아이템 사진")]
    [SerializeField]
    private Sprite itemImage;
    public Sprite ItemImage { get { return itemImage; } }

    [Header("아이템이 주는 공격력")]
    [SerializeField]
    private float itemAttack;
    public float ItemAttack { get { return itemAttack; } }

    [Header("아이템이 주는 방어력")]
    [SerializeField]
    private float itemDefense;
    public float ItemDefense { get { return itemDefense; } }

    [Header("아이템이 주는 체력")]
    [SerializeField]
    private float itemHealth;
    public float ItemHealth { get { return itemHealth; } }

    [Header("아이템이 주는 치명타")]
    [SerializeField]
    private float itemCrit;
    public float ItemCrit { get { return itemCrit; } }

    [Header("아이템 설명")]
    [SerializeField]
    private string itemDescription;
    public string ItemDescription { get { return itemDescription; } }
}
