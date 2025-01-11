using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot1 : MonoBehaviour
{
    private Vector4 FirstSlot;
    public GameObject Object;
    private void Update()
    {
        if (Input.GetButtonDown("1"))
        {
            FirstSlot = new Vector4(79 / 255.0f, 165 / 255.0f, 63 / 255.0f, 1);
            gameObject.GetComponent<Image>().color = FirstSlot;
            Object.SetActive(true);
        }
        if (Input.GetButtonDown("2"))
        {
            FirstSlot = new Vector4(100 / 255.0f, 100 / 255.0f, 100 / 255.0f, 1);
            gameObject.GetComponent<Image>().color = FirstSlot;
            Object.SetActive(false);
        }
        if (Input.GetButtonDown("3"))
        {
            FirstSlot = new Vector4(100 / 255.0f, 100 / 255.0f, 100 / 255.0f, 1);
            gameObject.GetComponent<Image>().color = FirstSlot;
            Object.SetActive(false);
        }
    }
}
