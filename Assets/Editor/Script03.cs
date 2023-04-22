using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Script03
{
    [InitializeOnLoadMethod]//��˼�Ǵ˷�����C#����ÿ�α�����ɺ����ȵ���
    static void InitializeOnLoadMethod()
    {
        EditorApplication.projectWindowItemOnGUI = delegate (string guid, Rect selectionRect)
        {
            //��project��ͼ��ѡ��һ����Դ
            if (Selection.activeObject && guid == AssetDatabase.AssetPathToGUID(AssetDatabase.GetAssetPath(Selection.activeObject)))
            {
                //������չ��ť����
                float width = 50f;
                selectionRect.x += (selectionRect.width - width);
                selectionRect.y += 2f;
                selectionRect.width = width;
                GUI.color = Color.red;
                //����¼�
                if (GUI.Button(selectionRect, "Click"))
                {
                    Debug.LogFormat("Click:{0}", Selection.activeObject.name);
                }
                GUI.color = Color.white;
            }
        };
    }
}
