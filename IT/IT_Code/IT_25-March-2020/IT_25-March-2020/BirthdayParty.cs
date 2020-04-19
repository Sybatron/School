using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IT_25_March_2020
{
    public class BirthdayParty : HappyBirthday
    {
        public BirthdayParty(string numberOfPresents) : base(numberOfPresents) { }

        public BirthdayParty(int numberOfPresents) : base(numberOfPresents) { }

        public string GetMessage(string personName, bool haveParty)
        {
            return $"{base.GetMessage(personName)}\n{HaveParty(haveParty)}";
        }

        public string HaveParty(bool haveParty)
        {
            if (haveParty)
            {
                return "Enjoy your party!";
            }
            else
            {
                return "...Sorry - Don't feel bad that you won't have party";
            }
        }

        public static void PartyProgress(TextBox count, TextBox name, CheckBox haveParty)
        {
            int progress = 0;
            progress += count.Text.Length > 0 ? 33 : 0;
            progress += name.Text.Length > 0 ? 33 : 0;
            progress += haveParty.Checked ? 34 : 0;
            MessageBox.Show($"Party Progress: {progress}%");
        }
    }
}
