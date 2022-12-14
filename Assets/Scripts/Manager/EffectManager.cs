using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    #region Singletone
    private static EffectManager instance = null;

    public static EffectManager GetInstance()
    {
        if (instance == null)
        {
            GameObject go = new GameObject("@EffectManager");
            instance = go.AddComponent<EffectManager>();

            DontDestroyOnLoad(go);
        }

        return instance;
    }
    #endregion

    Stack<ParticleSystem> effectPool = new Stack<ParticleSystem>();

    // 우유를 파티클로 사용하자
    public void InitEffectPool(int size)
    {
        for (int i = 0; i < size; i++)
        {
            var effect = ObjectManager.GetInstance().CreateHitEffect();
        }
    }

    public void ReleasePool()
    {
        effectPool.Clear();
    }


    public void UseEffect()
    {
        ParticleSystem effect = null;
    }

    public void ReturnEffect(ParticleSystem particle)
    {
        particle.gameObject.SetActive(false);
        effectPool.Push(particle);
    }
}
