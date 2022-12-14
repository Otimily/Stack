using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    #region Singletone
    private static ObjectManager instance = null;

    public static ObjectManager GetInstance()
    {
        if (instance == null)
        {
            GameObject go = new GameObject("@ObjectManager");
            instance = go.AddComponent<ObjectManager>();

            DontDestroyOnLoad(go);
        }

        return instance;
    }
    #endregion

    public GameObject CreateNpc()
    {
        object NpcObj = Resources.Load("Npc");
        GameObject Npc = (GameObject)Instantiate(NpcObj);

        return Npc;
    }

    public ParticleSystem CreateHitEffect();
    {
        Object effectObj = Resources.Load("Milk");
        GameObject effect = (GameObject)Instantiate(effectObj);

        return effect.GetComponent<ParticleSystem>();
    }
}
