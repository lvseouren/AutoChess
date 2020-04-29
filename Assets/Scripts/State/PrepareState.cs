using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.State
{
    public class PrepareState:BaseGameState
    {
        public override void Enter()
        {
            planTime = 60;
            realTime = 0;
            Debug.Log("进入准备阶段，生成可购买棋子，弹出商店界面;");
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
