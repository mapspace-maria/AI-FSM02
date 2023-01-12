using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBaseFSM : StateMachineBehaviour
{
    public GameObject robot;
    public UnityEngine.AI.NavMeshAgent agent;
    public GameObject player;

    public float speed = 2f;
    public float rotSpeed = 2f;
    public float accuracy = 3f;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        robot = animator.gameObject;
        player = robot.GetComponent<RobotController>().player;
        agent = robot.GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
}
