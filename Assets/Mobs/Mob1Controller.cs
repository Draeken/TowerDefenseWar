using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mob1Controller : MonoBehaviour
{

  private GameObject targetBase;
  private NavMeshAgent agent;

  // Use this for initialization
  void Start()
  {
    targetBase = GameObject.Find("TargetBase");
    agent = GetComponent<NavMeshAgent>();
    agent.destination = targetBase.transform.position;
  }

  // Update is called once per frame
  void Update()
  {

  }
}
