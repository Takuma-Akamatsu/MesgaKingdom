using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


namespace MesgakiManagement.UI
{
    public class RoomButton : MonoBehaviour, IDropHandler
    {
        [SerializeField] GameObject roomDetail;
        [SerializeField] Image roomDetailImage;
        [SerializeField] Image thisImage;

        public GameObject Item
        {
            get
            {
                if (transform.childCount > 0)
                {
                    return transform.GetChild(0).gameObject;
                }
                return null;
            }
        }

        private void Start()
        {
            
        }

        /// ボタンをクリックした時の処理
        public void OnClick()
        {
            Debug.Log("Button click!");
            
            // 詳細画面の画像をボタンの画像に切り替え
            roomDetailImage.sprite = thisImage.sprite;

            // 詳細画面表示
            roomDetail.SetActive(true);
        }

        // ボタン上におじさんアイコンをドラッグドロップされた時の処理
        public void OnDrop(PointerEventData eventData)
        {
            Debug.Log("ドロップイベント発火");
            //Debug.Log(gameObject.name);

            //OjisanQueueImage dragObj = eventData.pointerDrag.GetComponent<OjisanQueueImage>();
            ////RoomButton.obj.position = transform.position;


            if (eventData.pointerDrag != null)
            {
                Debug.Log("Dropped object was: " + eventData.pointerDrag);


            }


            //if (dragObj != null)
            //{
            //    dragObj.parentTransform = this.transform;
            //    Debug.Log(gameObject.name + "に" + eventData.pointerDrag.name + "をドロップ");
            //}


            //if (Item == null)
            //{
            //    Debug.Log("Item == null");
            //    OjisanQueueImage.dragObject.transform.SetParent(transform);
            //}
            //else
            //{
            //    Debug.Log("Item：" + Item);
            //    Item.transform.SetParent(OjisanQueueImage.dragObject.parentTransform);
            //    OjisanQueueImage.dragObject.transform.SetParent(transform);
            //}
        }
    }
}

