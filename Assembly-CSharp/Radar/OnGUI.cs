#region " Imports "
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
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
#endregion 

class Radar
{
	// Limited support!
	// You can only reference methods or fields defined in the class (not in ancestors classes)
	// Fields and methods stubs are needed for compilation purposes only.
	// Reflexil will automaticaly map current type, fields or methods to original references.
 void OnGUI()
{
    float single10;
    int num;
    Vector3 vector3;
    if (this.cscl != null)
    {
        goto Label_003F;
    }
Label_0010:
    switch (5)
    {
        case 0:
            goto Label_0010;

        default:
        {
            if (1 == 0)
            {
            }
            UnityEngine.Object obj2 = UnityEngine.Object.FindObjectOfType(typeof(Client));
            this.cscl = (Client) obj2;
            break;
        }
    }
Label_003F:
    if (this.LocalPlayer != null)
    {
        goto Label_0067;
    }
Label_004D:
    switch (2)
    {
        case 0:
            goto Label_004D;

        default:
            this.LocalPlayer = GameObject.Find("Player");
            break;
    }
Label_0067:
    single10 = this.guimanager.XRES(4f);
    float top = this.guimanager.YRES(4f);
    float width = this.guimanager.YRES(128f);
    float height = this.guimanager.YRES(128f);
    GUI.DrawTexture(new Rect(single10, top, width, height), this.RadarTexture);
    Texture2D textured2 = this.RadarTexture2;
    if (this.RadarTexture2 == null)
    {
        goto Label_012E;
    }
Label_00CE:
    switch (4)
    {
        case 0:
            goto Label_00CE;

        default:
        {
            float left = this.guimanager.XRES(4f);
            float single15 = this.guimanager.YRES(128f);
            float single16 = this.guimanager.YRES(128f);
            GUI.DrawTexture(new Rect(left, this.guimanager.YRES(4f), single15, single16), this.RadarTexture2);
            break;
        }
    }
Label_012E:
    this.DrawBase(this.base_pos.x, this.base_pos.z);
    int gameMode = PlayerControl.GetGameMode();
    if (gameMode != 0)
    {
        goto Label_022C;
    }
Label_0156:
    switch (2)
    {
        case 0:
            goto Label_0156;

        default:
        {
            Color blue = Color.blue;
            GUI.color = blue;
            this.DrawTeam(this.team_pos[0].x, this.team_pos[0].z);
            GUI.color = Color.red;
            this.DrawTeam(this.team_pos[1].x, this.team_pos[1].z);
            GUI.color = Color.green;
            this.DrawTeam(this.team_pos[2].x, this.team_pos[2].z);
            Color yellow = Color.yellow;
            GUI.color = yellow;
            this.DrawTeam(this.team_pos[3].x, this.team_pos[3].z);
            break;
        }
    }
Label_022C:
    num = 0;
    while (num < 0x20)
    {
        Transform transform4;
        bool flag;
        if (num != this.cscl.myindex)
        {
            goto Label_0250;
        }
    Label_0241:
        switch (1)
        {
            case 0:
                goto Label_0241;

            default:
                goto Label_0470;
        }
    Label_0250:
        if (this.botcontroller.PlayerData[num].Active)
        {
            goto Label_0273;
        }
    Label_0264:
        switch (1)
        {
            case 0:
                goto Label_0264;

            default:
                goto Label_0470;
        }
    Label_0273:
        if (this.botcontroller.PlayerData[num].Team == 0xff)
        {
            goto Label_0470;
        }
        if (this.botcontroller.PlayerData[num].Dead != 1)
        {
            goto Label_02B5;
        }
    Label_02A6:
        switch (5)
        {
            case 0:
                goto Label_02A6;

            default:
                goto Label_0470;
        }
    Label_02B5:
        flag = true;
        if (this.botcontroller.PlayerData[this.cscl.myindex].zombie)
        {
            goto Label_0361;
        }

        flag = true;
    Label_0322:
            goto Label_0361;
    Label_0352:
        switch (2)
        {
            case 0:
                goto Label_0352;

            default:
                goto Label_0470;
        }
    Label_0361:
        transform4 = this.botcontroller.Player[num].transform;
        Vector3 position = transform4.position;
        Transform transform = this.botcontroller.Player[num].transform;
        Vector3 vector2 = transform.eulerAngles;
        if (!this.botcontroller.PlayerData[this.cscl.myindex].zombie)
        {
            goto Label_03FE;
        }
    Label_03B7:
        switch (6)
        {
            case 0:
                goto Label_03B7;

            default:
                if (this.botcontroller.PlayerData[num].zombie)
                {
                    goto Label_03FE;
                }
                break;
        }
    Label_03D5:
        switch (3)
        {
            case 0:
                goto Label_03D5;

            default:
                this.DrawPlayer(position.x, position.z, vector2.y, false, true, this.botcontroller.PlayerData[num]);
                goto Label_0470;
        }
    Label_03FE:
        this.DrawPlayer(position.x, position.z, vector2.y, false, false, this.botcontroller.PlayerData[num]);
        this.DrawPlayerName(position, this.botcontroller.PlayerData[num].Name, this.botcontroller.PlayerData[num]);
        if (flag)
        {
            goto Label_0470;
        }
    Label_0438:
        switch (6)
        {
            case 0:
                goto Label_0438;

            default:
                if (this.botcontroller.PlayerData[this.cscl.myindex].zombie)
                {
                    goto Label_0470;
                }
                break;
        }
    Label_0460:
        switch (2)
        {
            case 0:
                goto Label_0460;

            default:
                break;
        }
    Label_0470:
        num++;
    }
Label_047C:
    switch (7)
    {
        case 0:
            goto Label_047C;

        default:
        {
            vector3 = this.LocalPlayer.transform.position;
            Transform transform6 = this.LocalPlayer.transform;
            Vector3 vector4 = transform6.eulerAngles;
            this.DrawPlayer(vector3.x, vector3.z, vector4.y, true, false, this.botcontroller.PlayerData[num]);
            if (PlayerControl.GetGameMode() != 1)
            {
                return;
            }
            break;
        }
    }
Label_04D8:
    switch (4)
    {
        case 0:
            goto Label_04D8;

        default:
        {
            float single17 = this.guimanager.XRES(4f);
            float single18 = this.guimanager.YRES(132f);
            string[] textArray2 = new string[6];
            textArray2[0] = "X: ";
            string text5 = vector3.x.ToString("0");
            textArray2[1] = text5;
            textArray2[2] = " Y: ";
            string text6 = vector3.y.ToString("0");
            textArray2[3] = text6;
            textArray2[4] = " Z: ";
            string text7 = vector3.z.ToString("0");
            textArray2[5] = text7;
            string text = string.Concat(textArray2);
            GUI.Label(new Rect(single17, single18, 200f, 20f), text);
            break;
        }
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
	
	void DrawPlayer(float px, float pz, float ry, bool self, bool zombie, AssemblyCSharp.CPlayerData playerData)
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
