using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour
{
    public static string OBJECT_NAME = "GameController";

    public GameObject roomDetail;

    // Start is called before the first frame update
    void Start()
    {
        roomDetail = GameObject.Find("RoomDetail");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
