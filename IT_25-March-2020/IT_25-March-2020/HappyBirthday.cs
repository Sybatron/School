using System.Windows.Forms;

namespace IT_25_March_2020
{
    public class HappyBirthday
    {
        private string birthdayName;
        private int numberOfPresents;
        private string presentMsg = "\nPresents count: ";
        public string BirthdayName
        {
            get { return birthdayName; }
            set
            {
                if (value.Length > 0)
                {
                    birthdayName = value;
                }
                else
                {
                    MessageBox.Show("BirthdayName can't be empty");
                }
            }
        }

        public int PresentCount
        {
            set
            {
                numberOfPresents = value;
            }
        }

        public HappyBirthday(string numberOfPresents)
        {
            if (int.TryParse(numberOfPresents, out int numberValue))
            {
                PresentCount = numberValue;
                presentMsg += this.numberOfPresents;
            }
            else
            {
                PresentCount = 0;
            }
        }

        public HappyBirthday(int numberOfPresents)
        {
            PresentCount = numberOfPresents;
            presentMsg += this.numberOfPresents;
        }

        public virtual string GetMessage()
        {
            return $"Happy Birthday!!!" + presentMsg;
        }
        public virtual string GetMessage(string personName)
        {
            BirthdayName = personName;
            return $"Happy Birthday {personName}!!!" + presentMsg;
        }
    }
}
