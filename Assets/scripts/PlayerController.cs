using UnityEngine;

public class PlayerController
{
    private PlayerView _playerView;
    private PlayerModel _playerModel;

    public PlayerController(PlayerView view, PlayerModel model)
    {
        _playerView = view;
        _playerModel = model;
    }
    

    public void Enable()
    {
        _playerModel.Death += Death;
        _playerModel.ChangedHealth += ChangeHealth;

        _playerView.Second += Update;
    }
    
    private void Update()
    {
        _playerModel.SetNewHealth(10);
    }

    private void ChangeHealth(float  health){
        PlayerView.ChangeHealth(health);
    }

    private void Death(){
        _playerView.Death();
        Disable();
    }

    public void Disable()
    {
        _playerModel.Death -= Death;
        _playerModel.ChangedHealth -= ChangeHealth;
    }
}