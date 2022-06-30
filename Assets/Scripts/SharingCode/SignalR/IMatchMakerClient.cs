using System.Threading.Tasks;
using MechSharingCode.SignalR.DTO;

namespace MechSharingCode.SignalR
{
    public interface IMatchMakerClient
    {
        Task BattleCreated(BattleCreatedResponseData battleCreatedResponseData);
        Task MatchFound();
        Task ApprovalTimeout();
        Task ReturnToFindBattle();
    }
}
