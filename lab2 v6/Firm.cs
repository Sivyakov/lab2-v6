using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_v6
{
    class Firm
    {
        public enum Status
        {
            да, нет, ошибка_ввода_данных
        }
        private string name, insurance;
        private int age, salary, rating, index, x1,x2,x3,x4;
        private Status status;
        public string Name
        {
            get { return name; }
            set { if (name != "") name = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {                
                age = value;
                if (age < 5 || age >= 0) x1=0 ;
                else if (age > 5) x1=1;
                else status = Status.ошибка_ввода_данных;
            }
        }
        public int Salary
        {
            get { return salary; }
            set
            {
                salary = value;
                if (salary < 70000 || salary >= 0) x2=0;
                else if (salary > 70000) x2=1;
            }
        }
        public int Rating
        {
            get { return rating; }
            set
            {
                rating = value;
                if (rating < 3.3 || rating >= 0) x3=0;
                else if (rating > 3.3 || rating <= 5) x3=1;
                else status = Status.ошибка_ввода_данных;
            }
        }
        public string Insurance
        {
            get { return insurance; }
            set
            {
                int x4 = 0;
                insurance = value;
                if (insurance == "нет") x4=0;
                else if (insurance == "да") x4=1;
            }
        }
         public int Index
        {
            get { return index; }
            set
            {
                index = x1 + x2 + x3 + x4;
                
            }
        }
        public Status getStatus
        {
            get { return status; }
            set
            {
                getStatus =value;
                if (index > 2) status = Status.да;
                else if(index <= 2 ) status = Status.нет;
                else status = Status.нет;

            }

        }
        public void PrintFilm()
        {
            Console.WriteLine($"Название фирмы: {name} " +
                $"Страховка: {insurance} " +
                $"Время существования фирмы: {age} " +
                $"Заработная плата: {salary} " +
                $"Рейтинг: {rating} " +
                $" Статус: {getStatus} ");
        }
    }
}
