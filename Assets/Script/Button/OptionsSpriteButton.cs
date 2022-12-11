//�e�I�u�W�F�N�g��LockCheck.cs�����Ă�������
using UnityEngine;

// Sprite�\���p
[RequireComponent(typeof(UnityEngine.SpriteRenderer))]
// ������͈͐ݒ�p
[RequireComponent(typeof(UnityEngine.PolygonCollider2D))]


public class OptionsSpriteButton : MonoBehaviour
{
    private int _spriteNumber;
    /*
     0 = default
     1 = selected
     2 = confirmed
     */
    private AnswerManagement _answerManagement;
    private SpriteRenderer _spriteR;
    private Sprite _defaultSprite;
    [SerializeField] Sprite m_highlightedSprite;
    [SerializeField] Sprite m_pressedSprite;
    [SerializeField] Sprite m_selectedSprite;
    [SerializeField] Sprite m_confirmPressedSprite;
    [SerializeField] Sprite m_confirmedSprite;
    void Start()
    {
        _spriteR = GetComponent<SpriteRenderer>();
        _defaultSprite = _spriteR.sprite;
        _answerManagement = GetComponentInParent<AnswerManagement>();
        _spriteNumber = 0;
    }
    void OnMouseEnter()
    {
        if (_answerManagement.FinalAnswer != 2 && _spriteNumber == 0)
        {
            Debug.Log("[OptionsSpriteButton] " + name + "�̏�ɗ������I");
            _spriteR.sprite = m_highlightedSprite;
        }
    }
    void OnMouseExit()
    {
        if (_spriteR.sprite == m_highlightedSprite)
        {
            Debug.Log("[OptionsSpriteButton] " + name + "���痣�ꂽ�I");
            _spriteR.sprite = _defaultSprite;
        }
    }
    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0) && _answerManagement.FinalAnswer != 2 && _answerManagement.Check(_spriteNumber, name))   // true���̂ݎ��s
        {
            if (_spriteNumber == 1)
            {
                Debug.Log("[OptionsSpriteButton] " + name + "�Ńt�@�C�i���A���T�[�H");
                _spriteR.sprite = m_confirmPressedSprite;
            }
            else
            {
                Debug.Log("[OptionsSpriteButton] " + name + "���N���b�N?");
                _spriteR.sprite = m_pressedSprite;
            }
        }
    }
    void OnMouseUpAsButton()
    {
        if (_answerManagement.FinalAnswer != 2 && _answerManagement.Check(_spriteNumber, name))
        {
            if (_spriteNumber == 1)
            {
                Debug.Log("[OptionsSpriteButton] " + name + "�Ńt�@�C�i���A���T�[�I");
                _spriteR.sprite = m_confirmedSprite;
                _answerManagement.FinalAnswer = 2;
                _spriteNumber = 2;
            }
            else
            {
                Debug.Log("[OptionsSpriteButton] " + name + "���N���b�N�I");
                _spriteR.sprite = m_selectedSprite;
                _answerManagement.FinalAnswer = 1;
                _spriteNumber = 1;
            }
        }

    }
    public void ResetSprite()
    {
        _spriteR.sprite = _defaultSprite;
        _spriteNumber = 0;
    }
}
