using UnityEngine;

public enum PlayerActionType
{
  Create,
  Sell
}

[System.Serializable]
public struct PlayerAction
{
  public PlayerActionType type;
  public Ray ray;

  public PlayerAction(PlayerActionType type, Ray ray)
  {
    this.type = type;
    this.ray = ray;
  }
}