﻿using Spectre.Console;
using SoGoodLib;

public static class Program
{
    private static void Main(string[] args)
    {
        SoGoodClass.SoGoodMethod();
        CanvasImage image =new CanvasImage("tux.jpg");
        int maxWidth = 20;


        if (args.Length >= 2)
        {
            image = new CanvasImage(args[0]); 
            maxWidth = int.Parse(args[1]);
        }
        AnsiConsole.Write(image);
    }
}
