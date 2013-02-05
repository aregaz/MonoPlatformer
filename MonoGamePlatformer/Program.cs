#region Using Statements
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;

#endregion

namespace MonoGamePlatformer
{
	/// <summary>
	/// The main class.
	/// </summary>
	public static class Program
	{
		private static PlatformerGame game;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			game = new PlatformerGame();
			game.Run();
		}
	}
}
