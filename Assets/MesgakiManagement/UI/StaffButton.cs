using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using MesgakiManagement.Entity;

namespace MesgakiManagement.UI
{
    public class StaffButton : MonoBehaviour
    {
        // スタッフ情報のスクリプトをアタッチしたオブジェクト
        [SerializeField] GameObject staffInfo;

        public Mesgaki staff;

        // スタッフ情報のスクリプト
        private StaffInfo staffInfoScript;

        // Start is called before the first frame update
        void Start()
        {
            staffInfo = GameObject.Find("StaffInfo");
            staffInfoScript = staffInfo.GetComponent<StaffInfo>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        /// ボタンをクリックした時の処理
        public void OnClick()
        {
            Debug.Log("Button click!");

            staffInfoScript.staff = staff;
            //// 詳細画面の画像をボタンの画像に切り替え
            //staffInfoImage.sprite = thisImage.sprite;

        }
    }
}