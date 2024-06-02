using DTT.MinigameMemory;
using Naninovel;
using Naninovel.UI;
using UnityEngine;

public class DTTGameStarter : CustomUI
{
    [SerializeField]
    private MemoryGameManager _gameManager;

    [SerializeField]
    private MemoryGameSettings _gameSettings;

    [SerializeField]
    private PlayScript _playScript;

    public void StartGame()
    {
        _gameManager.StartGame(_gameSettings);
        _gameManager.Finish += OnComplete;
    }

    private void OnComplete(MemoryGameResults results)
    {
        _playScript.Play();
    }
}
