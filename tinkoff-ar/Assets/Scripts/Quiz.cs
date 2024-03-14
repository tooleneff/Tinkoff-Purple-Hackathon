using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public enum QuizFinishLevel
{
    /// <summary>
    /// Викторина еще не начата
    /// </summary>
    notStarted,
    /// <summary>
    /// Викторина пройдена частично
    /// </summary>
    partiallyFinished,
    /// <summary>
    /// Викторина пройдена полностью
    /// </summary>
    finished

}

/// <summary>
/// Викторина со всем ее содержимым
/// </summary>
public class Quiz
{
    /// <summary>
    /// Уровень завершенности
    /// </summary>
    public QuizFinishLevel FinishLevel;
    /// <summary>
    /// Размер приза за успешное прохождение
    /// </summary>
    public float Prize;
    /// <summary>
    /// Минимальное число правильных ответов для получения приза
    /// </summary>
    public int MinimumForRightAnswers;
    /// <summary>
    /// Наименование викторины
    /// </summary>
    public string Name;
    /// <summary>
    /// Список вопросов
    /// </summary>
    public List<QuizQuestion> Questions;
}


/// <summary>
/// Вопрос викторины
/// </summary>
public class QuizQuestion
{
    /// <summary>
    /// Содержимое вопроса
    /// </summary>
    public string Content;
    /// <summary>
    /// Перечень вариантов ответов
    /// </summary>
    public List<QuizAnswer> Answers;
    /// <summary>
    /// Ответ, данный игроком
    /// </summary>
    public QuizAnswer UserAnswer;
}


/// <summary>
/// Вариант ответа на вопрос викторины
/// </summary>
public class QuizAnswer
{
    /// <summary>
    /// Является ли ответ правильным
    /// </summary>
    public bool Correct;
    /// <summary>
    /// Содержимое ответа
    /// </summary>
    public string Content;
}

/// <summary>
/// Преднастроенные данне, которые должны браться с сервера
/// </summary>
public static class GetPredefinedData
{
    public static List<Quiz> GetQuizzes()
    {
        return new List<Quiz>()
        {
            new Quiz()
            {
                Name = "Уровень 1: Деньги или жвачка?",
                Prize = 100,
                MinimumForRightAnswers = 2,
                Questions = new List<QuizQuestion>()
                {
                    new QuizQuestion()
                    {
                        Content = "Почему важно составлять список покупок перед походом в магазин?",
                        Answers = new List<QuizAnswer>()
                        {
                            new QuizAnswer()
                            {
                                Content = "Чтобы не забыть, что нужно купить",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "Чтобы узнать цены на товары",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "Чтобы не покупать лишнее",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "Верно все из перечисленного",
                                Correct = true,
                            }
                        }
                    },
                    new QuizQuestion()
                    {
                        Content = "Какая валюта используется в вашей стране?",
                        Answers = new List<QuizAnswer>()
                        {
                            new QuizAnswer()
                            {
                                Content = "Доллар",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "Евро",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "Рубль",
                                Correct = true,
                            },
                            new QuizAnswer()
                            {
                                Content = "Фунт стерлингов",
                                Correct = false,
                            }
                        }
                    },
                    new QuizQuestion()
                    {
                        Content = "Что раньше считалось деньгами и помогало людям обмениваться вещами?",
                        Answers = new List<QuizAnswer>()
                        {
                            new QuizAnswer()
                            {
                                Content = "Перья птиц",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "Жемчуг",
                                Correct = true,
                            },
                            new QuizAnswer()
                            {
                                Content = "Адаматий",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "Вибраниум",
                                Correct = false,
                            }
                        }
                    }
                }
            },
            new Quiz()
            {
                Name = "Уровень 2: Денежные пути",
                Prize = 200,
                MinimumForRightAnswers = 2,
                Questions = new List<QuizQuestion>()
                {
                    new QuizQuestion()
                    {
                        Content = "Как можно заработать деньги помимо получения карманных денег от родителей?",
                        Answers = new List<QuizAnswer>()
                        {
                            new QuizAnswer()
                            {
                                Content = "Выполнять домашние дела",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "Продавать ненужные вещи",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "Хорошо учиться",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "Верно все из перечисленного",
                                Correct = true,
                            }
                        }
                    },
                    new QuizQuestion()
                    {
                        Content = "Что такое финансовая цель?",
                        Answers = new List<QuizAnswer>()
                        {
                            new QuizAnswer()
                            {
                                Content = "Желание купить что-то дорогое",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "План по достижению определенной финансового состояния",
                                Correct = true,
                            },
                            new QuizAnswer()
                            {
                                Content = "Желание стать богатым ",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "Верно все из перечисленного",
                                Correct = false,
                            }
                        }
                    },
                    new QuizQuestion()
                    {
                        Content = "Какой из следующих способов является формой сбережения?",
                        Answers = new List<QuizAnswer>()
                        {
                            new QuizAnswer()
                            {
                                Content = "Покупка акций",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "Откладывание денег в банк",
                                Correct = true,
                            },
                            new QuizAnswer()
                            {
                                Content = "Траты на развлечения",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "Покупка новой игрушки",
                                Correct = false,
                            }
                        }
                    }
                }
            },
            new Quiz()
            {
                Name = "Уровень 3: Кредит = враг ?",
                Prize = 1000,
                MinimumForRightAnswers = 2,
                Questions = new List<QuizQuestion>()
                {
                    new QuizQuestion()
                    {
                        Content = "Что такое кредит?",
                        Answers = new List<QuizAnswer>()
                        {
                            new QuizAnswer()
                            {
                                Content = "Деньги, которые дарят на долгий срок",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "Деньги, которые можно тратить без ограничений",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "Деньги, которые можно потратить на что угодно",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "Деньги, которые нужно вернуть в будущем",
                                Correct = true,
                            }
                        }
                    },
                    new QuizQuestion()
                    {
                        Content = "Что происходит, если не выплачивать сумму, потраченную с кредитной карты?",
                        Answers = new List<QuizAnswer>()
                        {
                            new QuizAnswer()
                            {
                                Content = "Банк выдает еще одну кредитную карту",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "Ничего",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "Банк начисляет должнику штрафы и проценты",
                                Correct = true,
                            },
                            new QuizAnswer()
                            {
                                Content = "Банк сообщает об этом в полицию",
                                Correct = false,
                            }
                        }
                    },
                    new QuizQuestion()
                    {
                        Content = "Что такое \"процентная ставка\" по кредиту?",
                        Answers = new List<QuizAnswer>()
                        {
                            new QuizAnswer()
                            {
                                Content = "Сумма, которую вы должны вернуть",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "Верно все из перечисленного",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "Сумма, которую вы получите при возврате кредита",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "Плата за использование чужих денег",
                                Correct = true,
                            }
                        }
                    }
                }
            },
        };
    }
}