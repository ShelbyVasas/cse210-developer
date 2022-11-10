using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Unit04.Game.Casting;
using Unit04.Game.Directing;
using Unit04.Game.Services;

namespace Unit04
{
    class Program
    {
        private static int FRAME_RATE = 12;
        private static int MAX_X = 900;
        private static int MAX_Y = 600;
        private static int CELL_SIZE = 15;
        private static int FONT_SIZE = 15;
        private static int COLS = 60;
        private static int ROWS = 40;
        private static string CAPTION = "SCORE: ";
        private static Color WHITE = new Color(255 ,255 ,255);
        private static int DEFAULT_STONES = 40;

        static void Main(string[] args)
        {
            Cast cast = new Cast();

            Actor banner = new Actor();
            banner.SetText("Score: ");
            banner.SetFontSize(FONT_SIZE);
            banner.SetColor(WHITE);
            banner.SetPosition(new Point(CELL_SIZE,0));
            cast.AddActor("banner", banner);

            Actor robot = new Actor();
            robot.SetText("#");
            robot.SetFontSize(FONT_SIZE);
            robot.SetColor(WHITE);
            robot.SetPosition(new Point(MAX_X / 2, MAX_Y /2));
            cast.AddActor("robot",robot);
        }
    }
}
