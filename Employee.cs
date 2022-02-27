using System;
using System.Collections.Generic;
using System.Linq;
namespace Collection
{
    public class Employee
    {
         public enum AcademicDegree
        {
            Assistent, Researcher, Professor
        }
        public enum SubjectList
        {
            Math, Progremming, Physics, History, English, Chemistry 
        }
        
        public string Name{get; set;}
        public string Surname {get; set;}
        public DateTime DateofBirth = new DateTime();
        private AcademicDegree adegree;
        public AcademicDegree ADegree
        {
            get{return adegree;} 
            set {if (!Enum.IsDefined<AcademicDegree>(value)) throw new ArgumentException("You need to choose: Assistent, Researcher or Professor");
                adegree = value;}
        }
        private Dictionary<SubjectList, int> Sub = new Dictionary<SubjectList, int>();
        public Dictionary<SubjectList, int> Subject
        {
           get {return Sub;}
        }

        private Dictionary<string, Article> article = new Dictionary<string, Article>();
        public Dictionary<string, Article> Article 
        {
            get {return article;}
        }

        public Employee(string Surname, string Name, DateTime DateofBirth, AcademicDegree ADegree)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.DateofBirth = DateofBirth;
            if (Enum.IsDefined<AcademicDegree>(ADegree))
            this.ADegree= ADegree; // Есть ли значение в Enum
        }

        public int SubjectLoad()
        {
            return Sub.Values.Sum(); 
        }

        public string SubjectPrint()
        {
            string s=null;
            foreach (KeyValuePair<SubjectList, int> subject in Sub)
            {
                s = s + subject.Key.ToString() + " " + subject.Value.ToString() + "\n";
            }
            return s;
        }
         public string ArticlePrint()
        {
            string a=null;
            foreach (KeyValuePair<string, Article> article in Article)
            {
                a = a + "Article title: " + article.Key+ "\n" + article.Value.ToString() + "\n";
            }
            return a;
        }
        
        public override string ToString()
        {
                return String.Format(
                "Full name: {0} {1}" + "\n" + 
                "Date of birth {2} " + "\n" + 
                "Academic degree: {3}" + "\n" +
                "Subjects: {4}" + "\n" +
                "Subject load: {5}" + "\n" +
                "{6}",   
                Name, Surname, DateofBirth.ToShortDateString(), ADegree, SubjectPrint(), SubjectLoad(), ArticlePrint());
        }
    }
}




