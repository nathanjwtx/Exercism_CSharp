using System;

public class Robot
{
    private string _name;

    public Robot()
    {
        CreateName();
    }

    private void CreateName()
    {
        var letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        var numbers = "0123456789";

        var r = new Random();

        for (int i = 0; i < 2; i++)
        {
            _name += letters[r.Next(0, 26)];
        }

        for (int i = 0; i < 3; i++)
        {
            _name += numbers[r.Next(0, 10)];
        }

        // online alternative for generating the number part
        // _name += r.Next(1000).ToString("000");
    }

    public string Name => _name;


    public void Reset()
    {
        _name = "";
        CreateName();
    }
}