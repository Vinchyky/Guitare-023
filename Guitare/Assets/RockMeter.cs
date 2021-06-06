using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockMeter : MonoBehaviour
{
    int rm;
    GameObject needle;
    // Start is called before the first frame update
    void Start()
    {
        needle = transform.Find("needle").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        rm = PlayerPrefs.GetInt("RockMeter");
        print(needle.transform.localPosition);
        print(needle.transform.localPosition);
        //needle.transform.localPosition = new Vector2(-30, 17);
    }
}
//-27 -36