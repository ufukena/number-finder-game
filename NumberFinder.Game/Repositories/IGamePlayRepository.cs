using NumberFinder.Game.Enums;

namespace NumberFinder.Game.Repositories
{
    public interface IGamePlayRepository
    {
        int SetTargetNumber(GameType gameType);
    }
}