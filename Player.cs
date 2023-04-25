using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace GameProject
{
    public class Player: GameObject
    {

        // Основные свойства игрока
        public new Texture2D Texture { get; set; } // текстура игрока      
        public Vector2 Position { get; set; } // позиция игрока
        public Rectangle Bounds => new Rectangle((int)Position.X, (int)Position.Y, Texture.Width, Texture.Height); // границы игрока
        public float Speed { get; set; } // скорость
        public bool IsJumping { get; set; } // прыгает ли игрок
        public float JumpVelocity { get; set; } // скорость прыжка игрока
        public float Gravity { get; set; } // гравитация для прыжков и падений
        public int DeathCount { get; set; } // счетчик смертей

        public Player(Texture2D texture, Vector2 position) : base (texture, position)
        {
            Texture = texture;
            Position = position;
            Speed = 2f;
            IsJumping = false;
            JumpVelocity = -12f;
            Gravity = 0.5f;
            DeathCount = 0;
        }

        // Обновление игрока
        public void Update(GameTime gameTime, KeyboardState keyboardState, Vector2 Position)
        {
            if (keyboardState.IsKeyDown(Keys.Space) && !IsJumping)
            {
                Jump();
            }          

            if (IsJumping)
            {
                Position.Y += JumpVelocity;//прыжок
            }
            else
            {
                Position.Y += Gravity;//падение
            }

            if (keyboardState.IsKeyDown(Keys.Left))
            {
                Position.X -= Speed;
            }

            if (keyboardState.IsKeyDown(Keys.Right))
            {
                Position.X += Speed;
            }

        }
        // Метод для прыжка
        public void Jump()
        {
            IsJumping = true;
            //AddForce ???????
        }


        public void Update(GameTime gameTime)
        {           
        }

        
    }
}

/*
public new void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }

// Отрисовка игрока на экране
        //public void Draw(SpriteBatch spriteBatch)
        //{
        //    base.Draw(spriteBatch);
        //}

*/
