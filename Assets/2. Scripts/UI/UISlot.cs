using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [Header("아이템")]
    public ItemInfo item;

    [Header("아이템 사진 칸")]
    public Image charImage;

    [Header("체크 표시")]
    public GameObject checkImage;

    [Header("해당 슬롯의 아이템 착용 여부")]
    public bool isEquipped;

    private void Start()
    {
        charImage.GetComponent<Image>().sprite = item.ItemImage;
        isEquipped = false;
        checkImage.SetActive(false);
    }

    public void ClickEquipment()
    {
        if (!isEquipped)
        {
            isEquipped = true;
            ApplyEffect();
            checkImage.SetActive(true);
        }
        else
        {
            isEquipped = false;
            LoseEffect();
            checkImage.SetActive(false);
        }
    }
    //아이템 효과 적용
    public void ApplyEffect()
    {
        GameManager.Instance.Character.attack += item.ItemAttack;
        GameManager.Instance.Character.defense += item.ItemDefense;
        GameManager.Instance.Character.health += item.ItemHealth;
        GameManager.Instance.Character.crit += item.ItemCrit;
    }
    //아이템 효과 미적용
    public void LoseEffect()
    {
        GameManager.Instance.Character.attack -= item.ItemAttack;
        GameManager.Instance.Character.defense -= item.ItemDefense;
        GameManager.Instance.Character.health -= item.ItemHealth;
        GameManager.Instance.Character.crit -= item.ItemCrit;
    }
}
