using System.Threading.Tasks;
using MechSharingCode.SignalR.DTO;
using MechSharingCode.src.SignalR.DTO;

namespace MechSharingCode.SignalR
{
    public interface IMatchMakerServer
    {
        Task<FindBattleResponseData> FindBattle(FindBattleRequestData request);
        Task AcceptMatch();
        /// <summary>
        /// - While finding battle, cancel find battle
        /// - While in lobby, decline the match with punishment
        /// </summary>
        Task CancelMatch();
    }
}
