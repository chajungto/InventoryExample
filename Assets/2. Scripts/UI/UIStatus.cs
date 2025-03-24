using TMPro;
using UnityEngine;

public class UIStatus : ButtonBehaviour
{
    [Header("ĳ���� ���� ���÷���")]
    public RectTransform statDisplay;

    [Header("ĳ���� ���ݷ� ĭ")]
    public TextMeshProUGUI attackTxt;

    [Header("ĳ���� ���� ĭ")]
    public TextMeshProUGUI defenseTxt;

    [Header("ĳ���� ü�� ĭ")]
    public TextMeshProUGUI healthTxt;

    [Header("ĳ���� ġ��Ÿ ĭ")]
    public TextMeshProUGUI critTxt;

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

    public void SetData()
    {
        Character ch = GameManager.Instance.Character;
        attackTxt.text = ch.Attack.ToString();
        defenseTxt.text = ch.Defense.ToString();
        healthTxt.text = ch.Health.ToString();
        critTxt.text = ch.Crit.ToString();
    }
}
