﻿using PrimeiroProjeto.logica;
using PrimeiroProjeto.poo;
using PrimeiroProjeto.poo.exerciciosClasses;
using PrimeiroProjeto.poo.construtores;
using System.Globalization;
using PrimeiroProjeto.poo.Structs;
using PrimeiroProjeto.vetores;
using PrimeiroProjeto.Entities;
using PrimeiroProjeto.Entities.Enums;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("have a nice trip");
            Comment c2 = new Comment("wow, thats awsome!");

            Post p1 = new Post
            (
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12
            );

            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good Night");
            Comment c4 = new Comment("May the force be with you");
            Post p2 = new Post(
                    DateTime.Parse("28/07/2018 23:14:19"),
                    "Good Night Guys!",
                    "See you tomorrow",
                    5
                );
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}
