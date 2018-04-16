using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Data
{
    public class ComicBookRepo
    {
        private static ComicBook[] _comicBooks = new ComicBook[]
    {
    new ComicBook()
    {
        Id = 1,
        SeriesTitle = "The Amazing Spider-Man",
        IssueNumber = 700,
        DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Artists = new Artists[]
        {
            new Artists() { Name = "Dan Slott", Value = "Script" },
            new Artists() { Name = "Humberto Ramos", Value = "Pencils" },
            new Artists() { Name = "Victor Olazaba", Value = "Inks" },
            new Artists() { Name = "Edgar Delgado", Value = "Colors" },
            new Artists() { Name = "Chris Eliopoulos", Value = "Letters" },
        },
        Favorite = false
    },
    new ComicBook()
    {
        Id = 2,
        SeriesTitle = "The Amazing Spider-Man",
        IssueNumber = 657,
        DescriptionHtml = "<p><strong>FF: THREE TIE-IN.</strong> Spider-Man visits the FF for a very private wake--just for family.</p>",
        Artists = new Artists[]
        {
            new Artists() { Name = "Dan Slott", Value = "Script" },
            new Artists() { Name = "Marcos Martin", Value = "Pencils" },
            new Artists() { Name = "Marcos Martin", Value = "Inks" },
            new Artists() { Name = "Muntsa Vicente", Value = "Colors" },
            new Artists() { Name = "Joe Caramagna", Value = "Letters" }
        },
        Favorite = false
    },
    new ComicBook()
    {
        Id = 3,
        SeriesTitle = "Bone",
        IssueNumber = 50,
        DescriptionHtml = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
        Artists = new Artists[]
        {
            new Artists() { Name = "Jeff Smith", Value = "Script" },
            new Artists() { Name = "Jeff Smith", Value = "Pencils" },
            new Artists() { Name = "Jeff Smith", Value = "Inks" },
            new Artists() { Name = "Jeff Smith", Value = "Letters" }
        },
        Favorite = false
    }
    };
        public ComicBook GetComicBook(int id)
        {
            ComicBook comicBookReturn = null;

            foreach (var comicBook in _comicBooks)
            {
                if (comicBook.Id ==id)
                {
                    comicBookReturn = comicBook;

                    break;
                }
            }
            return comicBookReturn;
        }
    }
}