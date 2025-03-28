using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : ButtonBehaviour
{
    [Header("버튼 디스플레이")]
    public RectTransform buttonDisplay;

    [Header("캐릭터 이름 칸")]
    public TextMeshProUGUI charNameTxt;

    [Header("캐릭터 레벨 칸")]
    public TextMeshProUGUI charLevelTxt;

    [Header("캐릭터 경험치 칸")]
    public TextMeshProUGUI charExpTxt;

    [Header("캐릭터 경험치 최대치 칸")]
    public TextMeshProUGUI charMaxExpTxt;

    [Header("캐릭터 설명 칸")]
    public TextMeshProUGUI charDescription;

    [Header("캐릭터 사진 칸")]
    public Image charImage;

    [Header("경험치 슬라이더")]
    public Slider expSlider;


    //버튼 디스플레이의 원래 위치
    public Vector3 buttonDisplayPos;

    protected override void Start()
    {
        buttonDisplayPos = buttonDisplay.anchoredPosition;
    }

    //스탯 창 열기
    public void OpenStatus()
    {
        MoveDisplay(UIManager.Instance.Status.statDisplay, buttonDisplayPos, 0.5f);
        MoveDisplay(buttonDisplay, UIManager.Instance.Status.statDisplayPos, 0.5f);
    }

    //인벤토리 열기
    public void OpenInventory()
    {
        MoveDisplay(UIManager.Instance.Inventory.invenDisplay, buttonDisplayPos, 0.5f);
        MoveDisplay(buttonDisplay, UIManager.Instance.Inventory.invenDisplayPos, 0.5f);
    }

    //데이터 설정
    public void SetData()
    {
        Character ch = GameManager.Instance.Character;
        charNameTxt.text = ch.charName;
        charLevelTxt.text = ch.level.ToString();
        charDescription.text = ch.charDescription;
        charImage.sprite = ch.charImage;
        charExpTxt.text = ch.experience.ToString();
        charMaxExpTxt.text = ch.maxExperience.ToString();

        expSlider.maxValue = ch.maxExperience;
        expSlider.value = ch.experience;
    }
}
