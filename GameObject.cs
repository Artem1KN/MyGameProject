using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameProject
{
    public class GameObject
    {
        // Основные свойства объекта
        public Texture2D Texture { get; set; } // текстура объекта
        public Vector2 Position { get; set; } // позиция объекта на экране
        public Rectangle Bounds => new Rectangle((int)Position.X, (int)Position.Y, Texture.Width, Texture.Height); // границы объекта для коллизий и отрисовки
        public bool IsVisible { get; set; } // видим ли объект
        public bool IsActive { get; set; } // активен ли объект
        public bool IsSolid { get; set; } // может ли объект быть пройден или пересечен игроком
        public bool IsCollidable { get; set; } // объект коллизионный или нет

        // Конструктор
        public GameObject(Texture2D texture, Vector2 position, bool isVisible = true, bool isActive = true, bool isSolid = false, bool isCollidable = false)
        {
            Texture = texture;
            Position = position;
            IsVisible = isVisible;
            IsActive = isActive;
            IsSolid = isSolid;
            IsCollidable = isCollidable;

        }

        // Отрисовка объекта на экране
        public void Draw(SpriteBatch spriteBatch)
        {
            if (IsVisible)
            {
                spriteBatch.Draw(Texture, Position, Color.White);
            }
        }
    }
}


