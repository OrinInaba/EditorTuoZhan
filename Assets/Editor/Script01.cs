using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Script01 : MonoBehaviour
{
    /// <summary>
    /// 拓展右键菜单   MenuItem+静态方法
    /// </summary>
    [MenuItem("Assets/MyTools/Tools 01",false,2)]
    static void MyTools01()
    {
        Debug.Log(Selection.activeObject.name);//打印出右键选择的资源的名字
    }

    [MenuItem("Assets/MyTools/Tools 02", false, 1)]
    static void MyTools02()
    {
        Debug.Log(Selection.activeObject.name);
    }

    
}
