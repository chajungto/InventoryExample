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

    public void OpenStatus()
    {
        MoveDisplay(UIManager.Instance.Status.statDisplay, buttonDisplayPos, 0.5f);
        MoveDisplay(buttonDisplay, UIManager.Instance.Status.statDisplayPos, 0.5f);
    }

    public void OpenInventory()
    {
        MoveDisplay(UIManager.Instance.Inventory.invenDisplay, buttonDisplayPos, 0.5f);
        MoveDisplay(buttonDisplay, UIManager.Instance.Inventory.invenDisplayPos, 0.5f);
    }

    protected override void MoveDisplay(RectTransform display, Vector3 vector, float time)
    {
        base.MoveDisplay(display, vector, time);
    }

    public void SetData()
    {
        Character ch = GameManager.Instance.Character;
        charNameTxt.text = ch.CharName;
        charLevelTxt.text = ch.Level.ToString();
        charDescription.text = ch.CharDescription;
        charImage.sprite = ch.CharImage;
        charExpTxt.text = ch.Experience.ToString();
        charMaxExpTxt.text = ch.MaxExperience.ToString();

        expSlider.maxValue = ch.MaxExperience;
        expSlider.value = ch.Experience;
    }

}
