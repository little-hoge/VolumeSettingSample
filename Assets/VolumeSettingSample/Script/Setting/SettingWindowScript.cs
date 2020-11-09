using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingWindowScript : MonoBehaviour
{
    void Start()
    {
    }
    void Update()
    {
    }

    /// <summary>
    /// 戻る釦クリック時
    /// </summary>
    public void OnClickBuckSetting()
    {
        SceneManager.UnloadSceneAsync("GameSetting");
        SoundManager.Instance.StopBgm();
        SoundManager.Instance.StopSe();
    }


}
