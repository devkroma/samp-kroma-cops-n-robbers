using System;
using SampSharp.GameMode;

namespace KromaCnR
{
    public class GameMode : BaseMode
    {
        #region Overrides of BaseMode

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("Cops 'n' Robbers gamemode by kroma");
            Console.WriteLine("----------------------------------\n");

            // TODO: Put logic to initialize your game mode here
        }

        #endregion
    }
}