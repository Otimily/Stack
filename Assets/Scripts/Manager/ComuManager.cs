using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComuManager : MonoBehaviour
{
    #region Singletone
    private static ComuManager instance = null;

    public static ComuManager GetInstance()
    {
        if (instance == null)
        {
            GameObject go = new GameObject("@ComuManager");
            instance = go.AddComponent<ComuManager>();

            DontDestroyOnLoad(go);
        }

        return instance;
    }
    #endregion

    public Npc NpcData;

    public void ComuStart(Npc cottonGirl)
    {
        NpcData = cottonGirl;

        UIManager.GetInstance().OpenUI("UITab");
    }

    public void TalkNpc()
    {

    }
}
