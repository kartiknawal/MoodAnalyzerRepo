using System;
using System.Collections;
using System.Text;

namespace MoodAnalyserProject
{
    public class MoodAnalyser
    {
        string message;

        public MoodAnalyser()
        {
            message = "";
        }
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            try
            {
                if (message.ToUpper().Contains("SAD"))
                {
                    return "SAD";
                }
                if (message.ToUpper().Contains("HAPPY"))
                {
                    return "HAPPY";
                }
                return "";
            }
            catch (Exception)
            {
                return "HAPPY";
            }
        }
    }
}