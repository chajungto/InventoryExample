using UnityEngine;

public class UIStatus : ButtonBehaviour
{
    [Header("캐릭터 스탯 디스플레이")]
    public RectTransform statDisplay;

    //캐릭터 스탯 디스플레이의 원래 위치
    public Vector3 statDisplayPos;

    protected override void Start()
    {
        statDisplayPos = statDisplay.anchoredPosition;
    }

    public void OpenMainMenu()
    {
        MoveDisplay(statDisplay, statDisplayPos, 0.5f);
        MoveDisplay(UIManager.Instance.MainMenu.buttonDisplay, UIManager.Instance.MainMenu.buttonDisplayPos, 0.5f);
    }

    protected override void MoveDisplay(RectTransform display, Vector3 vector, float time)
    {
        base.MoveDisplay(display, vector, time);
    }
}
