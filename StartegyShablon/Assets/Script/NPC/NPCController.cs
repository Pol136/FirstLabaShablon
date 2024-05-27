using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;
    public Transform[] points;
    public float speed;
    public Transform homePoint;
    public float normRadius = 2f;
    public float bigRadius = 5f;

    private NPCStrategy behavior;

    private MoveByPoints pointsMove;
    private OhNoPlayer ohno;
    private GoHomeNPC home;

    private void Start()
    {
        
        pointsMove = new MoveByPoints(enemy, points, speed);
        ohno = new OhNoPlayer(enemy);
        home = new GoHomeNPC(enemy, speed, homePoint);

        behavior = new MoveByPoints(enemy, points, speed);
    }

    private void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);

        if (distanceToPlayer <= normRadius)
        {
            behavior = ohno;
        }
        else if (distanceToPlayer <= bigRadius)
        {
            behavior = home;
        }
        else
        {
            behavior = pointsMove;
        }

        behavior.Act();
    }

}
