using System;
using System.Collections.Generic;
using System.Text;

namespace boots
{
    class Class_Boots
    {
        enum BootType {football=1,cowboy,wellington};
        int bootType;
        //int football = (int)Type.football;
        //int cowboy = (int)Type.cowboy;
        //int wellington = (int)Type.wellington;
        public int condition = 100;

        public Class_Boots(int type)
        {
            if (bootType == 1)
            {
                bootType = (int)BootType.football;
                Console.WriteLine(bootType);
            }
            else

                if (bootType == 2)
            {
                bootType = (int)BootType.cowboy;
                Console.WriteLine(bootType);
            }
            else
            {
                bootType = (int)BootType.wellington;
                Console.WriteLine(bootType);
            }
        }

            public void Walking()
            {
            string strwalk = Console.ReadLine();
            int walk = int.Parse(strwalk);
            double condition = 100;
            }

    }
}
