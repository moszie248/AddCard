using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
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
         public static void Main()
        {   
 
        AddCard();

        }
        private static async Task AddCard()
        {
            Console.WriteLine("Inside");
             
            TrelloAuthorization.Default.AppKey = "109fe6fc4bf193d45e7730f7055440b0";
            TrelloAuthorization.Default.UserToken = "d6af304d5c424d0d8862b03781c32ddd8adf2ea7aa5ff97bba45b230209cf5a1";

            ITrelloFactory factory = new TrelloFactory(); 
            var List = factory.List("5b40363293193091c1ba5014");
 
        
            Console.WriteLine("Creating a Card .......");
            var card = List.Cards.Add("This is A NEW Card");
            Console.WriteLine("Create Finished");
            await List.Refresh();
         


            return ;

        }

    }
}
    



      