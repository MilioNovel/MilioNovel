using UnityEngine;

public class AnswerManagement : MonoBehaviour
{
    public int FinalAnswer;
    /*
    0 = Not selected
    1 = Final Answer
    2 = Option lock
    */
    private GameObject _lastExecutedObject;
    private OptionsSpriteButton _lastExecutedScript;
    [SerializeField] GameObject m_optionA;
    [SerializeField] GameObject m_optionB;
    [SerializeField] GameObject m_optionC;
    [SerializeField] GameObject m_optionD;
    void Start()
    {
        FinalAnswer = 0;
    }

    public bool Check(int spriteChanged, string lastExecutedScriptName)
    {
        if (FinalAnswer == 0)
        {
            _lastExecutedObject = transform.Find(lastExecutedScriptName).gameObject;
            _lastExecutedScript = _lastExecutedObject.GetComponent<OptionsSpriteButton>();
            return true;
        }
        else if (spriteChanged == 0)
        {
            _lastExecutedScript.ResetSprite();
            _lastExecutedObject = transform.Find(lastExecutedScriptName).gameObject;
            _lastExecutedScript = _lastExecutedObject.GetComponent<OptionsSpriteButton>();
            return true;
        }
        else if (spriteChanged == 1)
        {
            return true;
        }
        else if (spriteChanged == 2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}