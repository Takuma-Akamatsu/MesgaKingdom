using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerQueue : MonoBehaviour
{
    [SerializeField] GameObject customerQueue;

    // Imageプレハブ
    [SerializeField] GameObject customerQueueImage;

    // 親オブジェクトの指定
    [SerializeField] Transform characterParent;

    // 基準点用
    [SerializeField] GameObject firstCustomerImage;

    private int currentMax = 6;

    private float firstX;
    private float firstY;
    private float firstZ;

    // Start is called before the first frame update
    void Start()
    {
        //GameObject obj = (GameObject)Resources.Load("CustomerQueueImage");
        Debug.Log("プレハブ存在チェック：" + customerQueueImage);

        Vector3 first = firstCustomerImage.transform.position;

        Debug.Log("初期位置ポジション：" + firstCustomerImage.transform.position);

        Debug.Log("初期位置ポジション：" + firstCustomerImage.transform.localPosition);

        // 初期座標取_得
        firstX = first.x;
        firstY = first.y;
        firstZ = first.z;



        // プレハブを元にオブジェクトを生成する
        GameObject queueImageInstance = (GameObject)Instantiate(
            customerQueueImage
            , new Vector3(firstX, firstY, firstZ)
            //, firstCustomerImage.transform.position
            , Quaternion.identity
            , characterParent);
        queueImageInstance.name = "CustomerQueueImage" + (currentMax + 1).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void addQueue()
    {
        //customerQueue
    }
}
