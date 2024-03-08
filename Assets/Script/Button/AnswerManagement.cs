using UnityEngine;

public class AnswerManagement : MonoBehaviour
{
    /*
    0 = Not selected
    1 = Final Answer
    2 = Option lock
    */
    public int FinalAnswer;
    private GameObject _lastExecutedObject;
    private OptionSpriteButton _lastExecutedScript;
    void Start()
    {
        FinalAnswer = 0;
    }

    public bool Check(int spriteChanged, string lastExecutedScriptName)
    {
        if (FinalAnswer == 2)
        { 
            return false;
        }
        else if (FinalAnswer == 0)
        {
            _lastExecutedObject = transform.Find(lastExecutedScriptName).gameObject;
            _lastExecutedScript = _lastExecutedObject.GetComponent<OptionSpriteButton>();
            return true;
        }
        else if (spriteChanged == 0)
        {
            _lastExecutedScript.ResetSprite();
            _lastExecutedObject = transform.Find(lastExecutedScriptName).gameObject;
            _lastExecutedScript = _lastExecutedObject.GetComponent<OptionSpriteButton>();
            return true;
        }
        else if (spriteChanged >= 1 && spriteChanged <= 2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}