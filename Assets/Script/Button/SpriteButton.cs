using UnityEngine;

[RequireComponent(typeof(UnityEngine.SpriteRenderer))]
[RequireComponent(typeof(UnityEngine.PolygonCollider2D))]

public class SpriteButton : MonoBehaviour
{
    private SpriteRenderer spriteR;
    private Sprite DefaultSprite;
    [SerializeField] private Sprite HighlightedSprite;
    [SerializeField] private Sprite PressedSprite;
    [SerializeField] private Sprite SelectedSprite;
    private void Start()
    {
        spriteR = GetComponent<SpriteRenderer>();
        DefaultSprite = spriteR.sprite;
    }
    private void OnMouseEnter()
    {
        Debug.Log(name + "�̏�ɗ������I");
        spriteR.sprite = HighlightedSprite;
    }
    private void OnMouseExit()
    {
        Debug.Log(name + "���痣�ꂽ�I");
        spriteR.sprite = DefaultSprite;
    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(name + "���N���b�N�I");
            spriteR.sprite = PressedSprite;
        }
    }
    private void OnMouseUpAsButton()
    {
        Debug.Log(name + "�̏�ŗ������I");
        spriteR.sprite = SelectedSprite;
    }
}
