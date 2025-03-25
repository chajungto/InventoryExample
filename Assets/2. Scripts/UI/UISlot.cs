using Unity.VisualScripting;
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

    [Header("아이템 사진 칸")]
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

    public void ApplyEffect()
    {
        GameManager.Instance.Character.attack += item.ItemAttack;
        GameManager.Instance.Character.defense += item.ItemDefense;
        GameManager.Instance.Character.health += item.ItemHealth;
        GameManager.Instance.Character.crit += item.ItemCrit;
    }

    public void LoseEffect()
    {
        GameManager.Instance.Character.attack -= item.ItemAttack;
        GameManager.Instance.Character.defense -= item.ItemDefense;
        GameManager.Instance.Character.health -= item.ItemHealth;
        GameManager.Instance.Character.crit -= item.ItemCrit;
    }

    //public void UnEquip()
    //{
    //    if (isEquipped)
    //    {
    //        isEquipped = false;
    //        checkImage.SetActive(false);
    //    }
    //}
}
