using Naninovel;

[InitializeAtRuntime]
public class MinigameService : IEngineService
{
    private readonly IUIManager uiManager;

    private MinigameConfiguration config;

    private DTTGameStarter starter;

    public MinigameService(MinigameConfiguration config,
            IUIManager uiManager)
    {
        this.uiManager = uiManager;
        this.config = config;
    }

    public void DestroyService()
    {

    }

    public async UniTask StartGame()
    {
        starter = await uiManager.AddUIAsync(config.MinigamePrefab.gameObject) as DTTGameStarter;
        await starter.InitializeAsync();
        starter.StartGame();
    }

    public void CloseGame()
    {
        starter.gameObject.SetActive(false);
    }

    public UniTask InitializeServiceAsync()
    {
        return UniTask.CompletedTask;
    }

    public void ResetService()
    {

    }
}
