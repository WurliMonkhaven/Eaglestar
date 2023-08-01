using System.Collections;

namespace Eaglestar.Utilities
{
    internal static class BitArrayUtilities
    {
        public static ushort ToUShort(this BitArray bitArray)
        {
            ushort result = 0;
            for(int i = 0; i < 16; i++)
            {
                if (bitArray[i])
                {
                    result |= (ushort)(1 << i);
                }
            }

            return result;
        }

        public static BitArray ToBitArray(this ushort value)
        {
            int intValue = value;
            var intBitArray = new BitArray(new[] {intValue});

            //Revert to ushort
            var bitArray = new BitArray(16);
            for(int i = 0; i <= 15; i++)
            {
                bitArray[i] = intBitArray[i];
            }

            return bitArray;
        }
    }
}
