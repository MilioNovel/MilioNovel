using UnityEngine;

// Sprite�\���p
[RequireComponent(typeof(UnityEngine.RectTransform))]
[RequireComponent(typeof(UnityEngine.SpriteRenderer))]
// ������͈͐ݒ�p
[RequireComponent(typeof(UnityEngine.PolygonCollider2D))]

public class SpriteButton : MonoBehaviour
{
    private SpriteRenderer _spriteR;
    private Sprite _defaultSprite;
    [SerializeField] Sprite m_highlightedSprite;
    [SerializeField] Sprite m_pressedSprite;
    [SerializeField] Sprite m_selectedSprite;
    void Start()
    {
        _spriteR = GetComponent<SpriteRenderer>();
        _defaultSprite = _spriteR.sprite;
    }
    void OnMouseEnter()
    {
        Debug.Log("[SpriteButton] " + name + "�̏�ɗ������I");
        _spriteR.sprite = m_highlightedSprite;
    }
     void OnMouseExit()
    {
        if (_spriteR.sprite == m_highlightedSprite)
        {
            Debug.Log("[SpriteButton] " + name + "���痣�ꂽ�I");
            _spriteR.sprite = _defaultSprite;
        }
    }
    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("[SpriteButton] " + name + "���N���b�N�I");
            _spriteR.sprite = m_pressedSprite;
        }
    }
    void OnMouseUpAsButton()
    {
        Debug.Log("[SpriteButton] " + name + "�̏�ŗ������I");
        _spriteR.sprite = m_selectedSprite;
    }
}
