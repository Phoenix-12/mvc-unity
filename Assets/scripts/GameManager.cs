using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject playerPrefab;
    private PlayerController _playerController;
    private PlayerModel _playerModel;

    public void Start()
    {
        _playerModel = new PlayerModel();
        
        var playerObject = Instantiate(playerPrefab, Vector3.zero, Quaternion.identity);
        var playerView = playerObject.GetComponent<PlayerView>();

        _playerController = new PlayerController(playerView, _playerModel);
        _playerController.Enable();
    }
}