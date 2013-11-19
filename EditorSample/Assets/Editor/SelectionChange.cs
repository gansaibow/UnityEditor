using UnityEngine;
using UnityEditor;
using System.Collections;

public class SelectionChange : EditorWindow {
	
	int[] selectionIDs;
	
	[ MenuItem( "Window/Selection Saver" ) ]
	static void Launch()
	{
		EditorWindow editorWindow = GetWindow( typeof( SelectionChange ) );
 
		editorWindow.Show();
	}
	
	void OnGUI()
	{
		if(GUILayout.Button("Save"))
		{
			SaveSelection();	
		}
		if(GUILayout.Button("Load"))
		{
			LoadLastSavedSelection();
		}
	}
	
	void OnSelectionChange()
	{
		selectionIDs = Selection.instanceIDs;
	}
	
	void SaveSelection()
	{
		string saveStr = "";
		foreach(int id in selectionIDs)
		{
			saveStr += id.ToString() + ";";
		}
		saveStr = saveStr.TrimEnd(char.Parse(";"));
		EditorPrefs.SetString("SelectedIDs", saveStr);
	}

	void LoadLastSavedSelection()
	{
		string[] strIds = EditorPrefs.GetString("SelectedIDs").Split(char.Parse(";"));
		
		int[] ids = new int[strIds.Length];
		for(int i=0; i<strIds.Length; i++)
		{
			ids[i] = int.Parse(strIds[i]);
		}
		Selection.instanceIDs = ids;
	}
}
