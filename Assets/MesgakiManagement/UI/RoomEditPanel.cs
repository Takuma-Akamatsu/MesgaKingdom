using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MesgakiManagement.Entity;
using MesgakiManagement.UI;

public class RoomEditPanel : MonoBehaviour
{
    // スタッフのプレハブ
    [SerializeField] GameObject staffPrefab;

    // スタッフリストのコンテンツ入れ
    [SerializeField] Transform queueParent;


    private string CREATE_OBJECT_NAME = "StaffButton";

    // 現在のキュー内の客アイコン数
    private int currentQueueMax = 0;

    // Start is called before the first frame update
    void Start()
    {
        //var scrollView = GameObject.Find("RoomEditScroll");

        // TODO: Mockオブジェクトの削除
        foreach (Transform n in queueParent.transform)
        {
            GameObject.Destroy(n.gameObject);
        }

        // 初期化非表示
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// スタッフリストへの追加
    /// </summary>
    public void addStaff(Mesgaki mesgaki)
    {
        // プレハブを元にオブジェクトを生成する
        var s = (GameObject)Instantiate(
            staffPrefab
            , new Vector3(0f, 0f, 0f) // LayoutGroupが整列させるので気にしなくて良し
            , Quaternion.identity // 回転させない
            , queueParent);

        // キューのカウントアップ
        currentQueueMax++;

        Mesgaki staff = mesgaki;

        var sb = s.GetComponent<StaffButton>();

        sb.staff = staff;

        // オブジェクトの名前設定
        s.name = CREATE_OBJECT_NAME + currentQueueMax.ToString();
    }
}
