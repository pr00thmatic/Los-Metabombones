using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : NonPersistentSingleton<InputManager> {
  public static TheInput.PlayerControlActions Player { get => Input.PlayerControl; }

  static TheInput _input;
  public static TheInput Input { get {
      if (_input == null) _input = new TheInput();
      return _input;
    }
  }

  void OnEnable () {
    Input.Enable();
  }
}
