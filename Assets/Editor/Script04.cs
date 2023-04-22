using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/// <summary>
/// ������Դ�¼���������Դ�Ĵ��� ɾ�� �ƶ� �����
/// </summary>
public class Script04 : UnityEditor.AssetModificationProcessor//����̳����
{
    [InitializeOnLoadMethod]
    static void ListenAssetEvent()
    {

        EditorApplication.projectChanged += delegate()
        {
            Debug.Log("�ı���Դ!");
        };
    }

    //����ķ�������д��UnityEditor.AssetModificationProcessor����ķ���

    /// <summary>
    /// ������������Դ�¼���ÿ�ε��project������Դ����ִ���������
    /// </summary>
    /// <param name="assetPath">��Դ·��</param>
    /// <param name="message"></param>
    /// <returns></returns>
    public static bool IsOpenForEdit(string assetPath,out string message)
    {
        message = null;
        Debug.Log($"ѡ������Դ����Դ·����{assetPath}");
        //TRUE��ʾ���Դ򿪣�FALSE��ʾ������unity����Դ��������дfalseҲ�ܴ򿪡�������
        return true;
    }

    /// <summary>
    /// ������Դ�����¼�
    /// </summary>
    /// <param name="path">��Դ·��</param>
    public static void OnWillCreateAsset(string path)
    {
        Debug.LogFormat($"������Դ��·����{path}");
    }

    /// <summary>
    /// ������Դ�����¼�
    /// </summary>
    /// <param name="paths">��Դ·��</param>
    /// <returns></returns>
    public static string[] OnWillSaveAssets(string[] paths)
    {
        if (paths!=null)
        {
            //string.Join  ���Ӷ���ַ���
            Debug.LogFormat("������Դ��·����{0}", string.Join(",",paths));
        }
        return paths;
    }

    /// <summary>
    /// ������Դ�ƶ��¼�
    /// </summary>
    /// <param name="oldPath">��·��</param>
    /// <param name="newPath">��·��</param>
    /// <returns></returns>
    public static AssetMoveResult OnWillMoveAsset(string oldPath,string newPath)
    {
        Debug.LogFormat($"�ƶ���Դ���Ӿ�·��:{oldPath}����·��:{newPath}");
        //AssetMoveResult.DidNotMove��ʾ����Դ�����ƶ���Didmove��ʾ�����ƶ�   
        return AssetMoveResult.DidNotMove;
    }

    /// <summary>
    /// ������Դ������ɾ���¼�
    /// </summary>
    /// <param name="path">��Դ·��</param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static AssetDeleteResult OnWillDeleteAsset(string path,RemoveAssetOptions options)
    {
        Debug.LogFormat($"ɾ����Դ��·����{path}");
        //AssetDeleteResult.DidNotDelete��ʾ����ɾ��      DidDelete��ʾ������ɾ��  
        return AssetDeleteResult.DidNotDelete;
    }
}
