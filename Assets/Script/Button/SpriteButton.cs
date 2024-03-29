using UnityEngine;

// Sprite表示用
[RequireComponent(typeof(UnityEngine.RectTransform))]
[RequireComponent(typeof(UnityEngine.SpriteRenderer))]
// 当たり範囲設定用
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
        Debug.Log("[SpriteButton] " + name + "の上に来たぞ！");
        _spriteR.sprite = m_highlightedSprite;
    }
     void OnMouseExit()
    {
        if (_spriteR.sprite == m_highlightedSprite)
        {
            Debug.Log("[SpriteButton] " + name + "から離れた！");
            _spriteR.sprite = _defaultSprite;
        }
    }
    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("[SpriteButton] " + name + "をクリック！");
            _spriteR.sprite = m_pressedSprite;
        }
    }
    void OnMouseUpAsButton()
    {
        Debug.Log("[SpriteButton] " + name + "の上で離した！");
        _spriteR.sprite = m_selectedSprite;
    }
}
