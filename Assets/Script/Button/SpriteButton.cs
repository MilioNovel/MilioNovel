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

    [SerializeField] private CanvasGroup _canvasGroup;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log(name + "の上に来たぞ！");
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log(name + "をクリック！");
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log(name + "の上で離した！");
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log(name + "から離れた！");

    }
    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log(name + "をクリックしたやつがクリックを離した！");
    }
}