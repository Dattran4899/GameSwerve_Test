namespace MechSharingCode.Blueprints.Battle
{
    using System;
    using System.Collections.Generic;
    using MechSharingCode.WebService.Models.Inventory;

    public class BattleConfigRecord
    {
        public BattleMode                     Mode           { get; set; }
        public string                         ConfigName     { get; set; }
        public string                         Description    { get; set; }
        public float                          AmountTime     { get; set; }
        public Dictionary<BattleState, float> StatesCoolDown { get; set; }
    }

    [Flags]
    public enum BattleState
    {
        None             = 0,
        SelectLord       = 1 << 0,
        PreBattle        = 1 << 1,
        Overview         = 1 << 2,
        PrepareMechaTurn = 1 << 3,
        MasterTurn       = 1 << 4,
        MechaTurn        = 1 << 5,
        AnimationPresent = 1 << 6,
        EndBattle        = 1 << 7,
        All              = SelectLord | PreBattle | Overview | PrepareMechaTurn | MasterTurn | MechaTurn | AnimationPresent | EndBattle
    }
}