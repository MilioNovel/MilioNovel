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
        Debug.Log(name + "�̏�ɗ������I");
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log(name + "���N���b�N�I");
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log(name + "�̏�ŗ������I");
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log(name + "���痣�ꂽ�I");

    }
    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log(name + "���N���b�N��������N���b�N�𗣂����I");
    }
}