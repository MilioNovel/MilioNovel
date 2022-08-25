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
        Debug.Log(name + "�̏�ɗ������I");
    }
    public void OnPointerDown(PointerEventData pointerEventData)
    {
        if (pointerEventData.button == PointerEventData.InputButton.Left)
        {
            Debug.Log(name + "���N���b�N�I");
        }
    }
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        if (pointerEventData.button == PointerEventData.InputButton.Left)
        {
            Debug.Log(name + "�̏�ŗ������I");
        }
    }
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        Debug.Log(name + "���痣�ꂽ�I");

    }
    public void OnPointerUp(PointerEventData pointerEventData)
    {
        if (pointerEventData.button == PointerEventData.InputButton.Left)
        {
            Debug.Log(name + "���N���b�N��������N���b�N�𗣂����I");
        }
    }
}