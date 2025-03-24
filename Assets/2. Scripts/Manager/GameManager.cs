using System;
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

        SetData();
    }

    void SetData()
    {
        UIManager.MainMenu.SetData();
    }

}
