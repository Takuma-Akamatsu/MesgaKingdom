using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MesgakiManagement.UI
{
    public class RDHideButton : MonoBehaviour
    {
        [SerializeField] GameObject roomDetail;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        /// ボタンをクリックした時の処理
        public void OnClick()
        {
            Debug.Log("Button click!");

            // 詳細画面非表示
            roomDetail.SetActive(false);
        }
    }
}

