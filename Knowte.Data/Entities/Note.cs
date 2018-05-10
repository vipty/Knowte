﻿using Knowte.PluginBase.Collection.Entities;
using SQLite;
using System;

namespace Knowte.Data.Entities
{
    public class Note : INote
    {
        [PrimaryKey()]
        public string Id { get; set; }

        public string Title { get; set; }

        public string NotebookId { get; set; }

        public string Text { get; set; }

        public long CreationDate { get; set; }

        public long OpenDate { get; set; }

        public long ModificationDate { get; set; }

        public long Width { get; set; }

        public long Height { get; set; }

        public long Top { get; set; }

        public long Left { get; set; }

        public long Flagged { get; set; }

        public long Maximized { get; set; }                 

        public Note()
        {
        }

        public Note(string notebookId, string title)
        {
            this.Id = Guid.NewGuid().ToString();
            this.NotebookId = notebookId;
            this.Title = title;

            var nowTicks = DateTime.Now.Ticks;
            this.CreationDate = nowTicks;
            this.ModificationDate = nowTicks;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !GetType().Equals(obj.GetType()))
            {
                return false;
            }

            return this.Id.Equals(((Note)obj).Id);
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        public override string ToString()
        {
            return this.Title;
        }
    }
}