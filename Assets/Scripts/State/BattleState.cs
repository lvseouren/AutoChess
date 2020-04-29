using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.State
{
    public class BattleState:BaseGameState
    {
        public override void Enter()
        {
            planTime = 60;
            realTime = 0;

            Debug.Log("进入战斗阶段");
            Debug.Log("检测是否多上了棋子，如果有则随机下一个，如果板凳区已满，则将该棋子放回卡池");
            Debug.Log("将对手的棋子以镜像的方式置入战场，战斗开始");
        }

        public override void Exit()
        {
            Debug.Log("战斗时间到，平局检测与处理");
        }

        public override void Execute()
        {
            base.Execute();

            Debug.Log("执行战斗逻辑");
        }
    }
}
