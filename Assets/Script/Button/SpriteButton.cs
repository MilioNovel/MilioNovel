using UnityEngine;
using UnityEngine.EventSystems;

public class SpriteButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    SpriteRenderer spriteRenderer;
    SpriteRenderer DefaultSprite;
    [SerializeField] Sprite HighlightedSprite;
    [SerializeField] Sprite PressedSprite;
    [SerializeField] Sprite SelectedSprite;
    void Start()
    {
       DefaultSprite = GetComponent<SpriteRenderer>();
    }
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        Debug.Log("Cursor Entering " + name + " GameObject");
    }
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        Debug.Log("Cursor Exiting " + name + " GameObject");
    }

    void Update()
    {
        //Debug.Log("<color=yellow>Yes!</color>");
    }
}
