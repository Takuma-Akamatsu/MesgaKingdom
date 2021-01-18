using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRoomClick : MonoBehaviour
{
    public static string OBJECT_NAME = "PlayRoomClick";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //左クリックを受け付ける
        if (Input.GetMouseButtonDown(0))
            Debug.Log("Pressed primary button.");

        //右クリックを受け付ける
        if (Input.GetMouseButtonDown(1))
            Debug.Log("Pressed secondary button.");

        //ミドルクリックを受け付ける
        if (Input.GetMouseButtonDown(2))
            Debug.Log("Pressed middle click.");
    }

    /// ボタンをクリックした時の処理
    public void OnClick()
    {
        Debug.Log("Button click!");
    }
}
