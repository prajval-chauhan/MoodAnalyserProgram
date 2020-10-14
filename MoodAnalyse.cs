using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProgram
{
   public class MoodAnalyse
    {
        private string message;
        public MoodAnalyse(string message)
        {
            this.message = message;
        }
        public string Analyse()
        {
            //try
            //{
            //    if (this.message.contains("sad"))
            //        return "sad";
            //    else
            //        return "happy";
            //}
            //catch
            //{
            //    return "happy";
            //}

            try
            {
                if(this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                if(this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch(NullReferenceException)
            {
                throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");

            }
        }
    }
}
