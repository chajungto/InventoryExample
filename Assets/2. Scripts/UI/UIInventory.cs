using System.Collections.Generic;
using UnityEngine;

public class UIInventory : ButtonBehaviour
{
    [Header("UISlot�� ������")]
    public GameObject slot;

    [Header("�����۵� SO")]
    public List<ItemInfo> itemList;

    [Header("UISlot�� ������ ��")]
    public GameObject content;

    [Header("UISlot ����")]
    public int slotCount;

    [Header("�κ��丮 ���÷���")]
    public RectTransform invenDisplay;

    //��ư ���÷����� ���� ��ġ
    public Vector3 invenDisplayPos;

    private int maxSlotCount = 10;

    protected override void Start()
    {
        slotCount = 0;
        invenDisplayPos = invenDisplay.anchoredPosition;
        InitInventoryUI(slotCount);
    }
    //���� �޴� ����
    public void OpenMainMenu()
    {
        MoveDisplay(invenDisplay, invenDisplayPos, 0.5f);
        MoveDisplay(UIManager.Instance.MainMenu.buttonDisplay, UIManager.Instance.MainMenu.buttonDisplayPos, 0.5f);
    }
    //AddItem���� ����� �� ������, �ϴ� �ʱ�ȭ�� ���� (count�� 0�� �־)
    void InitInventoryUI(int count)
    {
        for(int i = 0; i < count; i++)
        {
            GameObject newSlot = Instantiate(slot, content.transform);
        }
    }
    //������ ������ 10���̹Ƿ� 10�������� ���� ���� �����ϵ��� ���� -> Additem���� ȣ��
    public ItemInfo NewItem()
    {
        if (slotCount >= maxSlotCount) return null;

        ItemInfo reutrnItem = itemList[slotCount];
        slot.GetComponent<UISlot>().item = reutrnItem;
        Instantiate(slot, content.transform);
        slotCount++;
        return reutrnItem;
    }


}
