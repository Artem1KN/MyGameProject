using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.IO;

namespace GameProject
{
    static class SplashScreen
    {
        public static Texture2D Bacground {  get; set; }
        static int timeCounter = 0;
        static Color color;    

        static public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Bacground, Vector2.Zero, color);
        }

        static public void Update()
        {
            color = Color.FromNonPremultiplied(255, 255, 255, timeCounter % 256);
            timeCounter++;
        }


    }
}
