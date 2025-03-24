using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventory : ButtonBehaviour
{
    [Header("�κ��丮 ���÷���")]
    public RectTransform invenDisplay;

    //��ư ���÷����� ���� ��ġ
    public Vector3 invenDisplayPos;

    protected override void Start()
    {
        invenDisplayPos = invenDisplay.anchoredPosition;
    }

    public void OpenMainMenu()
    {
        MoveDisplay(invenDisplay, invenDisplayPos, 0.5f);
        MoveDisplay(UIManager.Instance.MainMenu.buttonDisplay, UIManager.Instance.MainMenu.buttonDisplayPos, 0.5f);
    }

    protected override void MoveDisplay(RectTransform display, Vector3 vector, float time)
    {
        base.MoveDisplay(display, vector, time);
    }
}
