using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.State
{
    public class BeforeBattleState:BaseGameState
    {
        public override void Enter()
        {
            planTime = 5;
            realTime = 0;
            Debug.Log("进入战前阶段");
            Debug.Log("匹配对手");
            Debug.Log("锁定移动棋子位置");
            Debug.Log("战场上的棋子变成不可出售状态");
        }

        public override void Exit()
        {

        }

        public override void Execute()
        {
            base.Execute();
            
        }
    }
}
