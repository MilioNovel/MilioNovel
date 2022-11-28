//�e�I�u�W�F�N�g��LockCheck.cs�����Ă�������
using UnityEngine;

[RequireComponent(typeof(UnityEngine.SpriteRenderer))]
[RequireComponent(typeof(UnityEngine.PolygonCollider2D))]

public class OptionsSpriteButton : MonoBehaviour
{
    private SpriteRenderer spriteR;
    private Sprite defaultSprite;
    private LockCheck lockCheck;
    [SerializeField] private Sprite highlightedSprite;
    [SerializeField] private Sprite pressedSprite;
    [SerializeField] private Sprite selectedSprite;
    [SerializeField] private Sprite confirmPressedSprite;
    [SerializeField] private Sprite confirmedSprite;
    private void Start()
    {
        spriteR = GetComponent<SpriteRenderer>();
        defaultSprite = spriteR.sprite;
        lockCheck = GetComponentInParent<LockCheck>();
    }
    private void OnMouseEnter()
    {
        if (spriteR.sprite != selectedSprite && lockCheck.FinalAnswer == false)
        {
            Debug.Log(name + "�̏�ɗ������I");
            spriteR.sprite = highlightedSprite;
        }
    }
    private void OnMouseExit()
    {
        if (lockCheck.FinalAnswer == false)
        {
            Debug.Log(name + "���痣�ꂽ�I");
            spriteR.sprite = defaultSprite;
        }
    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (lockCheck.FinalAnswer == false)
            {
                Debug.Log(name + "���N���b�N�I");
                spriteR.sprite = pressedSprite;
            }
            else if(spriteR.sprite == selectedSprite)
            {
                spriteR.sprite = confirmPressedSprite;
            }
        }
    }
    private void OnMouseUpAsButton()
    {
        if (lockCheck.FinalAnswer == false)
        {
            Debug.Log(name + "�̏�ŗ������I");
            spriteR.sprite = selectedSprite;
            lockCheck.FinalAnswer = true;
        }
        else if (spriteR.sprite == confirmPressedSprite)
        {
            spriteR.sprite = confirmedSprite;
        }
    }
}
