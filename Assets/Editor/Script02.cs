using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Script02 : MonoBehaviour
{
    /// <summary>
    /// 创建菜单   MenuItem+静态方法
    /// </summary>
    [MenuItem("Assets/Create/TestNewCreate/Cube", false, 2)]
    static void CreateCube()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

    [MenuItem("Assets/Create/TestNewCreate/Sphere", false, 1)]
    static void CreateSphere()
    {
        GameObject.CreatePrimitive(PrimitiveType.Sphere);
    }
}
