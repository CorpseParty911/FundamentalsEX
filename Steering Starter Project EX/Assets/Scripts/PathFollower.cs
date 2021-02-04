using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : Kinematic
{
    PathFollow myMoveType;
    LookWhereGoing myRotateType;

    public GameObject[] path;

    // Start is called before the first frame update
    void Start()
    {
        myMoveType = new PathFollow();
        myMoveType.character = this;
        myMoveType.path = path;
        myMoveType.target = path[0];

        myRotateType = new LookWhereGoing();
        myRotateType.character = this;
    }

    // Update is called once per frame
    protected override void Update()
    {
        steeringUpdate = new SteeringOutput();
        steeringUpdate.linear = myMoveType.getSteering().linear;
        steeringUpdate.angular = myRotateType.getSteering().angular;
        base.Update();
    }
}
