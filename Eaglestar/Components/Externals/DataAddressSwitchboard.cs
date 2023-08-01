using Eaglestar.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eaglestar.Components.Externals
{
    internal class DataAddressSwitchboard
    {
        // 16 switches are easy to represent with a 16 bit unsigned integer.
        public ushort SwitchPositions { get; private set; } = 0;

        public void SetSwitchPositions(ushort switchPositions)
        {
            SwitchPositions = switchPositions;
        }

        public void SetSwitchPositions(BitArray switchPositions)
        {
            SwitchPositions = switchPositions.ToUShort();
        }
    }
}
