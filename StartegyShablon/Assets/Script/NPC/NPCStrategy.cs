using UnityEngine;
public abstract class NPCStrategy
{
    protected GameObject npc;
    public NPCStrategy(GameObject gameObject)
    {
        npc = gameObject;
    }
    public abstract void Act();
}
