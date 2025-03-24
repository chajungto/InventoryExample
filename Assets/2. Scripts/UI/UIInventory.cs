using UnityEngine;

public class UIInventory : ButtonBehaviour
{
    [Header("UISlot의 프리팹")]
    public GameObject slot;

    //[Header("아이템들")]

    [Header("UISlot이 생성될 곳")]
    public GameObject content;

    [Header("UISlot 개수")]
    public int slotCount;

    [Header("인벤토리 디스플레이")]
    public RectTransform invenDisplay;

    //버튼 디스플레이의 원래 위치
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
