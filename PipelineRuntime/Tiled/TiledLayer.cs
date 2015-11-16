using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Microsoft.Xna.Framework;


namespace Nez.Tiled
{
	public abstract class TiledLayer
	{
		public string name;
		public Dictionary<string,string> properties;
		public bool visible;
		public float opacity;


		protected TiledLayer( string name )
		{
			this.name = name;
			properties = new Dictionary<string,string>();
		}


		public abstract void draw( SpriteBatch spriteBatch );
		public abstract void draw( SpriteBatch spriteBatch, Vector2 position, float layerDepth, Rectangle cameraClipBounds );

	}
}