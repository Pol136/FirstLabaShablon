using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using UnityEngine;

public class OhNoPlayer : NPCStrategy
{
    public OhNoPlayer(GameObject npc) : base(npc) { }

    public override void Act()
    {
        Debug.Log("Oh No, Player!!!");
    }

}
