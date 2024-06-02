using Naninovel;

[CommandAlias("closeMinigame")]
public class CloseMinigameCommand : Command
{
    public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        MinigameService minigameService = Engine.GetService<MinigameService>();
        minigameService.CloseGame();
        return UniTask.CompletedTask;
    }
}
