using Godot;
using System;
using System.Text.RegularExpressions;
using Godot.Collections;

public partial class Global : Node
{
    public static Global Instance;
    
    public int Health;
    public int LastScene;
    public int Flowers;
    public bool JustDied;
    public Dictionary<string, bool> CollectedFlowers;
    public Dictionary<string, bool> CompletedLevels;

    public override void _Ready()
    {
        Instance = this;
        Health = 100;
        Flowers = 0; 
        JustDied = false;

        CollectedFlowers = new(){};
        CompletedLevels = new(){};
    }

    public string RemoveNumbers(string text) => Regex.Replace(text, @"\d+", "");
}
