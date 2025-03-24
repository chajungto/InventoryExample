using TMPro;
using UnityEngine;

public class UIStatus : ButtonBehaviour
{
    [Header("캐릭터 스탯 디스플레이")]
    public RectTransform statDisplay;

    [Header("캐릭터 공격력 칸")]
    public TextMeshProUGUI attackTxt;

    [Header("캐릭터 방어력 칸")]
    public TextMeshProUGUI defenseTxt;

    [Header("캐릭터 체력 칸")]
    public TextMeshProUGUI healthTxt;

    [Header("캐릭터 치명타 칸")]
    public TextMeshProUGUI critTxt;

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

    public void SetData()
    {
        Character ch = GameManager.Instance.Character;
        attackTxt.text = ch.Attack.ToString();
        defenseTxt.text = ch.Defense.ToString();
        healthTxt.text = ch.Health.ToString();
        critTxt.text = ch.Crit.ToString();
    }
}
