using UnityEngine;

// Sprite�\���p
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
        Debug.Log(name + "�̏�ɗ������I");
        _spriteR.sprite = m_highlightedSprite;
    }
     void OnMouseExit()
    {
        Debug.Log(name + "���痣�ꂽ�I");
        _spriteR.sprite = _defaultSprite;
    }
    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(name + "���N���b�N�I");
            _spriteR.sprite = m_pressedSprite;
        }
    }
    void OnMouseUpAsButton()
    {
        Debug.Log(name + "�̏�ŗ������I");
        _spriteR.sprite = m_selectedSprite;
    }
}
