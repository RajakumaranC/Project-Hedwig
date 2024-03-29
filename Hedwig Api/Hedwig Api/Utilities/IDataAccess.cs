﻿using System.Collections.Generic;
using TheGameBackend.Models;

namespace TheGameBackend.Utilities
{
    interface IDataAccess
    {
        public Game GetGame(string roomCode);
        public List<Game> GetAllGames();
        public void AddGame(Game game);
        public void UpdateGame(Game game);
        public void DeleteGame(Game game);
    }
}
