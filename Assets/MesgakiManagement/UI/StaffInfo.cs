using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using MesgakiManagement.Entity;

public class StaffInfo : MonoBehaviour
{
    public Mesgaki staff = new Mesgaki();
    public Mesgaki currentStaff = new Mesgaki();
    [SerializeField] Image staffInfoImage;
    [SerializeField] TextMeshProUGUI staffInfoText;

    // Start is called before the first frame update
    void Start()
    {
        staffInfoImage.sprite = null;
        staffInfoText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (!Equals(staff, currentStaff))
        {
            Debug.Log("staffが変更になった");

            currentStaff = staff;

            staffInfoImage.sprite = staff.image;

            staffInfoText.text = staff.name.Value;
        }
    }
}
