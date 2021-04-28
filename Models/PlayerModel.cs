
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SetGame.Models;

namespace SetGame.Controllers
{
    public class Player
    {
        public string Name { get; set; }
        public Queue<Card> Deck { get; set; }
    }
}