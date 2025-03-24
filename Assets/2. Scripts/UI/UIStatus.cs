using UnityEngine;

public class UIStatus : ButtonBehaviour
{
    [Header("ĳ���� ���� ���÷���")]
    public RectTransform statDisplay;

    //ĳ���� ���� ���÷����� ���� ��ġ
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
