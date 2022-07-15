using UnityEngine;

[RequireComponent(typeof(FPSAverageGetter))]
public class CheckFPS : MonoBehaviour
{
    [SerializeField] string averageData = default;
    [SerializeField] string deltaData = default;
    [SerializeField, Range(0, 240)] uint setFPS = 60;

    private uint prevSetFPS;
    private FPSAverageGetter fps;

    void Start()
    {
        Application.targetFrameRate = (int)setFPS;
        prevSetFPS = setFPS;
        fps = gameObject.GetComponent<FPSAverageGetter>();
    }

    void Update()
    {
        if (setFPS != prevSetFPS)
        {
            Application.targetFrameRate = (int)setFPS;
            prevSetFPS = setFPS;
        }

        if (fps.canGetAverageFPSFlag)
        {
            averageData = fps.nowAverageFPS.ToString();
            deltaData = fps.nowDeltaFPS.ToString();
        }
        else
        {
            averageData = fps.nowDeltaFPS.ToString();
        }
    }
}
