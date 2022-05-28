using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GetStars
{
    public static int total = 0;
    public static int St1 = 0;
    public static int St2 = 0;
    public static int St3 = 0;
    public static int St4 = 0;
    public static int St5 = 0;
    public static int St6 = 0;
    public static int St7 = 0;
    public static int St8 = 0;
    public static int St9 = 0;
    public static int St10 = 0;
    public static int St11 = 0;
    public static int St12 = 0;
    public static int St13 = 0;
    public static int St14 = 0;
    public static int St15 = 0;
    public static int St16 = 0;

    public static string StarChanger(int lvl, int count)
    {
        int i;
        if(lvl == 1)
        {
            i = count - St1;
            if (i > 0)
            {
                St1 = count;
                total += i;
                return i.ToString();
            }
            return "0";
        }
        else if (lvl == 2)
        {
            i = count - St2;
            if (i > 0)
            {
                St2 = count;
                total += i;
                return i.ToString();
            }
            return "0";
        }
        else if (lvl == 3)
        {
            i = count - St3;
            if (i > 0)
            {
                St3 = count;
                total += i;
                return i.ToString();
            }
            return "0";
        }
        else if (lvl == 4)
        {
            i = count - St4;
            if (i > 0)
            {
                St4 = count;
                total += i;
                return i.ToString();
            }
            return "0";
        }
        else if (lvl == 5)
        {
            i = count - St5;
            if (i > 0)
            {
                St5 = count;
                total += i;
                return i.ToString();
            }
            return "0";
        }
        else if (lvl == 6)
        {
            i = count - St6;
            if (i > 0)
            {
                St6 = count;
                total += i;
                return i.ToString();
            }
            return "0";
        }
        else if (lvl == 7)
        {
            i = count - St7;
            if (i > 0)
            {
                St7 = count;
                total += i;
                return i.ToString();
            }
            return "0";
        }
        else if (lvl == 8)
        {
            i = count - St8;
            if (i > 0)
            {
                St8 = count;
                total += i;
                return i.ToString();
            }
            return "0";
        }
        else if (lvl == 9)
        {
            i = count - St9;
            if (i > 0)
            {
                St9 = count;
                total += i;
                return i.ToString();
            }
            return "0";
        }
        else if (lvl == 10)
        {
            i = count - St10;
            if (i > 0)
            {
                St10 = count;
                total += i;
                return i.ToString();
            }
            return "0";
        }
        else if (lvl == 11)
        {
            i = count - St11;
            if (i > 0)
            {
                St11 = count;
                total += i;
                return i.ToString();
            }
            return "0";
        }
        else if (lvl == 12)
        {
            i = count - St12;
            if (i > 0)
            {
                St12 = count;
                total += i;
                return i.ToString();
            }
            return "0";
        }
        else if (lvl == 13)
        {
            i = count - St13;
            if (i > 0)
            {
                St13 = count;
                total += i;
                return i.ToString();
            }
            return "0";
        }
        else if (lvl == 14)
        {
            i = count - St14;
            if (i > 0)
            {
                St14 = count;
                total += i;
                return i.ToString();
            }
            return "0";
        }
        else if (lvl == 15)
        {
            i = count - St15;
            if (i > 0)
            {
                St15 = count;
                total += i;
                return i.ToString();
            }
            return "0";
        }
        else
        {
            i = count - St16;
            if (i > 0)
            {
                St16 = count;
                total += i;
                return i.ToString();
            }
            return "0";
        }
    }

    public static string GetTotal()
    {
        return total.ToString();
    }
}
