using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerController : MonoBehaviour
{
  public GameObject mobPrefab;
  public Vector3 startPoint;

  // Use this for initialization
  void Start()
  {
    InvokeRepeating("SendWave", 1.0f, 5.0f);
  }

  // Update is called once per frame
  void Update()
  {

  }

  void SendWave()
  {
    Instantiate(mobPrefab, startPoint, Quaternion.identity);
  }
}
