using UnityEngine;

/// <summary> ���σt���[�����[�g�擾�N���X </summary>
public class FPSAverageGetter : MonoBehaviour
{
    //�Z�o�l�L���b�V��
    private int secondFrameRate;
    private int averageFrameRate;
    private float deltaFrameRate;

    //�Z�o�p�ϐ�
    private bool averageReady;
    private int frameRateCounter;
    private float nextGetFrameRateTime;

    /// <summary>
    /// ���ϒl���擾�ł���悤�ɂȂ��true���i�[����܂�
    /// </summary>
    public bool canGetAverageFPSFlag { get { return averageReady; } }

    /// <summary> ���݂̕��σt���[�����[�g�l(Frame per second) </summary>
    /// <remarks>
    /// <para>�P�b���ƂɃt���[�����[�g�̎����l���擾�����ω����ꂽ�l�ł�</para>
    /// <para>�V�[�����X�ȃt���[�����[�g�̕��ϒl���K�v�Ȏ��͂��̕ϐ����Ă�������</para>
    /// </remarks>
    public int nowAverageFPS { get { return averageFrameRate; } }

    /// <summary> ���݂̃�t����Z�o���ꂽ�t���[�����[�g�l(Frame per secound) </summary>
    /// <remarks>
    /// <para>��t����t�Z�ɂ��Z�o���ꂽ�l�ł�</para>
    /// <para>�t���[�����Ƃ̃��A���^�C���ȕ��ϒl���K�v�Ȏ��͂��̕ϐ����Ă�������</para>
    /// <para>��t����t�Z�ɂ��Z�o���ꂽ�l�̂��߁A�l�̕ϓ��͑傫���Ȃ�܂�</para>
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
        //��t���猻�݂̃t���[�����[�g���Z�o
        deltaFrameRate = 1.0f / Time.deltaTime;

        //���ω��t���[�����[�g�l���擾
        frameRateCounter++;
        if (Time.time >= nextGetFrameRateTime)
        {
            //����FPS���X�V����Ă��Ȃ��ꍇ
            if (averageFrameRate == 0) { averageFrameRate = frameRateCounter; averageReady = true; }

            //�X�V�ƕ��ω�
            secondFrameRate = frameRateCounter;
            averageFrameRate = (averageFrameRate + secondFrameRate) / 2;

            //���Ɏ擾����f�[�^�̍X�V
            frameRateCounter = 0;
            nextGetFrameRateTime += 1f;
        }
    }
}
