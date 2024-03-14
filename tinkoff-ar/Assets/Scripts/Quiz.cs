using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public enum QuizFinishLevel
{
    /// <summary>
    /// ��������� ��� �� ������
    /// </summary>
    notStarted,
    /// <summary>
    /// ��������� �������� ��������
    /// </summary>
    partiallyFinished,
    /// <summary>
    /// ��������� �������� ���������
    /// </summary>
    finished

}

/// <summary>
/// ��������� �� ���� �� ����������
/// </summary>
public class Quiz
{
    /// <summary>
    /// ������� �������������
    /// </summary>
    public QuizFinishLevel FinishLevel;
    /// <summary>
    /// ������ ����� �� �������� �����������
    /// </summary>
    public float Prize;
    /// <summary>
    /// ����������� ����� ���������� ������� ��� ��������� �����
    /// </summary>
    public int MinimumForRightAnswers;
    /// <summary>
    /// ������������ ���������
    /// </summary>
    public string Name;
    /// <summary>
    /// ������ ��������
    /// </summary>
    public List<QuizQuestion> Questions;
}


/// <summary>
/// ������ ���������
/// </summary>
public class QuizQuestion
{
    /// <summary>
    /// ���������� �������
    /// </summary>
    public string Content;
    /// <summary>
    /// �������� ��������� �������
    /// </summary>
    public List<QuizAnswer> Answers;
    /// <summary>
    /// �����, ������ �������
    /// </summary>
    public QuizAnswer UserAnswer;
}


/// <summary>
/// ������� ������ �� ������ ���������
/// </summary>
public class QuizAnswer
{
    /// <summary>
    /// �������� �� ����� ����������
    /// </summary>
    public bool Correct;
    /// <summary>
    /// ���������� ������
    /// </summary>
    public string Content;
}

/// <summary>
/// ��������������� �����, ������� ������ ������� � �������
/// </summary>
public static class GetPredefinedData
{
    public static List<Quiz> GetQuizzes()
    {
        return new List<Quiz>()
        {
            new Quiz()
            {
                Name = "������� 1: ������ ��� ������?",
                Prize = 100,
                MinimumForRightAnswers = 2,
                Questions = new List<QuizQuestion>()
                {
                    new QuizQuestion()
                    {
                        Content = "������ ����� ���������� ������ ������� ����� ������� � �������?",
                        Answers = new List<QuizAnswer>()
                        {
                            new QuizAnswer()
                            {
                                Content = "����� �� ������, ��� ����� ������",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "����� ������ ���� �� ������",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "����� �� �������� ������",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "����� ��� �� ��������������",
                                Correct = true,
                            }
                        }
                    },
                    new QuizQuestion()
                    {
                        Content = "����� ������ ������������ � ����� ������?",
                        Answers = new List<QuizAnswer>()
                        {
                            new QuizAnswer()
                            {
                                Content = "������",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "����",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "�����",
                                Correct = true,
                            },
                            new QuizAnswer()
                            {
                                Content = "���� ����������",
                                Correct = false,
                            }
                        }
                    },
                    new QuizQuestion()
                    {
                        Content = "��� ������ ��������� �������� � �������� ����� ������������ ������?",
                        Answers = new List<QuizAnswer>()
                        {
                            new QuizAnswer()
                            {
                                Content = "����� ����",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "������",
                                Correct = true,
                            },
                            new QuizAnswer()
                            {
                                Content = "��������",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "���������",
                                Correct = false,
                            }
                        }
                    }
                }
            },
            new Quiz()
            {
                Name = "������� 2: �������� ����",
                Prize = 200,
                MinimumForRightAnswers = 2,
                Questions = new List<QuizQuestion>()
                {
                    new QuizQuestion()
                    {
                        Content = "��� ����� ���������� ������ ������ ��������� ��������� ����� �� ���������?",
                        Answers = new List<QuizAnswer>()
                        {
                            new QuizAnswer()
                            {
                                Content = "��������� �������� ����",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "��������� �������� ����",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "������ �������",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "����� ��� �� ��������������",
                                Correct = true,
                            }
                        }
                    },
                    new QuizQuestion()
                    {
                        Content = "��� ����� ���������� ����?",
                        Answers = new List<QuizAnswer>()
                        {
                            new QuizAnswer()
                            {
                                Content = "������� ������ ���-�� �������",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "���� �� ���������� ������������ ����������� ���������",
                                Correct = true,
                            },
                            new QuizAnswer()
                            {
                                Content = "������� ����� ������� ",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "����� ��� �� ��������������",
                                Correct = false,
                            }
                        }
                    },
                    new QuizQuestion()
                    {
                        Content = "����� �� ��������� �������� �������� ������ ����������?",
                        Answers = new List<QuizAnswer>()
                        {
                            new QuizAnswer()
                            {
                                Content = "������� �����",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "������������ ����� � ����",
                                Correct = true,
                            },
                            new QuizAnswer()
                            {
                                Content = "����� �� �����������",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "������� ����� �������",
                                Correct = false,
                            }
                        }
                    }
                }
            },
            new Quiz()
            {
                Name = "������� 3: ������ = ���� ?",
                Prize = 1000,
                MinimumForRightAnswers = 2,
                Questions = new List<QuizQuestion>()
                {
                    new QuizQuestion()
                    {
                        Content = "��� ����� ������?",
                        Answers = new List<QuizAnswer>()
                        {
                            new QuizAnswer()
                            {
                                Content = "������, ������� ����� �� ������ ����",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "������, ������� ����� ������� ��� �����������",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "������, ������� ����� ��������� �� ��� ������",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "������, ������� ����� ������� � �������",
                                Correct = true,
                            }
                        }
                    },
                    new QuizQuestion()
                    {
                        Content = "��� ����������, ���� �� ����������� �����, ����������� � ��������� �����?",
                        Answers = new List<QuizAnswer>()
                        {
                            new QuizAnswer()
                            {
                                Content = "���� ������ ��� ���� ��������� �����",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "������",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "���� ��������� �������� ������ � ��������",
                                Correct = true,
                            },
                            new QuizAnswer()
                            {
                                Content = "���� �������� �� ���� � �������",
                                Correct = false,
                            }
                        }
                    },
                    new QuizQuestion()
                    {
                        Content = "��� ����� \"���������� ������\" �� �������?",
                        Answers = new List<QuizAnswer>()
                        {
                            new QuizAnswer()
                            {
                                Content = "�����, ������� �� ������ �������",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "����� ��� �� ��������������",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "�����, ������� �� �������� ��� �������� �������",
                                Correct = false,
                            },
                            new QuizAnswer()
                            {
                                Content = "����� �� ������������� ����� �����",
                                Correct = true,
                            }
                        }
                    }
                }
            },
        };
    }
}