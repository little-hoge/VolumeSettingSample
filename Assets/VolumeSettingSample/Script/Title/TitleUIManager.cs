using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleUIManager : MonoBehaviour
{
    /// <summary>
    /// 設定釦クリック時
    /// </summary>
    public void OnClickSetting() {

        SceneManager.LoadScene("GameSetting", LoadSceneMode.Additive);
    }
}
