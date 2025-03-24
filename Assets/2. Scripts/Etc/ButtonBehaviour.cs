using DG.Tweening;
using UnityEngine;

public abstract class ButtonBehaviour : MonoBehaviour
{
    protected virtual void Start() { }

    protected virtual void MoveDisplay(RectTransform display, Vector3 vector, float time)
    {
        display.DOAnchorPos(vector, time).SetEase(Ease.Linear);
    }
}
