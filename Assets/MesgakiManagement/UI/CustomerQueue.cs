using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomerQueue : MonoBehaviour
{
    [SerializeField] GameObject customerQueue;

    // Imageプレハブ
    [SerializeField] GameObject customerQueueImage;

    // Image配置枠のプレハブ
    [SerializeField] GameObject customerQueueImageSlot;

    // 親オブジェクトの指定
    [SerializeField] Transform queueParent;

    // 親オブジェクトの指定
    [SerializeField] Transform characterParent;

    // 基準点用
    [SerializeField] Image firstCustomerImage;

    // 現在のキュー内の客アイコン数
    private int currentQueueMax = 0;

    GameObject queueImageInstance;

    private float firstX;
    private float firstY;
    private float firstZ;



    GameObject slotInstance;
    GameObject childGameObject;
    RectTransform childTransform;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("プレハブ存在チェック：" + customerQueueImage);

        //Vector3 first = firstCustomerImage.rectTransform.position;
        RectTransform slot = customerQueueImageSlot.GetComponent<RectTransform>();
        Vector3 first = slot.position;

        // 初期座標取_得
        firstX = first.x;
        firstY = first.y;
        firstZ = first.z;


        addQueue();
        
    }

    private float MoveTimer;

    // Update is called once per frame
    void Update()
    {
        var sumTime = 0f;
        var flag = true;

        MoveTimer += Time.deltaTime;

        Debug.Log("時間測定：" + MoveTimer);

        childTransform.localPosition = Vector3.Lerp(new Vector2(300, 0), new Vector2(0, 0), MoveTimer * 2);
    }

    void addQueue()
    {
        // プレハブを元にオブジェクトを生成する
        slotInstance = (GameObject)Instantiate(
            customerQueueImageSlot
            , new Vector3(firstX, firstY, firstZ)
            , Quaternion.identity
            , queueParent);
        childGameObject = slotInstance.transform.GetChild(0).gameObject;
        childTransform = childGameObject.GetComponent<RectTransform>();

        slotInstance.name = "CustomerQueueImageSlot" + (currentQueueMax + 1).ToString();
    }
}
