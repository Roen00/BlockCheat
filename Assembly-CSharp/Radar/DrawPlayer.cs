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
	void DrawPlayer(float px, float pz, float ry, bool self, bool zombie, AssemblyCSharp.CPlayerData playerData)
{
    Matrix4x4 matrixx2;
    float single4;
    byte team = playerData.Team;
    switch(team){
    	case 0:
    	GUI.color = Color.blue;
        goto Label_0041;
        break;
    	case 1:
    	GUI.color = Color.red;
        goto Label_0041;
        break;
    	case 2:
    	GUI.color = Color.green;
        goto Label_0041;
        break;
    	case 3:
    	GUI.color = Color.yellow;
        goto Label_0041;
        break;
    	default:
    	GUI.color = Color.white;
        goto Label_0041;
        break;
    	
    }
    
    if (self)
    {
        GUI.color = Color.white;
        goto Label_0041;
    }
    if (!zombie)
    {
        Color white = Color.white;
        GUI.color = white;
        goto Label_0041;
    }
Label_0014:
    switch (7)
    {
        case 0:
            goto Label_0014;

        default:
        {
            if (1 == 0)
            {
            }
            Color red = Color.red;
            GUI.color = red;
            break;
        }
    }
Label_0041:
    single4 = this.guimanager.YRES(16f);
    Rect position = new Rect(0f, 0f, this.guimanager.YRES(16f), single4);
    float single5 = this.guimanager.YRES(4f);
    float single6 = this.guimanager.YRES(128f - (pz / 2f));
    position.center = new Vector2(this.guimanager.XRES(4f) + this.guimanager.YRES(px / 2f), single5 + single6);
    float angle = ry - 90f;
    if (angle <= 360f)
    {
        goto Label_00F2;
    }
Label_00E0:
    switch (2)
    {
        case 0:
            goto Label_00E0;

        default:
            angle -= 360f;
            break;
    }
Label_00F2:
    if (angle >= 0f)
    {
        goto Label_010C;
    }
Label_00FA:
    switch (6)
    {
        case 0:
            goto Label_00FA;

        default:
            angle += 360f;
            break;
    }
Label_010C:
    matrixx2 = GUI.matrix;
    Matrix4x4 matrixx = matrixx2;
    Vector2 center = position.center;
    GUIUtility.RotateAroundPivot(angle, center);
    if (!zombie)
    {
        GUI.DrawTexture(position, this.PlayerPosition);
        goto Label_014B;
    }
Label_0127:
    switch (7)
    {
        case 0:
            goto Label_0127;

        default:
            GUI.DrawTexture(position, this.ZombiePosition);
            break;
    }
Label_014B:
    GUI.matrix = matrixx;
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
	
	void DrawPlayerName(UnityEngine.Vector3 p, string name, AssemblyCSharp.CPlayerData playerData)
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
