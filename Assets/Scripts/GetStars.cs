using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GetStars
{
    public static bool flag = true;
    public static string StarChanger(int lvl, int count)
    {
        int i;
        if(lvl == 1)
        {
            if (PlayerPrefs.HasKey("St1"))
            {
                i = count - PlayerPrefs.GetInt("St1");
                if (i > 0)
                {
                    PlayerPrefs.SetInt("St1", count);
                    Debug.Log(PlayerPrefs.GetInt("St1"));
                    if (PlayerPrefs.HasKey("TotalStar"))
                    {   
                        PlayerPrefs.SetInt("TotalStar", PlayerPrefs.GetInt("TotalStar") + i);
                    }
                    else
                    {
                        PlayerPrefs.SetInt("TotalStar", i);
                    }
                    return i.ToString();
                }
                return "0";
            }
            PlayerPrefs.SetInt("St1", count);
            return count.ToString();
        }
        else if (lvl == 2)
        {
            if (PlayerPrefs.HasKey("St2"))
            {
                i = count - PlayerPrefs.GetInt("St2");
                if (i > 0)
                {
                    PlayerPrefs.SetInt("St2", count);
                    if (PlayerPrefs.HasKey("TotalStar"))
                    {
                        PlayerPrefs.SetInt("TotalStar", PlayerPrefs.GetInt("TotalStar") + i);
                    }
                    else
                    {
                        PlayerPrefs.SetInt("TotalStar", i);
                    }
                    return i.ToString();
                }
                return "0";
            }
            PlayerPrefs.SetInt("St2", count);
            return count.ToString();
        }
        else if (lvl == 3)
        {
            if (PlayerPrefs.HasKey("St3"))
            {
                i = count - PlayerPrefs.GetInt("St3");
                if (i > 0)
                {
                    PlayerPrefs.SetInt("St3", count);
                    if (PlayerPrefs.HasKey("TotalStar"))
                    {
                        PlayerPrefs.SetInt("TotalStar", PlayerPrefs.GetInt("TotalStar") + i);
                    }
                    else
                    {
                        PlayerPrefs.SetInt("TotalStar", i);
                    }
                    return i.ToString();
                }
                return "0";
            }
            PlayerPrefs.SetInt("St3", count);
            return count.ToString();
        }
        else if (lvl == 4)
        {
            if (PlayerPrefs.HasKey("St4"))
            {
                i = count - PlayerPrefs.GetInt("St4");
                if (i > 0)
                {
                    PlayerPrefs.SetInt("St4", count);
                    if (PlayerPrefs.HasKey("TotalStar"))
                    {
                        PlayerPrefs.SetInt("TotalStar", PlayerPrefs.GetInt("TotalStar") + i);
                    }
                    else
                    {
                        PlayerPrefs.SetInt("TotalStar", i);
                    }
                    return i.ToString();
                }
                return "0";
            }
            PlayerPrefs.SetInt("St4", count);
            return count.ToString();
        }
        else if (lvl == 5)
        {
            if (PlayerPrefs.HasKey("St5"))
            {
                i = count - PlayerPrefs.GetInt("St5");
                if (i > 0)
                {
                    PlayerPrefs.SetInt("St5", count);
                    if (PlayerPrefs.HasKey("TotalStar"))
                    {
                        PlayerPrefs.SetInt("TotalStar", PlayerPrefs.GetInt("TotalStar") + i);
                    }
                    else
                    {
                        PlayerPrefs.SetInt("TotalStar", i);
                    }
                    return i.ToString();
                }
                return "0";
            }
            PlayerPrefs.SetInt("St5", count);
            return count.ToString();
        }
        else if (lvl == 6)
        {
            if (PlayerPrefs.HasKey("St6"))
            {
                i = count - PlayerPrefs.GetInt("St6");
                if (i > 0)
                {
                    PlayerPrefs.SetInt("St6", count);
                    if (PlayerPrefs.HasKey("TotalStar"))
                    {
                        PlayerPrefs.SetInt("TotalStar", PlayerPrefs.GetInt("TotalStar") + i);
                    }
                    else
                    {
                        PlayerPrefs.SetInt("TotalStar", i);
                    }
                    return i.ToString();
                }
                return "0";
            }
            PlayerPrefs.SetInt("St6", count);
            return count.ToString();
        }
        else if (lvl == 7)
        {
            if (PlayerPrefs.HasKey("St7"))
            {
                i = count - PlayerPrefs.GetInt("St7");
                if (i > 0)
                {
                    PlayerPrefs.SetInt("St7", count);
                    if (PlayerPrefs.HasKey("TotalStar"))
                    {
                        PlayerPrefs.SetInt("TotalStar", PlayerPrefs.GetInt("TotalStar") + i);
                    }
                    else
                    {
                        PlayerPrefs.SetInt("TotalStar", i);
                    }
                    return i.ToString();
                }
                return "0";
            }
            PlayerPrefs.SetInt("St7", count);
            return count.ToString();
        }
        else if (lvl == 8)
        {
            if (PlayerPrefs.HasKey("St8"))
            {
                i = count - PlayerPrefs.GetInt("St8");
                if (i > 0)
                {
                    PlayerPrefs.SetInt("St8", count);
                    if (PlayerPrefs.HasKey("TotalStar"))
                    {
                        PlayerPrefs.SetInt("TotalStar", PlayerPrefs.GetInt("TotalStar") + i);
                    }
                    else
                    {
                        PlayerPrefs.SetInt("TotalStar", i);
                    }
                    return i.ToString();
                }
                return "0";
            }
            PlayerPrefs.SetInt("St8", count);
            return count.ToString();
        }
        else if (lvl == 9)
        {
            if (PlayerPrefs.HasKey("St9"))
            {
                i = count - PlayerPrefs.GetInt("St9");
                if (i > 0)
                {
                    PlayerPrefs.SetInt("St9", count);
                    if (PlayerPrefs.HasKey("TotalStar"))
                    {
                        PlayerPrefs.SetInt("TotalStar", PlayerPrefs.GetInt("TotalStar") + i);
                    }
                    else
                    {
                        PlayerPrefs.SetInt("TotalStar", i);
                    }
                    return i.ToString();
                }
                return "0";
            }
            PlayerPrefs.SetInt("St9", count);
            return count.ToString();
        }
        else if (lvl == 10)
        {
            if (PlayerPrefs.HasKey("St10"))
            {
                i = count - PlayerPrefs.GetInt("St10");
                if (i > 0)
                {
                    PlayerPrefs.SetInt("St10", count);
                    if (PlayerPrefs.HasKey("TotalStar"))
                    {
                        PlayerPrefs.SetInt("TotalStar", PlayerPrefs.GetInt("TotalStar") + i);
                    }
                    else
                    {
                        PlayerPrefs.SetInt("TotalStar", i);
                    }
                    return i.ToString();
                }
                return "0";
            }
            PlayerPrefs.SetInt("St10", count);
            return count.ToString();
        }
        else if (lvl == 11)
        {
            if (PlayerPrefs.HasKey("St11"))
            {
                i = count - PlayerPrefs.GetInt("St11");
                if (i > 0)
                {
                    PlayerPrefs.SetInt("St11", count);
                    if (PlayerPrefs.HasKey("TotalStar"))
                    {
                        PlayerPrefs.SetInt("TotalStar", PlayerPrefs.GetInt("TotalStar") + i);
                    }
                    else
                    {
                        PlayerPrefs.SetInt("TotalStar", i);
                    }
                    return i.ToString();
                }
                return "0";
            }
            PlayerPrefs.SetInt("St11", count);
            return count.ToString();
        }
        else if (lvl == 12)
        {
            if (PlayerPrefs.HasKey("St12"))
            {
                i = count - PlayerPrefs.GetInt("St12");
                if (i > 0)
                {
                    PlayerPrefs.SetInt("St12", count);
                    if (PlayerPrefs.HasKey("TotalStar"))
                    {
                        PlayerPrefs.SetInt("TotalStar", PlayerPrefs.GetInt("TotalStar") + i);
                    }
                    else
                    {
                        PlayerPrefs.SetInt("TotalStar", i);
                    }
                    return i.ToString();
                }
                return "0";
            }
            PlayerPrefs.SetInt("St12", count);
            return count.ToString();
        }
        else if (lvl == 13)
        {
            if (PlayerPrefs.HasKey("St13"))
            {
                i = count - PlayerPrefs.GetInt("St13");
                if (i > 0)
                {
                    PlayerPrefs.SetInt("St13", count);
                    if (PlayerPrefs.HasKey("TotalStar"))
                    {
                        PlayerPrefs.SetInt("TotalStar", PlayerPrefs.GetInt("TotalStar") + i);
                    }
                    else
                    {
                        PlayerPrefs.SetInt("TotalStar", i);
                    }
                    return i.ToString();
                }
                return "0";
            }
            PlayerPrefs.SetInt("St13", count);
            return count.ToString();
        }
        else if (lvl == 14)
        {
            if (PlayerPrefs.HasKey("St14"))
            {
                i = count - PlayerPrefs.GetInt("St14");
                if (i > 0)
                {
                    PlayerPrefs.SetInt("St14", count);
                    if (PlayerPrefs.HasKey("TotalStar"))
                    {
                        PlayerPrefs.SetInt("TotalStar", PlayerPrefs.GetInt("TotalStar") + i);
                    }
                    else
                    {
                        PlayerPrefs.SetInt("TotalStar", i);
                    }
                    return i.ToString();
                }
                return "0";
            }
            PlayerPrefs.SetInt("St14", count);
            return count.ToString();
        }
        else if (lvl == 15)
        {
            if (PlayerPrefs.HasKey("St15"))
            {
                i = count - PlayerPrefs.GetInt("St15");
                if (i > 0)
                {
                    PlayerPrefs.SetInt("St15", count);
                    if (PlayerPrefs.HasKey("TotalStar"))
                    {
                        PlayerPrefs.SetInt("TotalStar", PlayerPrefs.GetInt("TotalStar") + i);
                    }
                    else
                    {
                        PlayerPrefs.SetInt("TotalStar", i);
                    }
                    return i.ToString();
                }
                return "0";
            }
            PlayerPrefs.SetInt("St15", count);
            return count.ToString();
        }
        else if (lvl == 16)
        {
            if (PlayerPrefs.HasKey("St16"))
            {
                i = count - PlayerPrefs.GetInt("St16");
                if (i > 0)
                {
                    PlayerPrefs.SetInt("St16", count);
                    if (PlayerPrefs.HasKey("TotalStar"))
                    {
                        PlayerPrefs.SetInt("TotalStar", PlayerPrefs.GetInt("TotalStar") + i);
                    }
                    else
                    {
                        PlayerPrefs.SetInt("TotalStar", i);
                    }
                    return i.ToString();
                }
                return "0";
            }
            PlayerPrefs.SetInt("St16", count);
            return count.ToString();
        }
        else if (lvl == 17)
        {
            if (PlayerPrefs.HasKey("St17"))
            {
                i = count - PlayerPrefs.GetInt("St17");
                if (i > 0)
                {
                    PlayerPrefs.SetInt("St17", count);
                    if (PlayerPrefs.HasKey("TotalStar"))
                    {
                        PlayerPrefs.SetInt("TotalStar", PlayerPrefs.GetInt("TotalStar") + i);
                    }
                    else
                    {
                        PlayerPrefs.SetInt("TotalStar", i);
                    }
                    return i.ToString();
                }
                return "0";
            }
            PlayerPrefs.SetInt("St17", count);
            return count.ToString();
        }
        else if (lvl == 18)
        {
            if (PlayerPrefs.HasKey("St18"))
            {
                i = count - PlayerPrefs.GetInt("St18");
                if (i > 0)
                {
                    PlayerPrefs.SetInt("St18", count);
                    if (PlayerPrefs.HasKey("TotalStar"))
                    {
                        PlayerPrefs.SetInt("TotalStar", PlayerPrefs.GetInt("TotalStar") + i);
                    }
                    else
                    {
                        PlayerPrefs.SetInt("TotalStar", i);
                    }
                    return i.ToString();
                }
                return "0";
            }
            PlayerPrefs.SetInt("St18", count);
            return count.ToString();
        }
        else if (lvl == 19)
        {
            if (PlayerPrefs.HasKey("St19"))
            {
                i = count - PlayerPrefs.GetInt("St19");
                if (i > 0)
                {
                    PlayerPrefs.SetInt("St19", count);
                    if (PlayerPrefs.HasKey("TotalStar"))
                    {
                        PlayerPrefs.SetInt("TotalStar", PlayerPrefs.GetInt("TotalStar") + i);
                    }
                    else
                    {
                        PlayerPrefs.SetInt("TotalStar", i);
                    }
                    return i.ToString();
                }
                return "0";
            }
            PlayerPrefs.SetInt("St19", count);
            return count.ToString();
        }
        else if (lvl == 20)
        {
            if (PlayerPrefs.HasKey("St20"))
            {
                i = count - PlayerPrefs.GetInt("St20");
                if (i > 0)
                {
                    PlayerPrefs.SetInt("St20", count);
                    if (PlayerPrefs.HasKey("TotalStar"))
                    {
                        PlayerPrefs.SetInt("TotalStar", PlayerPrefs.GetInt("TotalStar") + i);
                    }
                    else
                    {
                        PlayerPrefs.SetInt("TotalStar", i);
                    }
                    return i.ToString();
                }
                return "0";
            }
            PlayerPrefs.SetInt("St20", count);
            return count.ToString();
        }
        else if (lvl == 21)
        {
            if (PlayerPrefs.HasKey("St21"))
            {
                i = count - PlayerPrefs.GetInt("St21");
                if (i > 0)
                {
                    PlayerPrefs.SetInt("St21", count);
                    if (PlayerPrefs.HasKey("TotalStar"))
                    {
                        PlayerPrefs.SetInt("TotalStar", PlayerPrefs.GetInt("TotalStar") + i);
                    }
                    else
                    {
                        PlayerPrefs.SetInt("TotalStar", i);
                    }
                    return i.ToString();
                }
                return "0";
            }
            PlayerPrefs.SetInt("St21", count);
            return count.ToString();
        }
        else if (lvl == 22)
        {
            if (PlayerPrefs.HasKey("St22"))
            {
                i = count - PlayerPrefs.GetInt("St22");
                if (i > 0)
                {
                    PlayerPrefs.SetInt("St22", count);
                    if (PlayerPrefs.HasKey("TotalStar"))
                    {
                        PlayerPrefs.SetInt("TotalStar", PlayerPrefs.GetInt("TotalStar") + i);
                    }
                    else
                    {
                        PlayerPrefs.SetInt("TotalStar", i);
                    }
                    return i.ToString();
                }
                return "0";
            }
            PlayerPrefs.SetInt("St22", count);
            return count.ToString();
        }
        else if (lvl == 23)
        {
            if (PlayerPrefs.HasKey("St23"))
            {
                i = count - PlayerPrefs.GetInt("St23");
                if (i > 0)
                {
                    PlayerPrefs.SetInt("St23", count);
                    if (PlayerPrefs.HasKey("TotalStar"))
                    {
                        PlayerPrefs.SetInt("TotalStar", PlayerPrefs.GetInt("TotalStar") + i);
                    }
                    else
                    {
                        PlayerPrefs.SetInt("TotalStar", i);
                    }
                    return i.ToString();
                }
                return "0";
            }
            PlayerPrefs.SetInt("St23", count);
            return count.ToString();
        }
        else
        {
            if (PlayerPrefs.HasKey("St24"))
            {
                i = count - PlayerPrefs.GetInt("St24");
                if (i > 0)
                {
                    PlayerPrefs.SetInt("St24", count);
                    if (PlayerPrefs.HasKey("TotalStar"))
                    {
                        PlayerPrefs.SetInt("TotalStar", PlayerPrefs.GetInt("TotalStar") + i);
                    }
                    else
                    {
                        PlayerPrefs.SetInt("TotalStar", i);
                    }
                    return i.ToString();
                }
                return "0";
            }
            PlayerPrefs.SetInt("St24", count);
            return count.ToString();
        }
    }

    public static string GetTotal()
    {
        if (PlayerPrefs.HasKey("TotalStar"))
            return PlayerPrefs.GetInt("TotalStar").ToString();
        else
            PlayerPrefs.SetInt("TotalStar", 0);
        return "0";
    }
}
