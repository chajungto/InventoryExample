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
    //���� �޴� ����
    public void OpenMainMenu()
    {
        MoveDisplay(statDisplay, statDisplayPos, 0.5f);
        MoveDisplay(UIManager.Instance.MainMenu.buttonDisplay, UIManager.Instance.MainMenu.buttonDisplayPos, 0.5f);
    }
    //������ ����
    public void SetData()
    {
        Character ch = GameManager.Instance.Character;
        attackTxt.text = ch.attack.ToString();
        defenseTxt.text = ch.defense.ToString();
        healthTxt.text = ch.health.ToString();
        critTxt.text = ch.crit.ToString();
    }
}
