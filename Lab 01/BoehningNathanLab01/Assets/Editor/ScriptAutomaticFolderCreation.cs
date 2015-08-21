using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;

public class ScriptAutomaticFolderCreation : MonoBehaviour {
	
	[MenuItem("Tool Creation/Create folder")]
	public static void CreateFolder()
	{
		AssetDatabase.CreateFolder ("Assets", "Dynamic Assets");
		AssetDatabase.CreateFolder ("Assets", "Textures");
		AssetDatabase.CreateFolder ("Assets", "Prefabs");
		AssetDatabase.CreateFolder ("Assets", "Scripts");
		AssetDatabase.CreateFolder ("Assets", "Scenes");
		AssetDatabase.CreateFolder ("Assets", "Animations");
		AssetDatabase.CreateFolder ("Assets/Animations", "AnimationControllers");

		System.IO.File.WriteAllText (Application.dataPath + "/Materials/folderStructure.txt", "This folder is for storing materials");

		System.IO.File.WriteAllText (Application.dataPath + "/Textures/folderStructure.txt", "This folder is for storing textures");

		System.IO.File.WriteAllText (Application.dataPath + "/Prefabs/folderStructure.txt", "This folder is for storing prefabs");

		System.IO.File.WriteAllText (Application.dataPath + "/Scripts/folderStructure.txt", "This folder is for storing scripts");

		System.IO.File.WriteAllText (Application.dataPath + "/Scenes/folderStructure.txt", "This folder is for storing scenes");

		System.IO.File.WriteAllText (Application.dataPath + "/Animations/folderStructure.txt", "This folder is for storing raw animations");

		System.IO.File.WriteAllText (Application.dataPath + "/Animations/AnimationControllers/folderStructure.txt", "This folder is for storing animations");

		AssetDatabase.Refresh();
	}
	[MenuItem("Tool Creation 2/Create folder")]

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
