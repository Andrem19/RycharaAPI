using RycharaAPI.RycharaLuckyBot.LoggerDB;
using RycharaAPI.RycharaLuckyBot.Settings;
using System;
using System.Threading.Tasks;

namespace RycharaAPI.RycharaLuckyBot
{
    public class GeneralLogic
    {
        public static async Task Process(Guid guid, int num, string name)
        {
            
            Console.WriteLine($"{num}-I'm working.... {guid}");
            //Проверка есть ли открытая позиция

            //Запрос свечей и определение сигнала

            //Если позиция была закрыта в прошлом цикле

            //Нет позиции заходим в проверку сигнала и открытие ордера или позиции

            //Если сигнала нет формирование отчета в телеграм

            //Выставление ордеров если позиция была взята

            //Если устреднение сработало или прошло 35 мин

            //Страховка и отчет при взятой позиции

            //Телеграм отправка
        }
    }
}
