using System;


namespace EnumExercise.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public Double ValuePerhour { get; set; }
        public int Hours { get; set; }

        public HourContract ()
        {

        }

        public HourContract(DateTime date, double valuePerhour, int hours)
        {
            Date = date;
            ValuePerhour = valuePerhour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * ValuePerhour;
        }
    }
}
