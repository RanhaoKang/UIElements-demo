using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;
using UnityEditor.UIElements;

public class EditorHelloWorld : EditorWindow
{
    [MenuItem("Samples/HelloWorld")]
    public static void Show()
    {
        EditorHelloWorld window = GetWindow<EditorHelloWorld>();
    }

    public void OnEnable()
    {
        Init();
    }

    private void Init()
    {
        VisualElement root = rootVisualElement;
        var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/EditorHelloWorld/EditorHelloWorld.uxml");
        VisualElement elementsFromUXML = visualTree.CloneTree();

        root.Add(elementsFromUXML);
    }
}
