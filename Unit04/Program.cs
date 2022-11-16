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
        private static int FRAME_RATE = 6;
        private static int MAX_X = 1800;
        private static int MAX_Y = 1200;
        private static int CELL_SIZE = 30;
        private static int FONT_SIZE = 30;
        private static int COLS = 120;
        private static int ROWS = 80;
        private static string CAPTION = "SCORE: ";
        private static Color WHITE = new Color(255 ,255 ,255);
        private static int DEFAULT_STONES = 20;

        static void Main(string[] args)
        {
            Cast cast = new Cast();

            Actor banner = new Actor();
            banner.SetText("");
            banner.SetFontSize(FONT_SIZE);
            banner.SetColor(WHITE);
            banner.SetPosition(new Point(CELL_SIZE,0));
            cast.AddActor("banner", banner);

            Actor robot = new Actor();
            robot.SetText("#");
            robot.SetFontSize(FONT_SIZE);
            robot.SetColor(WHITE);
            robot.SetPosition(new Point(MAX_X / 2, MAX_Y / -40));
            cast.AddActor("robot",robot);

            Random random = new Random();
            for (int i = 0; i < DEFAULT_STONES; i++)
            {
                string text = ((char)random.Next(33,126)).ToString();
                // string message = messages[i];

                int x = random.Next(1, COLS);
                int y = random.Next(1, ROWS);

                int r = random.Next(0, 256);
                int g = random.Next(0, 256);
                int b = random.Next(0, 256);
                Color rockcolor = new Color(50, 90, 150);
                Color gemcolor = new Color(50,170,210);
                
                for(int rockCount = 0; rockCount <= 5; rockCount++)
                {
                    Point position_rock = new Point(x*rockCount, 4);
                    position_rock = position_rock.Scale(CELL_SIZE);
                    FallingObject rock = new FallingObject(-5);
                    rock.SetText("O");
                    rock.SetFontSize(FONT_SIZE);
                    rock.SetColor(rockcolor);
                    rock.SetPosition(position_rock);
                    cast.AddActor("rocks", rock);
                }
                for(int gemCount = 0; gemCount <= 5; gemCount++)
                {
                    FallingObject gem = new FallingObject(10);
                    Point position_gem = new Point(x+3*gemCount, 5);
                    position_gem = position_gem.Scale(CELL_SIZE);
                    gem.SetText("*");
                    gem.SetFontSize(FONT_SIZE);
                    gem.SetColor(gemcolor);
                    gem.SetPosition(position_gem);
                    cast.AddActor("gems", gem);
                }
            }

            // start the game
            KeyboardService keyboardService = new KeyboardService(CELL_SIZE);
            ScreenService screenService 
                = new ScreenService(CAPTION, MAX_X, MAX_Y, CELL_SIZE, FRAME_RATE, false);
            Director director = new Director(keyboardService, screenService);
            director.StartGame(cast);

            // test comment
        }
    }
}
