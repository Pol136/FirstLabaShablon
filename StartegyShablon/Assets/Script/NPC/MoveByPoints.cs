using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class MoveByPoints : NPCStrategy
{
    [SerializeField] private Transform[] points;
    [SerializeField] private float speed;

    private int pointIndex = 0;

    public MoveByPoints(GameObject npc, Transform[] points, float speed) : base(npc)
    {
        this.points = points;
        this.speed = speed;
    }

    public override void Act()
    {
        if (pointIndex <= points.Length - 1)
        {
            npc.transform.position = Vector3.MoveTowards(npc.transform.position, points[pointIndex].transform.position,
                speed * Time.deltaTime);
            if (npc.transform.position == points[pointIndex].transform.position)
            {
                pointIndex++;
            }
            if (pointIndex == points.Length)
            {
                pointIndex = 0;
            }
        }
    }

}
