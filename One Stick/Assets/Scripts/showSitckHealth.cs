using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showSitckHealth : MonoBehaviour
{
    public StickHealth stickHealth;
    public RectTransform Mask;
     float height;
     float width;

    void Start()
    {
        Mask = GameObject.Find("Mask").GetComponent<RectTransform> ();
        height = Mask.sizeDelta.y;
        width = Mask.sizeDelta.x;
        stickHealth = GameObject.Find("Game Controller").GetComponent<StickHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        Mask.sizeDelta = new Vector2(stickHealth.stickHealth/100 * width, height);
        //transform.localScale = new Vector3(stickHealth.stickHealth/100, 1f);
    }
}
