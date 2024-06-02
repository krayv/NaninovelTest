using DTT.MinigameMemory;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] MemoryGameManager gameManager;
    [SerializeField] MemoryGameSettings settings;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnGUI()
    {
        if (GUI.Button(new Rect(0, 0, 240, 60), "Start"))
        {
            gameManager.StartGame(settings);
        }
    }
}
