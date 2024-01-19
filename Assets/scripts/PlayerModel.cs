using System;
using UnityEngine;

public class PlayerModel
{
      public event Action Death;
      public event Action<float> ChangedHealth;

      private float _maxHp = 100;
      private float _currentHp;

      public PlayerModel(){
          _currentHp = _maxHp;
      }

      public float GetCurrentHp()
      {
          return _currentHp;
      }

      public void SetNewHealth(float damage)
      { 
          _currentHp -= damage;
          if (_currentHp > 0)
              ChangedHealth?.Invoke(_currentHp);
          else
          {
              _currentHp = 0;
              Death?.Invoke();
          }
      }
}