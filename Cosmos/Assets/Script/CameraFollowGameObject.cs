using UnityEngine;
using System.Collections;

public class CameraFollowGameObject : MonoBehaviour {
        public Camera MainCamera;                                               //主摄像机
        public Transform LookAtTarget;                                          //摄像机看向的目标
        public float MainCameraMoveSpeed = 1f;                                  //主摄像机移动的速度
        private Vector3 LookAtTargetPosition;                                  //看向目标时的位置
        public bool IsBack = true;

    void Start()
    {
        LookAtTargetPosition.x = LookAtTarget.transform.position.x;
        LookAtTargetPosition.y = LookAtTarget.transform.position.y;
    }
       void Update()
        {
        MainCamera.transform.position = Vector3.Lerp(MainCamera.transform.position, LookAtTargetPosition,
                    Time.deltaTime * MainCameraMoveSpeed);

    }
    void LateUpdate()
    {
        
    }
  
}
