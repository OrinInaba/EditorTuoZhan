using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Script18
{
    [InitializeOnLoadMethod]
    static void InitializeOnLoadMethod()
    {
        SceneView.onSceneGUIDelegate = delegate (SceneView sceneView)
        {
            Event e = Event.current;
            if (e!=null)
            {
                int controlID = GUIUtility.GetControlID(FocusType.Passive);//表示禁止接收控制焦点
                if (e.type==EventType.Layout)
                {
                    HandleUtility.AddDefaultControl(controlID);
                }
            }
        };
    }
}
