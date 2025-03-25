using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : ButtonBehaviour
{
    [Header("��ư ���÷���")]
    public RectTransform buttonDisplay;

    [Header("ĳ���� �̸� ĭ")]
    public TextMeshProUGUI charNameTxt;

    [Header("ĳ���� ���� ĭ")]
    public TextMeshProUGUI charLevelTxt;

    [Header("ĳ���� ����ġ ĭ")]
    public TextMeshProUGUI charExpTxt;

    [Header("ĳ���� ����ġ �ִ�ġ ĭ")]
    public TextMeshProUGUI charMaxExpTxt;

    [Header("ĳ���� ���� ĭ")]
    public TextMeshProUGUI charDescription;

    [Header("ĳ���� ���� ĭ")]
    public Image charImage;

    [Header("����ġ �����̴�")]
    public Slider expSlider;


    //��ư ���÷����� ���� ��ġ
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
