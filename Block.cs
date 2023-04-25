using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{   
    public class Block : GameObject
    {
        public new Texture2D Texture { get; set; }     
        public Vector2 Position { get; set; }  
        public static int Width { get; set; } = 32;
        public static int Height { get; set; } = 32;
        public Rectangle Bounds => new Rectangle((int)Position.X, (int)Position.Y, (int)Position.X + Width, (int)Position.Y + Height);

        public Block(
            Texture2D texture,
            Vector2 position,
            bool isVisible = true,
            bool isActive = true,
            bool isSolid = true,
            bool isCollidable = true)
            : base(texture, position, isVisible, isActive, isSolid, isCollidable)
        {
            Texture = texture;
            Position = position;            
        }

        public  void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }

}
