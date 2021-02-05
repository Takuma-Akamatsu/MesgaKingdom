using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MesgakiManagement;
using MesgakiManagement.Entity;
using MesgakiManagement.ValueObject;


public class GameController : MonoBehaviour
{
    public static string OBJECT_NAME = "GameController";

    public GameObject roomDetail;

    // 客キューのスクリプトをアタッチしたオブジェクト
    [SerializeField] GameObject customerQueue;


    // 客キューのスクリプト
    private MesgakiManagement.UI.CustomerQueue customerQueueScript;

    // 部屋編集のスクリプトをアタッチしたオブジェクト
    [SerializeField] GameObject roomEditPanel;

    // 部屋編集のスクリプト
    private RoomEditPanel roomEditPanelScript;

    // Start is called before the first frame update
    void Start()
    {
        roomDetail = GameObject.Find("RoomDetail");

        // 客キューのスクリプト保持
        customerQueueScript = customerQueue.GetComponent<MesgakiManagement.UI.CustomerQueue>();

        // 部屋編集のスクリプト保持
        roomEditPanelScript = roomEditPanel.GetComponent<RoomEditPanel>();


        // TODO: 動作確認用
        customerQueueScript.addQueue();

        roomEditPanelScript.addStaff(new Mesgaki() { name = new CharacterName("アロエ") });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void fieldUpdate()
    {
        // TODO: 客キューの更新

        // TODO: 部屋状況の更新

        // TODO: 営業リソースの更新
    }
}
