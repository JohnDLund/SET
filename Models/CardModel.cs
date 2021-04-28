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


    public enum Symbol
    {
        diamond,
        oval,
        squiggle

    }

    public enum Shade
    {
        solid,
        open,
        stripped
    }

    public enum Color
    {
        green,
        red,
        purple
    }

    public class Card
    {
        public Symbol Symbol { get; set; }
        public Shade Shade { get; set; }
        public Color Color { get; set; }
        public int Number { get; set; }

    }
}