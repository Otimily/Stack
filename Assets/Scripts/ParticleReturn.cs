using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleReturn : MonoBehaviour
{
    // On����, ParticleSystem ��ƼŬ�ý���, Stopped �����ϴ�
    // ��ƼŬ ������ ����
    private void OnParticleSystemStopped()
    {
        var particle = GetComponent<ParticleSystem>();
        EffectManager.GetInstance().ReturnEffect(particle);
    }
}
