using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MesgakiManagement.Entity;
using TMPro;
using MesgakiManagement.ValueObject;

public class CustomerInfoPanel : MonoBehaviour
{
    // Image配置枠のプレハブ
    [SerializeField] TextMeshProUGUI infoText;

    // Start is called before the first frame update
    void Start()
    {
        //var i = s.transform.GetChild(0).gameObject;


        // TODO: 機能確認
        //var mockOjisan = new Ojisan() { 
        //    name = new CharacterName("赤井　水星") 
        //    , community = new CustomerCommunity("ジオン株式会社")
        //};
        //updateViewCustomerInfo(mockOjisan);


        // TODO: モック文章削除
        infoText.text = "Next おじさん";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateViewCustomerInfo(Ojisan ojisan)
    {
        Debug.Log("info書き換え");

        string header = "Next おじさん\n\n";
        string name = "名前：" + ojisan.name.Value + "\n";
        string community = "所属：" + ojisan.community.Value + "\n";

        infoText.text = header + name + community;
    }
}
