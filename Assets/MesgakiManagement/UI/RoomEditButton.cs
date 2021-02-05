using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomEditButton : MonoBehaviour
{
    [SerializeField] GameObject roomEdit;

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
        Debug.Log("部屋編集ボタンクリック");

        // 詳細画面表示
        roomEdit.SetActive(true);
    }
}
