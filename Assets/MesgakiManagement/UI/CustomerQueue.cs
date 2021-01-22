using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MesgakiManagement.Entity;


namespace MesgakiManagement.UI
{
    public class Queue : EntityBase
    {
        // Imageを包む上位オブジェクト
        public GameObject slotInstance;

        // キューのImageの座標
        public RectTransform imageTransform;

        // 生成後の経過時間（移動アニメーションなどに使用）
        public float elapsedTimer;

        public Queue(GameObject slotInstance, RectTransform imageTransform, float elapsedTimer)
        {
            this.slotInstance = slotInstance;
            this.imageTransform = imageTransform;
            this.elapsedTimer = elapsedTimer;
        }
    }
    public class CustomerQueue : MonoBehaviour
    {
        // Image配置枠のプレハブ
        [SerializeField] GameObject customerQueueImageSlot;

        // 親オブジェクトの指定
        [SerializeField] Transform queueParent;

        private string CREATE_OBJECT_NAME = "CustomerQueueImageSlot";

        // 現在のキュー内の客アイコン数
        private int currentQueueMax = 0;

        private List<Queue> customers = new List<Queue>();

        // Start is called before the first frame update
        void Start()
        {
            // TODO: Mockオブジェクトの削除
            foreach (Transform n in queueParent.transform)
            {
                GameObject.Destroy(n.gameObject);
            }

            addQueue();
            addQueue();
        }

        // Update is called once per frame
        void Update()
        {
            // NOTE: Time.deltaTime = 直前のフレームと今のフレーム間で経過した時間

            //childTransform.localPosition = Vector3.Lerp(new Vector2(300, 0), new Vector2(0, 0), MoveTimer * 2);
            foreach(Queue q in customers)
            {
                timeCount(q);

                // アニメーションが終わったら移動アニメーションの計算を行わない
                if (q.elapsedTimer <= 1f)
                {
                    positionMove(q);
                }
            }

        }

        /// <summary>
        /// 生成後の経過時間カウントアップ
        /// </summary>
        /// <param name="q">対象のオブジェクト</param>
        void timeCount(Queue q)
        {
            q.elapsedTimer += Time.deltaTime;
        }

        /// <summary>
        /// Imageの移動アニメーション
        /// </summary>
        /// <param name="q">対象のオブジェクト</param>
        void positionMove(Queue q)
        {
            q.imageTransform.localPosition = Vector3.Lerp(new Vector2(300, 0), new Vector2(0, 0), q.elapsedTimer * 2);
        }

        /// <summary>
        /// キューに客オブジェクト追加
        /// </summary>
        void addQueue()
        {
            // プレハブを元にオブジェクトを生成する
            var s = (GameObject)Instantiate(
                customerQueueImageSlot
                , new Vector3(0f, 0f, 0f) // LayoutGroupが整列させるので気にしなくて良し
                , Quaternion.identity
                , queueParent);

            // キューのカウントアップ
            currentQueueMax++;

            // オブジェクトの名前設定
            s.name = CREATE_OBJECT_NAME + currentQueueMax.ToString();

            var i = s.transform.GetChild(0).gameObject;
            var t = i.GetComponent<RectTransform>();

            Queue q = new Queue(s, t, 0f);

            customers.Add(q);
        }
    }
}