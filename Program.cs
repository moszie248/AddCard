using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Manatee.Trello;
using Manatee.Trello.Internal;
using Manatee.Trello.Internal.DataAccess;
using Manatee.Trello.Internal.Synchronization;
using Manatee.Trello.Internal.Validation;
using Manatee.Trello.Json;

namespace FunctionCreateTask
{
    public class Program
    {
        static void Main()
        {   
            Console.WriteLine("Creating a card ...");
             
            TrelloAuthorization.Default.AppKey = "109fe6fc4bf193d45e7730f7055440b0";
            TrelloAuthorization.Default.UserToken = "d6af304d5c424d0d8862b03781c32ddd8adf2ea7aa5ff97bba45b230209cf5a1";
            ITrelloFactory factory = new TrelloFactory();
            //var backlog = factory.List("[5b40363293193091c1ba5014]");
            //var board = factory.Board("[5b40363293193091c1ba5013]");
            var list = factory.List("5b40363293193091c1ba5014");
            var card = list.Cards.Add("a new card");

            Console.WriteLine("Finished");
        }
    }
}
    



      