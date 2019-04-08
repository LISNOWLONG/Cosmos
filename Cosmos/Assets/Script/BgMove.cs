using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BgMove : MonoBehaviour
{
    /// <summary>
    /// 鼠标位置
    /// </summary>
    private Vector3 vec3;
    /// <summary>
    /// 物体位置
    /// </summary>
    private Vector3 pos;
    /// <summary>
    /// 背景位置
    /// </summary>
    public GameObject bgPos;
    /// <summary>
    /// 移动距离
    /// </summary>
    private float off;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    /// <summary>
    /// 鼠标抬起
    /// </summary>
    public void MoveObject()
    {
        Vector3 off = Input.mousePosition - vec3;
        vec3 = Input.mousePosition;
        pos = pos + off;
        transform.GetComponent<RectTransform>().position = pos;
        //鼠标按下开启协程
        StartCoroutine(Bgmove());
    }
    /// <summary>
    /// 鼠标按下
    /// </summary>
    public void PointerDown()
    {
        vec3 = Input.mousePosition;
        pos = transform.GetComponent<RectTransform>().position;
        //鼠标抬起关闭协程
        StopCoroutine(Bgmove());
    }
    /// <summary>
    /// 协程控制背景移动
    /// </summary>
    /// <returns></returns>
    IEnumerator Bgmove()
    {
        //滚动背景
        float move = 5.0f;//移动速度
        Vector3 pos = bgPos.transform.localPosition;
        pos.x -= move;
        //控制移动范围（超过画布归零）
        if (pos.x < -800)
        {
            pos.x = 0;
        }
        bgPos.transform.localPosition = pos;
        yield return new WaitForSeconds(0.1f);
    }
}
