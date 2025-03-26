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
    //메인 메뉴 열기
    public void OpenMainMenu()
    {
        MoveDisplay(statDisplay, statDisplayPos, 0.5f);
        MoveDisplay(UIManager.Instance.MainMenu.buttonDisplay, UIManager.Instance.MainMenu.buttonDisplayPos, 0.5f);
    }
    //데이터 설정
    public void SetData()
    {
        Character ch = GameManager.Instance.Character;
        attackTxt.text = ch.attack.ToString();
        defenseTxt.text = ch.defense.ToString();
        healthTxt.text = ch.health.ToString();
        critTxt.text = ch.crit.ToString();
    }
}
