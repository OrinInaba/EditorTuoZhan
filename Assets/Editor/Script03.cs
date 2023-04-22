using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Script03
{
    [InitializeOnLoadMethod]//意思是此方法在C#代码每次编译完成后首先调用
    static void InitializeOnLoadMethod()
    {
        EditorApplication.projectWindowItemOnGUI = delegate (string guid, Rect selectionRect)
        {
            //在project视图中选择一个资源
            if (Selection.activeObject && guid == AssetDatabase.AssetPathToGUID(AssetDatabase.GetAssetPath(Selection.activeObject)))
            {
                //设置拓展按钮区域
                float width = 50f;
                selectionRect.x += (selectionRect.width - width);
                selectionRect.y += 2f;
                selectionRect.width = width;
                GUI.color = Color.red;
                //点击事件
                if (GUI.Button(selectionRect, "Click"))
                {
                    Debug.LogFormat("Click:{0}", Selection.activeObject.name);
                }
                GUI.color = Color.white;
            }
        };
    }
}
