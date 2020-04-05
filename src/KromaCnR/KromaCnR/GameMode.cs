using System;
using KromaCnR.Data.Models;
using SampSharp.GameMode;
using SampSharp.GameMode.World;

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

        protected override void OnPlayerConnected(BasePlayer player, EventArgs e)
        {
            base.OnPlayerConnected(player, e);

            checkAccount(player);
        }

        private async void checkAccount(BasePlayer player)
        {
            var user = await Injection.UserService.GetUserByUsername(player.Name);

            if (user == null)
            {
                player.SendClientMessage("User is null, creating new account");

                var newUser = new User(player.Name, "password1");
                await Injection.UserService.CreateUser(newUser);
            }
            else
            {
                player.SendClientMessage($"Found account {user.Username} with password {user.Password}!");
            }
        }

        #endregion
    }
}