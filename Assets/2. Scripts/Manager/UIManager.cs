using UnityEngine;

public class UIManager :Singleton<UIManager>
{
    [Header("UIMainMenu")]
    [SerializeField]
    private UIMainMenu UIMainMenu;
    public UIMainMenu MainMenu { get { return UIMainMenu; } }

    [Header("UIStatus")]
    [SerializeField]
    private UIStatus UIStatus;
    public UIStatus Status { get { return UIStatus; } }

    [Header("UIInventory")]
    [SerializeField]
    private UIInventory UIInventory;
    public UIInventory Inventory { get { return UIInventory; } }

    private void Awake()
    {
        if (_instance != null && _instance != (this as UIManager))
        {
            Destroy(gameObject);
            return;
        }

        _instance = this;
    }
}
