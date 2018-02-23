using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGTIN_DecodeEncode.Logic
{
    public class SGTIN
    {
        public int NumberOfBits { get; }

        public int Filter { get; set; }
        public int Partition { get; set; }
        public int CompanyPerfix { get; set; }
        public int ItemReference { get; set; }
        public int SerialNumber { get; set; }

        public string ConvertHexToListOfInts(char[] _hexValue, int numberOfBits)
        {
            StringBuilder builder = new StringBuilder(numberOfBits);

            for (int i = 0; i < _hexValue.Length; i++)
            {
                int intValue = Convert.ToInt32(_hexValue[i].ToString(), 16);
                builder.Append(Convert.ToString(intValue, 2).PadLeft(4, '0'));
            }

            return builder.ToString();
        }

        public int GetNumberOfBitsForCompanyPrefix(int partition)
        {
            switch (partition)
            {
                case 0:
                    return 40;
                case 1:
                    return 37;
                case 2:
                    return 34;
                case 3:
                    return 30;
                case 4:
                    return 27;
                case 5:
                    return 24;
                case 6:
                    return 20;
            }

            throw new IndexOutOfRangeException("Partition does not exists !!");
        }

        public int GetNumberOfBitsForItemReference(int partition)
        {
            switch (partition)
            {
                case 0:
                    return 4;
                case 1:
                    return 7;
                case 2:
                    return 10;
                case 3:
                    return 14;
                case 4:
                    return 17;
                case 5:
                    return 20;
                case 6:
                    return 24;
            }

            throw new IndexOutOfRangeException("Partition does not exists !!");
        }

        public int GetSGTINNumberOfBits(string typeOfSGTINS)
        {
            switch (typeOfSGTINS)
            {
                case "SGTIN-64":
                    throw new NotImplementedException("SGTIN-64 is not implemented");
                case "SGTIN-96":
                    return 96;
                case "SGTIN-198":
                    throw new NotImplementedException("SGTIN-198 is not implemented");
                default:
                    throw new ArgumentException("There is no such SGTIN !!");
            }
        }
    }
}


#region Tested hex->int->List<int>() - it was 2x slower than with strings

//public List<int> ConvertHexToListOfInts(string _hexValue, int numberOfBits)
//{
//    string hexValue = "3074257BF7194E4000001A85";

//    List<int> values = new List<int>(numberOfBits);

//    for (int i = 0; i < hexValue.Length; i++)
//    {
//        int intValue = (int)hexValue[i] < (int)'A' ? ((int)hexValue[i] - (int)'0') : 10 + ((int)hexValue[i] - (int)'A');

//        values.AddRange(ConvertIntToListOfBits(intValue));
//    }

//    return values;
//}


//private List<int> ConvertIntToListOfBits(int value)
//{
//    List<int> listOfBits = new List<int>();
//    BitArray bits = new BitArray(new int[] { value });

//    for (int j = 0; j < 4; j++)
//    {
//        listOfBits.Add(bits[j] ? 1 : 0);
//    }

//    listOfBits.Reverse();

//    return listOfBits;
//}

#endregion