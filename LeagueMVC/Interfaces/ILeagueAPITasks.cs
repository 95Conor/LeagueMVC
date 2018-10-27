using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueMVC.Interfaces
{
    public interface ILeagueAPITasks
    {
        Classes.Application.League.User GetUser(string userName);
    }
}
