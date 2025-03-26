using DG.Tweening;
using UnityEngine;

public abstract class ButtonBehaviour : MonoBehaviour
{
    protected virtual void Start() { }
    //패널 움직이는 효과
    protected virtual void MoveDisplay(RectTransform display, Vector3 vector, float time)
    {
        display.DOAnchorPos(vector, time).SetEase(Ease.Linear);
    }
}
