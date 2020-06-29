using System;
using System.Collections.Generic;

[Serializable]
public class Data
{
    //Player's name
    public string name;
    //list of objects of type "level_data" to save in list format: 1) level number; and 2) the amount of points
    public List<LevelData> level_data = new List<LevelData> ();
}
