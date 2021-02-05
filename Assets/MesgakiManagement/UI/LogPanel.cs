using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogPanel : MonoBehaviour
{
    private string CREATE_OBJECT_NAME = "Log";

    // 現在のログの数
    private int currentQueueMax = 0;

    // ログリスト
    [SerializeField] Transform logParent;

    // ログテキストのプレハブ
    [SerializeField] GameObject logPrefab;

    // Start is called before the first frame update
    void Start()
    {
        // TODO: Mockオブジェクトの削除
        foreach (Transform n in logParent.transform)
        {
            GameObject.Destroy(n.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// ログリストへの追加
    /// </summary>
    public void addLog(string log)
    {
        // プレハブを元にオブジェクトを生成する
        var l = (GameObject)Instantiate(
            logPrefab
            , new Vector3(0f, 0f, 0f) // LayoutGroupが整列させるので気にしなくて良し
            , Quaternion.identity // 回転させない
            , logParent);

        // キューのカウントアップ
        currentQueueMax++;

        // オブジェクトの名前設定
        l.name = CREATE_OBJECT_NAME + currentQueueMax.ToString();
    }
}
