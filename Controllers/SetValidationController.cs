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
    public class SetValidationController : Controller
    {
        List<Card> playerCards = new List<Card>();


        static void validateSet()
        {
            if (symbolMatch() == true && shapeMatch() == true && shadeMatch() == true && numberMatch() == true)
            {
                return true;
            };

        }


        static void symbolMatch()
        {

            if (
            (playerCards.firstCard.Symbol == playerCards.secondCard.Symbol && playerCards.firstCard.Symbol == playerCards.thirdCard.Symbol)
                     {
                return true;
            }
        };

        static void shapeMatch()
        {

            if (
            (playerCards.firstCard.Shape == playerCards.secondCard.Shape && playerCards.firstCard.Shape == playerCards.thirdCard.Shape)
                     {
                return true;
            }
        };

        static void shadeMatch()
        {

            if (
            (playerCards.firstCard.Shade == playerCards.secondCard.Shade && playerCards.firstCard.Shade == playerCards.thirdCard.Shade)
                     {
                return true;
            }
        };

        static void numberMatch()
        {

            if (
            (playerCards.firstCard.Number == playerCards.secondCard.Number && playerCards.firstCard.Number == playerCards.thirdCard.Number)
                     {
                return true;
            }
        };

    }