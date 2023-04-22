using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/// <summary>
/// 监听资源事件，包括资源的创建 删除 移动 保存等
/// </summary>
public class Script04 : UnityEditor.AssetModificationProcessor//必须继承这个
{
    [InitializeOnLoadMethod]
    static void ListenAssetEvent()
    {

        EditorApplication.projectChanged += delegate()
        {
            Debug.Log("改变资源!");
        };
    }

    //下面的方法是重写了UnityEditor.AssetModificationProcessor里面的方法

    /// <summary>
    /// 监听点击或打开资源事件，每次点击project面板的资源都会执行这个方法
    /// </summary>
    /// <param name="assetPath">资源路径</param>
    /// <param name="message"></param>
    /// <returns></returns>
    public static bool IsOpenForEdit(string assetPath,out string message)
    {
        message = null;
        Debug.Log($"选择了资源！资源路径：{assetPath}");
        //TRUE表示可以打开，FALSE表示不能在unity打开资源（但是我写false也能打开。。。）
        return true;
    }

    /// <summary>
    /// 监听资源创建事件
    /// </summary>
    /// <param name="path">资源路径</param>
    public static void OnWillCreateAsset(string path)
    {
        Debug.LogFormat($"创建资源！路径：{path}");
    }

    /// <summary>
    /// 监听资源保存事件
    /// </summary>
    /// <param name="paths">资源路径</param>
    /// <returns></returns>
    public static string[] OnWillSaveAssets(string[] paths)
    {
        if (paths!=null)
        {
            //string.Join  连接多个字符串
            Debug.LogFormat("保存资源！路径：{0}", string.Join(",",paths));
        }
        return paths;
    }

    /// <summary>
    /// 监听资源移动事件
    /// </summary>
    /// <param name="oldPath">旧路径</param>
    /// <param name="newPath">新路径</param>
    /// <returns></returns>
    public static AssetMoveResult OnWillMoveAsset(string oldPath,string newPath)
    {
        Debug.LogFormat($"移动资源！从旧路径:{oldPath}到新路径:{newPath}");
        //AssetMoveResult.DidNotMove表示该资源可以移动，Didmove表示不能移动   
        return AssetMoveResult.DidNotMove;
    }

    /// <summary>
    /// 监听资源即将被删除事件
    /// </summary>
    /// <param name="path">资源路径</param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static AssetDeleteResult OnWillDeleteAsset(string path,RemoveAssetOptions options)
    {
        Debug.LogFormat($"删除资源！路径：{path}");
        //AssetDeleteResult.DidNotDelete表示可以删除      DidDelete表示不可以删除  
        return AssetDeleteResult.DidNotDelete;
    }
}
