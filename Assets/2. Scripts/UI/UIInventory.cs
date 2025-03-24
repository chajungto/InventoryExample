using UnityEngine;

public class UIInventory : ButtonBehaviour
{
    [Header("UISlot�� ������")]
    public GameObject slot;

    //[Header("�����۵�")]

    [Header("UISlot�� ������ ��")]
    public GameObject content;

    [Header("UISlot ����")]
    public int slotCount;

    [Header("�κ��丮 ���÷���")]
    public RectTransform invenDisplay;

    //��ư ���÷����� ���� ��ġ
    public Vector3 invenDisplayPos;

    protected override void Start()
    {
        slotCount = 5;
        invenDisplayPos = invenDisplay.anchoredPosition;
        InitInventoryUI(slotCount);
    }

    public void OpenMainMenu()
    {
        MoveDisplay(invenDisplay, invenDisplayPos, 0.5f);
        MoveDisplay(UIManager.Instance.MainMenu.buttonDisplay, UIManager.Instance.MainMenu.buttonDisplayPos, 0.5f);
    }

    void InitInventoryUI(int count)
    {
        for(int i = 0; i < count; i++)
        {
            GameObject newSlot = Instantiate(slot, content.transform);
        }
    }

}
