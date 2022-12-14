using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleReturn : MonoBehaviour
{
    // On실행, ParticleSystem 파티클시스템, Stopped 중지하다
    // 파티클 멈춤을 실행
    private void OnParticleSystemStopped()
    {
        var particle = GetComponent<ParticleSystem>();
        EffectManager.GetInstance().ReturnEffect(particle);
    }
}
