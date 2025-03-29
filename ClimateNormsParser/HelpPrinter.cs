﻿using System;

namespace ClimateNormsParser
{
    public static class HelpPrinter
    {
        public static void ShowHelp()
        {
            Console.WriteLine("Available commands:");
            Console.WriteLine("  help          Show available commands.");
            Console.WriteLine("  parse         Parse climate data. Usage: parse [CountryId] [Period]");
            Console.WriteLine("                Example: parse 1659 1961-1990");
            Console.WriteLine("\nAvailable periods:");
            Console.WriteLine("  1961-1990");
            Console.WriteLine("  1991-2020");

            Console.WriteLine("\nAvailable Country IDs:");
            Console.WriteLine("615 - Австрия");
            Console.WriteLine("2777 - Азербайджан");
            Console.WriteLine("3546 - Алжир");
            Console.WriteLine("2775 - Армения");
            Console.WriteLine("3011 - Афганистан");
            Console.WriteLine("4503 - Багамские острова");
            Console.WriteLine("3069 - Бангладеш");
            Console.WriteLine("4575 - Барбадос");
            Console.WriteLine("3024 - Бахрейн");
            Console.WriteLine("1571 - Беларусь");
            Console.WriteLine("326 - Бельгия");
            Console.WriteLine("3831 - Бенин");
            Console.WriteLine("954 - Болгария");
            Console.WriteLine("4458 - Боливия");
            Console.WriteLine("3851 - Буркина Фасо");
            Console.WriteLine("253 - Великобритания");
            Console.WriteLine("787 - Венгрия");
            Console.WriteLine("4596 - Венесуэла");
            Console.WriteLine("3335 - Вьетнам");
            Console.WriteLine("3789 - Габон");
            Console.WriteLine("3681 - Гамбия");
            Console.WriteLine("3847 - Гана");
            Console.WriteLine("4618 - Гвиана");
            Console.WriteLine("3687 - Гвинея");
            Console.WriteLine("3682 - Гвинея-Бисау");
            Console.WriteLine("498 - Германия");
            Console.WriteLine("438 - Гибралтар");
            Console.WriteLine("4551 - Гондурас");
            Console.WriteLine("290 - Гренландия");
            Console.WriteLine("1032 - Греция");
            Console.WriteLine("2754 - Грузия");
            Console.WriteLine("303 - Дания");
            Console.WriteLine("3746 - Джибути");
            Console.WriteLine("4529 - Доминиканская республика");
            Console.WriteLine("3730 - Египет");
            Console.WriteLine("2959 - Израиль");
            Console.WriteLine("3080 - Индия");
            Console.WriteLine("4978 - Индонезия");
            Console.WriteLine("2967 - Иордания");
            Console.WriteLine("2993 - Ирак");
            Console.WriteLine("3003 - Иран");
            Console.WriteLine("271 - Ирландия");
            Console.WriteLine("278 - Исландия");
            Console.WriteLine("417 - Испания");
            Console.WriteLine("991 - Италия");
            Console.WriteLine("452 - Кабо-Верде");
            Console.WriteLine("2559 - Казахстан");
            Console.WriteLine("3358 - Камбоджа");
            Console.WriteLine("3820 - Камерун");
            Console.WriteLine("4164 - Канада");
            Console.WriteLine("1086 - Кипр");
            Console.WriteLine("4915 - Кирибати");
            Console.WriteLine("3423 - Китай");
            Console.WriteLine("4590 - Колумбия");
            Console.WriteLine("3208 - Корея Северная");
            Console.WriteLine("4539 - Коста-Рика");
            Console.WriteLine("3866 - Кот-Д'Ивуар");
            Console.WriteLine("2990 - Кувейт");
            Console.WriteLine("2803 - Кыргызстан");
            Console.WriteLine("3355 - Лаос");
            Console.WriteLine("1516 - Латвия");
            Console.WriteLine("3872 - Либерия");
            Console.WriteLine("2954 - Ливан");
            Console.WriteLine("3710 - Ливия");
            Console.WriteLine("1562 - Литва");
            Console.WriteLine("336 - Люксембург");
            Console.WriteLine("3662 - Мавритания");
            Console.WriteLine("3329 - Малайзия");
            Console.WriteLine("3653 - Мали");
            Console.WriteLine("1019 - Мальта");
            Console.WriteLine("3524 - Марокко");
            Console.WriteLine("4571 - Мартиника");
            Console.WriteLine("4897 - Маршалловы острова");
            Console.WriteLine("4484 - Мексика");
            Console.WriteLine("4894 - Микронезия");
            Console.WriteLine("2409 - Молдавия");
            Console.WriteLine("3179 - Монголия");
            Console.WriteLine("3289 - Мьянма");
            Console.WriteLine("3196 - Непал");
            Console.WriteLine("3634 - Нигер");
            Console.WriteLine("307 - Нидерланды");
            Console.WriteLine("74 - Норвегия");
            Console.WriteLine("3040 - Оман");
            Console.WriteLine("3044 - Пакистан");
            Console.WriteLine("4898 - Палау");
            Console.WriteLine("747 - Польша");
            Console.WriteLine("451 - Португалия");
            Console.WriteLine("4530 - Пуэрто-Рико");
            Console.WriteLine("3786 - Республика Конго");
            Console.WriteLine("3214 - Республика Корея");
            Console.WriteLine("1659 - Россия");
            Console.WriteLine("926 - Румыния");
            Console.WriteLine("4356 - CWIA");
            Console.WriteLine("2988 - Саудовская Аравия");
            Console.WriteLine("4896 - Северные Марианские острова");
            Console.WriteLine("3673 - Сенегал");
            Console.WriteLine("5005 - Сербия");
            Console.WriteLine("3332 - Сингапур");
            Console.WriteLine("2951 - Сирия");
            Console.WriteLine("3748 - Сомали");
            Console.WriteLine("3744 - Судан");
            Console.WriteLine("3689 - Сьерра-Леоне");
            Console.WriteLine("2922 - Таджикистан");
            Console.WriteLine("3312 - Таиланд");
            Console.WriteLine("3839 - Того");
            Console.WriteLine("4578 - Тринидад и Тобаго");
            Console.WriteLine("3609 - Тунис");
            Console.WriteLine("2924 - Туркменистан");
            Console.WriteLine("1061 - Турция");
            Console.WriteLine("2835 - Узбекистан");
            Console.WriteLine("2357 - Украина");
            Console.WriteLine("4988 - Филиппины");
            Console.WriteLine("216 - Финляндия");
            Console.WriteLine("350 - Франция");
            Console.WriteLine("4933 - Французская Полинезия");
            Console.WriteLine("3803 - Центральная Африканская республика");
            Console.WriteLine("3811 - Чад");
            Console.WriteLine("5006 - Черногория");
            Console.WriteLine("701 - Чехия");
            Console.WriteLine("337 - Швейцария");
            Console.WriteLine("149 - Швеция");
            Console.WriteLine("3149 - Шри Ланка");
            Console.WriteLine("1463 - Эстония");
            Console.WriteLine("3753 - Эфиопия");
            Console.WriteLine("4521 - Ямайка");
            Console.WriteLine("3248 - Япония");
        }
    }
}