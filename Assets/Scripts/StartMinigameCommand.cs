using Naninovel;

[CommandAlias("startMinigame")]
public class StartMinigameCommand : Command
{
    public override async UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        MinigameService minigameService = Engine.GetService<MinigameService>();
        await minigameService.StartGame();
    }
}
