using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Script01 : MonoBehaviour
{
    /// <summary>
    /// ��չ�Ҽ��˵�   MenuItem+��̬����
    /// </summary>
    [MenuItem("Assets/MyTools/Tools 01",false,2)]
    static void MyTools01()
    {
        Debug.Log(Selection.activeObject.name);//��ӡ���Ҽ�ѡ�����Դ������
    }

    [MenuItem("Assets/MyTools/Tools 02", false, 1)]
    static void MyTools02()
    {
        Debug.Log(Selection.activeObject.name);
    }

    
}
