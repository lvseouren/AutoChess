using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.State
{
    public class BaseGameState
    {
        public float planTime;
        public float realTime;
        public virtual void Enter()
        {
            Debug.Log("BaseGameState Enter");
        }

        public virtual void Exit()
        {

        }

        public virtual void Execute()
        {
            realTime = realTime + Time.deltaTime;
        }

        public virtual bool CheckIsAlive()
        {
            return realTime < planTime;
        }
    }
}
