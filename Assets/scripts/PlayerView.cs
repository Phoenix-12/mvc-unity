using System;
using UnityEngine;

public class PlayerView : MonoBehaviour 
{
    public event Action Second;
    public float time;
    public static void ChangeHealth(float health)
    {
        Debug.Log(health);
    }
    
    public void Death()
    {
        Debug.Log("Death");
    }
    
    private void FixedUpdate()
    {
        time += Time.deltaTime;
        if (time > 1)
        {
            time = 0;
            Second?.Invoke();
        }
    }
}