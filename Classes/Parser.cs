using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalFunctionsCalculator.Classes
{
    // Здесь мог быть паттерн Стратегия, но не получилось
    class Parser
    {

        private string Text;

        public string GetAnswer(string Text)
        {
            this.Text = Text;
            string answer = Parse();
            return answer;
        }

        private string Parse()
        {
            string ans = this.Text;

            while (true)
            {
                if (ans.IndexOf("(") > -1)
                {
                    if (ans.IndexOf(")") > 0)
                    {
                        string sub = ans.Substring(ans.IndexOf("("), ans.IndexOf(")"));
                    }
                }

                ans = Denial(ans);
                ans = Conjunction(ans);
                if (ans == "false" || ans == "true")
                {
                    break;
                }
            }
            
            return ans;
        }

        //
        // Далее Ересь 
        //
        // опыта с парсером у меня нет, но я пытался
        //
        //

        private string Denial(string text)
        {
            if (text.IndexOf("not ") > -1)
            {
                text = text.Replace("not true", "false");
                text = text.Replace("not false", "true");
            }
            return text;
        }

        private string Conjunction(string text)
        {
            if (text.IndexOf(" and ") > -1)
            {
                text = text.Replace("false and true", "false");
                text = text.Replace("false and false", "false");
                text = text.Replace("true and true", "true");
                text = text.Replace("true and false", "false");
            }

            return text;
        }
    }
}
