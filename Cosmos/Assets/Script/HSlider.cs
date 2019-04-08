using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HSlider : MonoBehaviour
{
    // Start is called before the first frame update
    /// <summary>
    /// 定义横进度条
    /// </summary>
    public Slider bar;

    public float duration = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bar.value < 1)
        {
            float value = 1 / duration * Time.deltaTime;
            bar.value += value;
        }
    }

    /// <summary>
    /// 头像技能释放按钮
    /// </summary>
    public void HeadButton()
    {
            bar.value = 0;  
        Debug.Log("我点击了按钮……");
    }
}
