using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;



[System.Serializable]
public class PlayerActionEvent : UnityEvent<PlayerAction> { }

public class PlayerController : MonoBehaviour
{
  public PlayerActionEvent actionEvent;

  private new Camera camera;
  // Use this for initialization
  void Start()
  {
    camera = GetComponent<Camera>();
    if (actionEvent == null)
    {
      actionEvent = new PlayerActionEvent();
    }
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetMouseButtonDown(0))
    {
      actionEvent.Invoke(new PlayerAction(
        PlayerActionType.Create,
        camera.ScreenPointToRay(Input.mousePosition)));
    }
  }
}
