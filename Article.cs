using System;
using System.Collections.Generic;
namespace Collection
{
    public class Article
    {
        private DateTime adate = new DateTime();
        private string apublisher;
        public Article (DateTime adate, string apublisher) 
        {
            this.adate = adate;
            this.apublisher = apublisher;
        }
        public override string ToString()
        {
            return String.Format
            (
                "Article date: {0}"  + "\n" +
                "Article publisher: {1}", adate.ToShortDateString(), apublisher       
            );
        }

    }
    
}