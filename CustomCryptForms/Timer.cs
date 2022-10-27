using System;

namespace CustomCrypt
{
    public class Timer
    {
        double startTime = 0; // Начальное время в миллисеккундах
        double endTime = 0; // Конечное время в миллисеккундах

        public double subTime
        {
            get { return endTime - startTime; }
        }

        public string Start()
        {
            string msg; // Сообщение о результате работы метода
            if (startTime != 0)
                msg = "Для начала сбросьте таймер командой Reset()";
            
            else
            {
                msg = "Ok";
                startTime = (DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds;
            }

            return msg;
        }

        public string End()
        {
            string msg; // Сообщение о результате работы метода
            if (endTime != 0)
                msg = "Для начала сбросьте таймер командой Reset()";

            else
            {
                msg = "Ok";
                endTime = (DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds;
            }

            return msg;
        }

        public void Reset()
        {
            startTime = 0;
            endTime = 0;
        }
    }
}
