using UnityEngine;

public class TestScript : MonoBehaviour
{

    //�}�E�X���������
    void OnMouseEnter()
    {
        Debug.Log("OnMouseEnter");
    }

    //�}�E�X������Ă���ԁA�Ăяo���ꑱ����
    void OnMouseOver()
    {
        Debug.Log("OnMouseOver");
    }

    //�}�E�X�����ꂽ�Ƃ�
    void OnMouseExit()
    {
        Debug.Log("OnMouseExit");
    }

    //�N���b�N�����Ƃ�
    void OnMouseDown()
    {
        Debug.Log("OnMouseDown");
    }

    //�N���b�N���Ă���A�w�𗣂����Ƃ�
    void OnMouseUp()
    {
        Debug.Log("OnMouseUp");
    }

    //�N���b�N������A�h�I�u�W�F�N�g��Łh�@�w�𗣂����Ƃ�
    void OnMouseUpAsButton()
    {
        Debug.Log("MouseUpAsButton");
    }

    //�N���b�N���ăh���b�O�����Ă���ԁA�Ăяo���ꑱ����
    void OnMouseDrag()
    {
        Debug.Log("MouseDrag");
    }
}