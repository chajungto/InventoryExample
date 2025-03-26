using System.Collections.Generic;
using UnityEngine;

public class UIInventory : ButtonBehaviour
{
    [Header("UISlot의 프리팹")]
    public GameObject slot;

    [Header("아이템들 SO")]
    public List<ItemInfo> itemList;

    [Header("UISlot이 생성될 곳")]
    public GameObject content;

    [Header("UISlot 개수")]
    public int slotCount;

    [Header("인벤토리 디스플레이")]
    public RectTransform invenDisplay;

    //버튼 디스플레이의 원래 위치
    public Vector3 invenDisplayPos;

    private int maxSlotCount = 10;

    protected override void Start()
    {
        slotCount = 0;
        invenDisplayPos = invenDisplay.anchoredPosition;
        InitInventoryUI(slotCount);
    }
    //메인 메뉴 열기
    public void OpenMainMenu()
    {
        MoveDisplay(invenDisplay, invenDisplayPos, 0.5f);
        MoveDisplay(UIManager.Instance.MainMenu.buttonDisplay, UIManager.Instance.MainMenu.buttonDisplayPos, 0.5f);
    }
    //AddItem으로 충분할 거 같지만, 일단 초기화를 구현 (count에 0을 넣어서)
    void InitInventoryUI(int count)
    {
        for(int i = 0; i < count; i++)
        {
            GameObject newSlot = Instantiate(slot, content.transform);
        }
    }
    //아이템 개수가 10개이므로 10개까지만 동적 생성 가능하도록 설정 -> Additem에서 호출
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
