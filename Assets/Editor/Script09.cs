using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//[CustomEditor(typeof(Camera))]//�Զ�������
public class Script09 : Editor
{    
    public override void OnInspectorGUI()//���»���
    {        
        if (GUILayout.Button("Camera����չ��ť"))
        {
            //��������ť�ľ��巽��
            Debug.Log("��������");
        }
        base.OnInspectorGUI();//�Ƿ���Ƹ���ԭ��Ԫ��
    }
}//�ⷽ������ԭ���������Ҳ��֣���̫��
