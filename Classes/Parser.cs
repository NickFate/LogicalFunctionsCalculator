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
            string ans = this.Text.Trim();

            int iteration = 0;
            while (true) // для обновления с возможностью использования скобок
            {
                /*if (ans.IndexOf("(") > -1)
                {
                    if (ans.IndexOf(")") > 0)
                    {
                        string sub = ans.Substring(ans.IndexOf("("), ans.IndexOf(")"));
                        string subans = sub;



                    }
                }
                */

                ans = Denial(ans); // копипаст. не делайте так
                ans = Conjunction(ans);
                ans = Disjunction(ans);
                ans = ExclusiveOr(ans);
                ans = Implication(ans);
                ans = Equivalence(ans);
                ans = SchaeffersStroke(ans);
                ans = PeircesArrow(ans);

                if (ans == "false" || ans == "true")
                {
                    break;
                }
                if (iteration >= 5)
                {
                    return "Все погано";
                }
                iteration++;

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

        private string Disjunction(string text)
        {
            if (text.IndexOf(" or ") > -1)
            {
                text = text.Replace("false or true", "true");
                text = text.Replace("false or false", "false");
                text = text.Replace("true or true", "true");
                text = text.Replace("true or false", "true");
            }

            return text;
        }

        private string ExclusiveOr(string text)
        {
            if (text.IndexOf(" xor ") > -1)
            {
                text = text.Replace("false xor true", "true");
                text = text.Replace("false xor false", "false");
                text = text.Replace("true xor true", "false");
                text = text.Replace("true xor false", "true");
            }

            return text;
        }

        private string Implication(string text)
        {
            if (text.IndexOf(" imp ") > -1)
            {
                text = text.Replace("false imp false", "true");
                text = text.Replace("false imp true", "true");
                text = text.Replace("true imp false", "false");
                text = text.Replace("true imp true", "true");
            }

            return text;
        }

        private string Equivalence(string text)
        {
            if (text.IndexOf(" eqv ") > -1)
            {
                text = text.Replace("false eqv false", "true");
                text = text.Replace("false eqv true", "false");
                text = text.Replace("true eqv false", "false");
                text = text.Replace("true eqv true", "true");
            }

            return text;
        }
        private string SchaeffersStroke(string text)
        {
            if (text.IndexOf(" scs ") > -1)
            {
                text = text.Replace("false scs false", "true");
                text = text.Replace("false scs true", "true");
                text = text.Replace("true scs false", "true");
                text = text.Replace("true scs true", "false");
            }

            return text;
        }
        private string PeircesArrow(string text)
        {
            if (text.IndexOf(" par ") > -1)
            {
                text = text.Replace("false par false", "true");
                text = text.Replace("false par true", "false");
                text = text.Replace("true par false", "false");
                text = text.Replace("true par true", "false");
            }

            return text;
        }
    }
}
