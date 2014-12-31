#region " Imports "
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using AssemblyCSharp;
#endregion 

#region " Referenced assemblies "
// - UnityEngine v0.0.0.0
// - mscorlib v2.0.0.0
// - Newtonsoft.Json v1.3.0.0
// - System.Core v3.5.0.0
// - System.Xml v2.0.0.0
// - Ionic.Zip v1.9.1.8
// - System v2.0.0.0
// - Assembly-CSharp v0.0.0.0
// - mscorlib v4.0.0.0
// - Assembly-CSharp v0.0.0.0
#endregion 

class Radar
{
	// Limited support!
	// You can only reference methods or fields defined in the class (not in ancestors classes)
	// Fields and methods stubs are needed for compilation purposes only.
	// Reflexil will automaticaly map current type, fields or methods to original references.
	void DrawPlayerName(UnityEngine.Vector3 p, string name, AssemblyCSharp.CPlayerData playerData)
	{
	byte teamID = playerData.Team;
	
	switch(teamID){
		case 0:
		this.gui_style.normal.textColor = Color.blue;
		break;
		case 1:
		this.gui_style.normal.textColor = Color.red;
		break;
		case 2:
		this.gui_style.normal.textColor = Color.green;
		break;
		case 3:
		this.gui_style.normal.textColor = Color.yellow;
		break;
		default:
		this.gui_style.normal.textColor = Color.white;
		break;
	
	}
    p.y += 2.5f;
    Vector3 vector = Camera.mainCamera.WorldToScreenPoint(p);
    vector.y = Screen.height - vector.y;
    Transform transform = this.LocalPlayer.transform;
    Vector3 position = transform.position;
    Vector3 from = p - position;
    Transform transform2 = this.LocalPlayer.transform;
    float num = Vector3.Angle(from, transform2.forward);
    if ((num < 90f) && (vector.z > 0f))
    {
        GUI.Label(new Rect(vector.x - 100f, vector.y, 200f, 20f), name, this.gui_style);
    }
}

	
	#region " Methods stubs "
	// Do not add or update any method. If compilation fails because of a method declaration, comment it
	Radar()
	{
	}
	
	void Awake()
	{
	}
	
	//void UpdateRadarColor(System.Byte[0...,0...] data)
	//{
	//}
	
	void ForceUpdateRadar()
	{
	}
	
	System.Collections.IEnumerator UpdateRadar()
	{
		return default(System.Collections.IEnumerator);
	}
	
	UnityEngine.Color GetColor(Block block)
	{
		return default(UnityEngine.Color);
	}
	
	void OnGUI()
	{
	}
	
	void DrawPlayer(float px, float pz, float ry, bool self, bool zombie, AssemblyCSharp.CPlayerData playerData)
	{
	}
	
	void DrawBase(float px, float pz)
	{
	}
	
	void DrawTeam(float px, float pz)
	{
	}
	
	static float AngleSigned(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, UnityEngine.Vector3 n)
	{
		return default(float);
	}
	
	void GenerateSideTexture()
	{
	}
	
	void BadValue()
	{
	}
	
	#endregion 
	
	#region " Fields stubs "
	// Do not add or update any field. If compilation fails because of a field declaration, comment it
	bool canupdate;
	UnityEngine.Texture2D RadarTexture;
	UnityEngine.Texture2D RadarTexture2;
	UnityEngine.Texture2D ZombiePosition;
	UnityEngine.Texture2D PlayerPosition;
	UnityEngine.Texture2D TeamPosition;
	UnityEngine.Texture2D BasePosition;
	UnityEngine.Texture2D RadarSideTexture;
	UnityEngine.GUIStyle gui_style;
	GuiManager guimanager;
	Map map;
	BotController botcontroller;
	Client cscl;
	PlayerControl cspc;
	UnityEngine.GameObject LocalPlayer;
	UnityEngine.Vector3[] team_pos;
	UnityEngine.Vector3 base_pos;
	int[] team_dot;
	int team_dot_all;
	//System.Collections.Generic.List<CBlockColor> colorlist;
	UnityEngine.Texture2D tmpTex;
	BlockSet blockset;
	UnityEngine.Texture2D blockTex;
	UnityEngine.Color tmpColor;
	#endregion 

}
