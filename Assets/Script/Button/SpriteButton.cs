using UnityEngine;
using UnityEngine.EventSystems;

public class SpriteButton : MonoBehaviour,
    IPointerEnterHandler,
    IPointerClickHandler,
    IPointerDownHandler,
    IPointerExitHandler,
    IPointerUpHandler
{
    public System.Action onClickCallback;

    [SerializeField] private Sprite YEAS;

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        Debug.Log(name + "の上に来たぞ！");
    }
    public void OnPointerDown(PointerEventData pointerEventData)
    {
        if (pointerEventData.button == PointerEventData.InputButton.Left)
        {
            Debug.Log(name + "をクリック！");
        }
    }
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        if (pointerEventData.button == PointerEventData.InputButton.Left)
        {
            Debug.Log(name + "の上で離した！");
        }
    }
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        Debug.Log(name + "から離れた！");

    }
    public void OnPointerUp(PointerEventData pointerEventData)
    {
        if (pointerEventData.button == PointerEventData.InputButton.Left)
        {
            Debug.Log(name + "をクリックしたやつがクリックを離した！");
        }
    }
}