using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Item", menuName = "Item", order = int.MaxValue)]

public class Item : ScriptableObject
{
    [Header("������ �̸�")]
    [SerializeField]
    private string itemName;
    public string ItemName { get { return itemName; } }

    [Header("������ ����")]
    [SerializeField]
    private Sprite itemImage;
    public Sprite ItemImage { get { return itemImage; } }

    [Header("�������� �ִ� ���ݷ�")]
    [SerializeField]
    private float itemAttack;
    public float ItemAttack { get { return itemAttack; } }

    [Header("�������� �ִ� ����")]
    [SerializeField]
    private float itemDefense;
    public float ItemDefense { get { return itemDefense; } }

    [Header("�������� �ִ� ü��")]
    [SerializeField]
    private float itemHealth;
    public float ItemHealth { get { return itemHealth; } }

    [Header("�������� �ִ� ġ��Ÿ")]
    [SerializeField]
    private float itemCrit;
    public float ItemCrit { get { return itemCrit; } }

    [Header("������ ����")]
    [SerializeField]
    private string itemDescription;
    public string ItemDescription { get { return itemDescription; } }
}
