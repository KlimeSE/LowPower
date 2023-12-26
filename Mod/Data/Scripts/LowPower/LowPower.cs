using System.Collections.Generic;
using Sandbox.Game;
using Sandbox.ModAPI;
using VRage.Game;
using VRage.Game.Components;
using VRage.Game.ModAPI;
using VRageMath;


namespace klime.LowPower
{
    [MySessionComponentDescriptor(MyUpdateOrder.AfterSimulation)]
    public class LowPower : MySessionComponentBase
    {
        public override void Init(MyObjectBuilder_SessionComponent sessionComponent)
        {

        }

        public override void UpdateAfterSimulation()
        {
            MyAPIGateway.Utilities.ShowNotification("LowPowerABCDEF", 16, "Red");
        }

        protected override void UnloadData()
        {

        }
    }
}