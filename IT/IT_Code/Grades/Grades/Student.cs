using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Student
    {
        public decimal Num { get; private set; }
        public string Name { get; private set; }
        public string StudClass { get; private set; }
        public decimal Bel { get; private set; }
        public decimal Angl { get; private set; }
        public decimal Mat { get; private set; }
        public decimal Fiz { get; private set; }
        public decimal Him { get; private set; }
        public decimal Bio { get; private set; }

        private decimal Avg()
        {
            return (Bel + Angl + Mat + Fiz + Him + Bio) / 6;
        }

        public Student(decimal Num, string Name, string StudClass,
            decimal Bel, decimal Angl, decimal Mat, decimal Fiz, decimal Him, decimal Bio)
        {
            this.Num = Num;
            this.Name = Name;
            this.StudClass = StudClass;
            this.Bel = Bel;
            this.Angl = Angl;
            this.Mat = Mat;
            this.Fiz = Fiz;
            this.Him = Him;
            this.Bio = Bio;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine(string.Format("№:{0} Име:{1} Клас:{2} {3}", Num, Name, StudClass, Environment.NewLine));
            result.AppendLine(string.Format("БЕЛ:{0} Мат:{1} Английски:{2} {3}", Bel, Mat, Angl, Environment.NewLine));
            result.AppendLine(string.Format("Физика:{0} Химия:{1} Био:{2} {3}", Fiz, Him, Bio, Environment.NewLine));
            result.AppendLine(string.Format("Среден успех:{0}", Avg()));
            result.AppendLine("----------------");

            return result.ToString();
        }
    }
}
