using UnityEngine;

public class GoHomeNPC : NPCStrategy
{
    [SerializeField] private float speed;
    [SerializeField] private Transform homePoint;

    public GoHomeNPC(GameObject npc, float speed, Transform homePoint) : base(npc)
    {
        this.speed = speed;
        this.homePoint = homePoint;
    }

    public override void Act()
    {
        npc.transform.position = Vector3.MoveTowards(npc.transform.position, homePoint.transform.position,
                speed * Time.deltaTime);
    }
}
