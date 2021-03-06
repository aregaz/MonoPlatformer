﻿#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
#endregion

namespace MonoGamePlatformer
{
	/// <summary>
	/// This is the main type for your game
	/// </summary>
	public class PlatformerGame : Game
	{
		private readonly GraphicsDeviceManager graphics;
		private GraphicsDevice device;
		private SpriteBatch spriteBatch;

		private Effect effect;

		//private VertexPositionColor[] vertexList;
		//private VertexDeclaration vertexDeclaration;
		//private BasicEffect effect;

		public PlatformerGame()
			: base()
		{
			graphics = new GraphicsDeviceManager(this);
			
			Content.RootDirectory = "Content";
		}

		/// <summary>
		/// Allows the game to perform any initialization it needs to before starting to run.
		/// This is where it can query for any required services and load any non-graphic
		/// related content.  Calling base.Initialize will enumerate through any components
		/// and initialize them as well.
		/// </summary>
		protected override void Initialize()
		{
			// TODO: Add your initialization logic here
			graphics.PreferredBackBufferWidth = 500;
			graphics.PreferredBackBufferHeight = 500;
			graphics.IsFullScreen = false;
			graphics.ApplyChanges();
			Window.Title = "Mono Platformer 2D - XNA";

			//this.effect = this.Content.Load<Effect>("effects");

			base.Initialize();
		}

		/// <summary>
		/// LoadContent will be called once per game and is the place to load
		/// all of your content.
		/// </summary>
		protected override void LoadContent()
		{
			// Create a new SpriteBatch, which can be used to draw textures.
			spriteBatch = new SpriteBatch(GraphicsDevice);
			
			this.device = graphics.GraphicsDevice;

			//// TODO: use this.Content to load your game content here
			//this.vertexList = new VertexPositionColor[3]
			//				  {
			//					  new VertexPositionColor(new Vector3(0, 0.5f, 0), Color.Gray),
			//					  new VertexPositionColor(new Vector3(-0.5f, -0.5f, 0), Color.Gray),
			//					  new VertexPositionColor(new Vector3(0.5f, -0.5f, 0), Color.Gray)
			//				  };

			//this.vertexDeclaration = new VertexDeclaration(this.vertexList);
			//this.effect = new BasicEffect(this.graphics.GraphicsDevice);
		}

		/// <summary>
		/// UnloadContent will be called once per game and is the place to unload
		/// all content.
		/// </summary>
		protected override void UnloadContent()
		{
			// TODO: Unload any non ContentManager content here
		}

		/// <summary>
		/// Allows the game to run logic such as updating the world,
		/// checking for collisions, gathering input, and playing audio.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
			    Keyboard.GetState().IsKeyDown(Keys.Escape))
			{
				this.Exit();
			}

			// TODO: Add your update logic here

			base.Update(gameTime);
		}

		/// <summary>
		/// This is called when the game should draw itself.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Draw(GameTime gameTime)
		{
			this.GraphicsDevice.Clear(Color.Bisque);

			// TODO: Add your drawing code here

			this.effect.CurrentTechnique = effect.Techniques["Pretransformed"];
			foreach (EffectPass pass in this.effect.CurrentTechnique.Passes)
			{
				pass.Apply();

			}

			base.Draw(gameTime);
		}
	}
}
