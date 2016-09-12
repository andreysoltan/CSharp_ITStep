using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2016._09._12
{
    public class Answer
    {
        int id;
        string text;
        string answer;
        public bool isCorrect()
        {
            if (this.text == this.answer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}