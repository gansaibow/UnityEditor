using UnityEngine;
using UnityEditor;

public class MyWindow : EditorWindow {

	// Add menu named "My Window" to the Window menu
	[MenuItem ("Window/My Window")]
	static void Init () {
		// Get existing open window or if none, make a new one:
		EditorWindow.GetWindow (typeof (MyWindow));
	}

	void OnGUI () {
		
		if(GUI.Button(new Rect(10, 10, 100, 50), "Cube"))
		{
			GameObject.CreatePrimitive(PrimitiveType.Cube);
		}

		if(GUI.Button(new Rect(110, 10, 100, 50), "Spere"))
		{
			GameObject.CreatePrimitive(PrimitiveType.Sphere);
		}

		if(GUI.Button(new Rect(10, 70, 100, 50), "Capsule"))
		{
			GameObject.CreatePrimitive(PrimitiveType.Capsule);
		}

		if(GUI.Button(new Rect(110, 70, 100, 50), "Cylinder"))
		{
			GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		}

		if(GUI.Button(new Rect(10, 130, 100, 50), "Plane"))
		{
			GameObject.CreatePrimitive(PrimitiveType.Plane);
		}
		
		if(GUI.Button(new Rect(110, 130, 100, 50), "Quad"))
		{
			GameObject.CreatePrimitive(PrimitiveType.Quad);
		}
	}
}
