using System;
using System.Collections.Generic;

namespace BattelShips
{
    public class BattleshipField
    {
        Dictionary<int, int> ShipskeyValuePairs = new Dictionary<int, int>()  { { 1, 4 },
                                                                                { 2, 3 },
                                                                                { 3, 2 },
                                                                                { 4, 1 } };
        private const bool Error = true;

        private static Dictionary<int, int> GetEmptyDctonary()
        {
            return new Dictionary<int, int>() {  { 1, 0 },
                                                 { 2, 0 },
                                                 { 3, 0 },
                                                 { 4, 0 } };
        }

        public static bool ValidateBattlefield(int[,] field)
        {
           var curr = GetEmptyDctonary();
            // Write your magic here

            int maxrow = field.GetLength(0) - 1;
            int maxcolum = field.GetLength(1) - 1;

            int currship = 0;
            for (int r = 1; r < maxrow - 1; r++)
            {
                for (int c = 1; c < maxcolum - 1; c++)
                {
                    if (field[r, c] == 1)
                    {
                        if(HorizontLookUp(field, r, c) > 0) ;
                        {
                            
                        }
                    }

                }
            }


            return true;
        }
        #region old
        /// <summary>
        /// test all Horisontal line (with diaganales)
        /// </summary>
        /// <param name="field"></param>
        /// <param name="ShipsvaluePairs"></param>
        /// <returns>true if error</returns>
        //private static bool HorizontalTest(int[,] field, Dictionary<int,int> ShipsvaluePairs)
        //{   //проверим первый ряд

        //    int maxrow = field.GetLength(0)-1;
        //    int maxcolum = field.GetLength(1)-1;

        //    if ((field[0, 0] + field[1, 1]) > 1)
        //        return Error;

        //    for(int c = 1; c< maxcolum - 1; c++)
        //    {
        //        if (field[0, c] + field[1, c - 1] > 1 ||
        //           field[0, c] + field[1, c + 1] > 1)
        //            return Error;
        //    }
        //    if ((field[0, maxcolum] + field[1, maxcolum - 1]) > 1)
        //        return Error;

        //    for (int r = 1; r < maxrow-1; r++)
        //    {
        //        for(int c = 1; c < maxcolum-1; c++)
        //        {
        //            if(field[r,c] + field[r,c+1] > 1 || field[r, c] + field[r+1,c-1] > 1)
        //                return Error;
        //        }
        //    }

        //    if ((field[maxrow, 0] + field[maxrow, 1]) > 1)
        //        return Error;

        //    for (int c = 1; c < maxcolum - 1; c++)
        //    {
        //        if (field[maxrow, c] + field[maxrow-1, c - 1] > 1 ||
        //           field[maxrow, c] + field[maxrow - 1, c + 1] > 1 )
        //            return Error;
        //    }


        //    return false;
        //}
        #endregion
        private static int HorizontLookUp(int[,] field, int startrow,int startcolum)
        {   //проверим первый ряд
            int maxcolum = field.GetLength(1) - 1;
            bool hasnextrow = startrow < field.GetLength(0)-1-1;
            bool hasprevrow = startrow > 0;
            
            int currship =0;
            if (startcolum > 0 && hasnextrow)
            {
                if (field[startrow + 1, startcolum - 1] > 0)
                    return -1;
            }
                for (int c = startcolum; c < maxcolum - 1; c++)
                {
                    if (field[startrow, c] == 1)
                    {
                        currship++;
                        if (hasnextrow)
                        {
                            if (field[startrow + 1, c] != 0)
                                return -1;
                        }
                    }
                    else
                    {
                        if(hasnextrow && field[startrow+1, c] <= 0)
                        return currship;
                        
                    }
                        
                }
            

            return -1;
        }

        private int VerticalTest(int[,] field, Dictionary<int, int> ShipsvaluePairs)
        {
            return false;
        }


    }
}
