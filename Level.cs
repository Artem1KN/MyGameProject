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
    public class Level
    {
        public Texture2D backgroundTexture; // текстура фона уровня
        //public Texture2D[] platformTextures; // текстуры платформ уровня
        //public Rectangle[] platforms; // прямоугольники для платформ уровня

        // Конструктор
        public Level(string backgroundTexturePath, string[] platformTexturePaths, Rectangle[] platformRectangles)
        {
            
        }

        public void Load(string text)
        {
            List<Block> Blocks = new List<Block>();

            int width = text.IndexOf("\r\n") + 1;
            int height = text.Length / width;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    char c = text[i * width + j];
                    if (c == 'B')
                    {
                        Block block = new Block(
                            new Texture2D(),
                            new Vector2(j * Block.Width, i * Block.Height));
                        //block.Position = new Vector2(j * Block.Width, i * Block.Height);
                        Blocks.Add(block);
                    }
                    else if (c == 'P')
                    {
                        Player.Position = new Vector2(j * Block.Width, i * Block.Height);
                    }
                }
            }
        }


        // Обновление уровня
        public void Update(GameTime gameTime, Player player)
        {
            
        }



        // Отрисовка уровня на экране
        public void Draw(SpriteBatch spriteBatch)
        {
            // Отрисовка фона
            spriteBatch.Draw(backgroundTexture, new Rectangle(0, 0, backgroundTexture.Width, backgroundTexture.Height), Color.White);
        }

    }
}