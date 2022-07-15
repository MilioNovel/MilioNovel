using UnityEngine;

/// <summary> 平均フレームレート取得クラス </summary>
public class FPSAverageGetter : MonoBehaviour
{
    //算出値キャッシュ
    private int secondFrameRate;
    private int averageFrameRate;
    private float deltaFrameRate;

    //算出用変数
    private bool averageReady;
    private int frameRateCounter;
    private float nextGetFrameRateTime;

    /// <summary>
    /// 平均値が取得できるようになるとtrueが格納されます
    /// </summary>
    public bool canGetAverageFPSFlag { get { return averageReady; } }

    /// <summary> 現在の平均フレームレート値(Frame per second) </summary>
    /// <remarks>
    /// <para>１秒ごとにフレームレートの実効値を取得し平均化された値です</para>
    /// <para>シームレスなフレームレートの平均値が必要な時はこの変数してください</para>
    /// </remarks>
    public int nowAverageFPS { get { return averageFrameRate; } }

    /// <summary> 現在のΔtから算出されたフレームレート値(Frame per secound) </summary>
    /// <remarks>
    /// <para>Δtから逆算により算出された値です</para>
    /// <para>フレームごとのリアルタイムな平均値が必要な時はこの変数してください</para>
    /// <para>Δtから逆算により算出された値のため、値の変動は大きくなります</para>
    /// </remarks>
    public float nowDeltaFPS { get { return deltaFrameRate; } }

    void Start()
    {
        averageReady            = false;
        deltaFrameRate          = 0f;
        frameRateCounter        = 0;
        averageFrameRate        = 0;
        nextGetFrameRateTime    = Time.time + 1.0f;
    }

    void Update()
    {
        //Δtから現在のフレームレートを算出
        deltaFrameRate = 1.0f / Time.deltaTime;

        //平均化フレームレート値を取得
        frameRateCounter++;
        if (Time.time >= nextGetFrameRateTime)
        {
            //平均FPSが更新されていない場合
            if (averageFrameRate == 0) { averageFrameRate = frameRateCounter; averageReady = true; }

            //更新と平均化
            secondFrameRate = frameRateCounter;
            averageFrameRate = (averageFrameRate + secondFrameRate) / 2;

            //次に取得するデータの更新
            frameRateCounter = 0;
            nextGetFrameRateTime += 1f;
        }
    }
}
