using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    public class CalGrade
    {
        private int Score { get; set; }

        public CalGrade(int score) {
            this.Score = score;
        
        }

        public string Excute() {
            var response = "";
           
        

            if (Score >= 101)
            {
               response = "ERROR";
            }
            else if (Score >= 80)
            {
                response = "A";
            }
            else if (Score >= 70)
            {
                response = "B";
            }
            else if (Score >= 60)
            {
                response = "C";

            }
            else if (Score >= 50)
            {
                response = "D";
            }
            else if (Score <= 49)
            {
                response = "F";

            }
            return response;

        }

       
    }

    
}
