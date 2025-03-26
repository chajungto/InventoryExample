using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [Header("������")]
    public ItemInfo item;

    [Header("������ ���� ĭ")]
    public Image charImage;

    [Header("üũ ǥ��")]
    public GameObject checkImage;

    [Header("�ش� ������ ������ ���� ����")]
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
    //������ ȿ�� ����
    public void ApplyEffect()
    {
        GameManager.Instance.Character.attack += item.ItemAttack;
        GameManager.Instance.Character.defense += item.ItemDefense;
        GameManager.Instance.Character.health += item.ItemHealth;
        GameManager.Instance.Character.crit += item.ItemCrit;
    }
    //������ ȿ�� ������
    public void LoseEffect()
    {
        GameManager.Instance.Character.attack -= item.ItemAttack;
        GameManager.Instance.Character.defense -= item.ItemDefense;
        GameManager.Instance.Character.health -= item.ItemHealth;
        GameManager.Instance.Character.crit -= item.ItemCrit;
    }
}
