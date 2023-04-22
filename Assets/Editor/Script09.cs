using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//[CustomEditor(typeof(Camera))]//自定义的组件
public class Script09 : Editor
{    
    public override void OnInspectorGUI()//重新绘制
    {        
        if (GUILayout.Button("Camera的拓展按钮"))
        {
            //点击这个按钮的具体方法
            Debug.Log("来了来了");
        }
        base.OnInspectorGUI();//是否绘制父类原有元素
    }
}//这方法对于原生组件会打乱布局，不太好
