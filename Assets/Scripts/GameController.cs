using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//library for user interaction object classes (InputField, Dropdown, Button, etc.)
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    //global variable that will store all game information and data
    public static Data game_data = new Data();

    //data entry objects
    public InputField input_name;
    public InputField input_points;
    public Dropdown input_level_number;

    public void SaveData()
    {
        //captures the player's name
        game_data.name = input_name.text;

        //creates a level object
        LevelData new_level = new LevelData();

        //captures the level number and the number of points
        new_level.level_number = input_level_number.value;
        new_level.points       = int.Parse(input_points.text);

        //adds the data of the created level to the list
        game_data.level_data.Add(new_level);

        //creates a JSON of the object "game_data"
        string json = JsonUtility.ToJson(game_data);
        
        //prints the created JSON
        Debug.Log(json);
    }
}
