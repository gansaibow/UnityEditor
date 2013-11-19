using UnityEditor;
using UnityEngine;
using System.Collections;

public class AllDelete : MonoBehaviour {

	// Add menu named "My Window" to the Window menu
	[MenuItem ("Window/AllDelete")]
	static void Delete() {
		
		foreach (GameObject obj in Object.FindObjectsOfType(typeof(GameObject)))
		{
		    if (obj.transform.parent == null && obj.name != "Main Camera")
		    {
				DestroyImmediate(obj);
		    }
		}		
	}
}
