using System;

class Word
{
   private List <string> words = new List <string>();

   public Word(string scriptureP)
   {
       string[] array = scriptureP.Split(" ");

       foreach(string a in array)
       {
            words.Add(a);
       }
   }


}