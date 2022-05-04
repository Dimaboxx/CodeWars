using System;
using System.Collections.Generic;
using System.Diagnostics;
//using System.Diagnostics;

namespace BattelShips
{
    public class BattleshipField
    {
        public static readonly Dictionary<int, int> ReferenceFleet = new Dictionary<int, int>()  {  { 1, 4 },
                                                                                                    { 2, 3 },
                                                                                                    { 3, 2 },
                                                                                                    { 4, 1 } };
        private const bool Error = true;
        private const int BlokedField = -1;
        private const int ProcessedShipBase = 10;
        private const int maxShipLength = 4;

        private static  Dictionary<int, int> GetEmptyDctonary()
        {
            return new Dictionary<int, int>() {  { 1, 0 },
                                                 { 2, 0 },
                                                 { 3, 0 },
                                                 { 4, 0 } };
        }

        public static bool ValidateBattlefield(int[,] field)
        {
           bool valid = true;
           var currentfleet = GetEmptyDctonary();
            // Write your magic here

            int maxrow = field.GetLength(0);
            int maxcolum = field.GetLength(1);

            for (int r = 0; r < maxrow; r++)
            {
                for (int c = 0; c < maxcolum; c++)
                {
//                    Debug.WriteLine($"row:{r} col:{c}");
                    if (field[r, c] == 1)
                    {
 //                       DebugField(field);
                        var res = LookUp(field, r, c);
 //                       DebugField(field);
                        if (res == 0 || res > maxShipLength) { 
                            valid = false;
                            return valid;
                        }
                        else
                            currentfleet[res]++;
                    }
                }
            }

            #region test here number ship

            for(int s = 1; s <= maxShipLength; s++)
            {
                if (currentfleet[s] != ReferenceFleet[s])
                {
                    valid = false;
                }
            }
            #endregion
            //
            return valid;
        }

        /// returns 0 if error
        /// else return lenght of ship
        private static int LookUp(int[,] field, int startrow,int startcolum)
        {   

            int res = 0;
            int ship = 1;
            if (startcolum > 0)
            {
                if (field[startrow, startcolum - 1] > 0)
                {
                    return 0;
                }
                if (haspreviosrow(field, startrow))
                {
                    if (field[startrow - 1, startcolum - 1] > 0)
                        return 0;
                }
                if (hasnextrow(field, startrow))
                    if (field[startrow + 1, startcolum - 1] > 0)
                        return 0;
            }
           
            if (startrow > 0)
            {
                if (field[startrow - 1, startcolum] > 0)
                {
                    return 0;
                }
                if (hasprevioscolumn(field, startcolum))
                {
                    if (field[startrow - 1, startcolum - 1] > 0)
                        return 0;
                }
                if (hasnextcolumn(field, startcolum))
                    if (field[startrow - 1, startcolum + 1] > 0)
                        return 0;
            }




            if (hasnextrow(field, startrow))
            {
                if(field[startrow+1, startcolum] > 0)
                {
                    res++;
                    ship = VerticalTest( field,  startrow,  startcolum);
                }
            }
            if (hasnextcolumn(field,startcolum))
            {
                if (field[startrow , startcolum+1] > 0)
                {
                    res++;
                    ship = HorisontalTest(field, startrow, startcolum);
                }
            }
            if(hasnextcolumn(field,startcolum)&hasnextrow(field,startrow))
                if (field[startrow+1, startcolum + 1] > 0)
                {
                    res++;
                }
            if (res>1)
                return 0;
            return ship;


        }

        private static int VerticalTest(int[,] field, int startrow, int startcolum)
        {
            int currentrow = startrow;
            int currentcolumn = startcolum;
            int currship = 0;


            while (hasnextrow(field, currentcolumn))
            {
                bool exit = false;
                if (field[currentrow, currentcolumn] > 0)
                    currship++;
                else
                {
                    field[currentrow, currentcolumn] =BlokedField;
                    exit = true;
                }
                if (hasnextcolumn(field, currentrow))
                {
                    if (field[currentrow , currentcolumn +1] > 0)
                    {
                        return 0;
                    }
                    else
                        field[currentrow , currentcolumn +1] =BlokedField;
                }
                if (hasprevioscolumn(field, currentcolumn))
                {
                    if (field[currentrow, currentcolumn -1] > 0)
                    {
                        return 0;
                    }
                    else
                        field[currentrow, currentcolumn - 1] = BlokedField;
                }
                if (exit) break;
                currentrow++;
            }
            for (int r = 0; r < currship; r++)
                field[startrow + r, startcolum ] = currship + ProcessedShipBase;
            return currship;
        }
        private static int HorisontalTest(int[,] field, int startrow, int startcolum)
        {
            int currentrow = startrow;
            int currentcolumn = startcolum;
            int currship = 0;

            while (hasnextcolumn(field, currentcolumn))
            {
                bool exit = false;
                if (field[currentrow, currentcolumn] > 0)
                    currship++;
                else
                {
                    field[currentrow, currentcolumn] =BlokedField;
                    exit = true;
                }
                if (hasnextrow(field, currentrow))
                {
                    if (field[currentrow + 1, currentcolumn] > 0)
                    {
                        return 0;
                    }
                    else
                        field[currentrow + 1, currentcolumn] =BlokedField;
                }
                if (exit) break;
                currentcolumn++;
            }
            for(int c = 0; c < currship; c++)
                field[startrow, startcolum + c] = currship + ProcessedShipBase;

            return currship;
        }
        private static bool hasnextrow(int[,] field, int currentrow)
        {
            return currentrow < field.GetLength(0);
        }
        private static bool hasnextcolumn(int[,] field, int currentcolumn)
        {
            return currentcolumn < field.GetLength(1);
        }
        private static bool hasprevioscolumn(int[,] field, int currentcolumn)
        {
            return currentcolumn > 0;
        }
        private static bool haspreviosrow(int[,] field, int currentrow)
        {
            return currentrow > 0;
        }
        private static void DebugField(int[,] field)
        {
            int maxrow = field.GetLength(0);
            int maxcolum = field.GetLength(1);
            for (int r = 0; r < maxrow; r++)
            {
                for (int c = 0; c < maxcolum; c++)
                {
                    string cell = String.Format("{0,3},", field[r, c]);
                   Debug.Write(cell);

                }
                Debug.WriteLine("");
            }
            Debug.WriteLine("----------------------------------");
        }
 

    }
}
