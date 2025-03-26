using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField]
    private Character character;
    public Character Character { get { return character; } }

    [SerializeField]
    private UIManager UIManager;
    
    private void Awake()
    {
        if (_instance != null && _instance != (this as GameManager))
        {
            Destroy(gameObject);
            return;
        }

        _instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        SetData();
    }
    //데이터 설정
    void SetData()
    {
        UIManager.MainMenu.SetData();
        UIManager.Status.SetData();
    }

}
