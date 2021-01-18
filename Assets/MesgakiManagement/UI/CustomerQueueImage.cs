using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(CanvasGroup))]
public class CustomerQueueImage : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    // NOTE: transform.positionはアタッチメントされたオブジェクトの位置情報
    // NOTE: Unityの座標にはスクリーン座標、ワールド座標と種類がある

    private float timeCount;

    // 初期座標
    private Vector2 prePosition;

    // 位置座標
    private Vector3 position;
    // スクリーン座標をワールド座標に変換した位置座標
    private Vector3 screenToWorldPointPosition;

    // ドロップ側で使う
    public Transform parentTransform;


    public static CustomerQueueImage dragObject;
    private CanvasGroup canvasGroup;
    private Transform canvasTransform;

    public CanvasGroup CanvasGroup { get { return canvasGroup ?? (canvasGroup = gameObject.AddComponent<CanvasGroup>()); } }
    public Transform CanvasTransform { get { return canvasTransform ?? (canvasTransform = GameObject.Find("Canvas").transform); } }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (dragObject == null)
        //{
        //    transform.localPosition -= transform.localPosition / 3.0f;
        //}
        //// Vector3でマウス位置座標を取得する
        //position = Input.mousePosition;
        //// Z軸修正
        //position.z = 10f;
        //// マウス位置座標をスクリーン座標からワールド座標に変換する
        //screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(position);
        //// ワールド座標に変換されたマウス座標を代入
        //gameObject.transform.position = screenToWorldPointPosition;

    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("初期位置:" + transform.position);

        RectTransform rectTransform = GetComponent<RectTransform>();

        Debug.Log("初期rectTransform:" + rectTransform.position);
        prePosition = transform.position;


        Debug.Log("OnBeginDrag");
        //GetComponent<CanvasGroup>().blocksRaycasts = false;


        dragObject = this;
        parentTransform = transform.parent;
        transform.SetParent(CanvasTransform);
        CanvasGroup.blocksRaycasts = false;
        CanvasGroup.alpha = 0.5f;
    }

    public void OnDrag(PointerEventData eventData)
    {
        // Vector3でマウス位置座標を取得する
        position = Input.mousePosition;
        // Z軸修正
        position.z = 10f;
        // マウス位置座標をスクリーン座標からワールド座標に変換する
        screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(position);
        // ワールド座標に変換されたマウス座標を代入
        gameObject.transform.position = screenToWorldPointPosition;

        if (eventData.dragging)
        {
            timeCount += Time.deltaTime;
            if (timeCount > 1.0f)
            {
                Debug.Log("Dragging:イベントデータ座標：" + eventData.position);
                Debug.Log("Dragging:スクリーン座標＝＞ワールド座標したマウス位置座標：" + screenToWorldPointPosition);

                timeCount = 0.0f;
            }
        }
    }

    //public void OnDrag(PointerEventData e)
    //{
    //    m_rectTransform.position += new Vector3(e.delta.x, e.delta.y, 0f);
    //}

    private void Reset()
    {
        //m_rectTransform = GetComponent<RectTransform>();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //if (transform.parent == canvasTransform)
        //{
        //    transform.SetParent(parentTransform);
        //}
        //dragObject = null;
        //CanvasGroup.blocksRaycasts = true;
        //CanvasGroup.alpha = 1.0f;

        // ドラッグ前の位置に戻す
        //transform.position = prePosition;


        Debug.Log("OnEndDrag");
        //GetComponent<CanvasGroup>().blocksRaycasts = true;


        if (transform.parent == canvasTransform)
        {
            transform.SetParent(parentTransform);
        }
        dragObject = null;
        CanvasGroup.blocksRaycasts = true;
        CanvasGroup.alpha = 1.0f;
    }
}
