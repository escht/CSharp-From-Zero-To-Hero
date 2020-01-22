﻿using System;
namespace BootCamp.Chapter
{
    public class Lesson3
    {

        public static void Demo()
        {

            EnterUserData();
            EnterUserData();

        }


        public static void EnterUserData()
        {

            string name = Lesson3.PromptFullName("Full name: ");
            Console.WriteLine();

            int age = Lesson3.PromptAge("Age: ");
            Console.WriteLine();

            float weight = Lesson3.PromptWeight("Weight: ");
            Console.WriteLine();

            float height = Lesson3.PromptHeight("Height: ");
            Console.WriteLine();

            float bmi = Lesson3.CalcBmi(weight, height);
            Console.WriteLine();

            Console.WriteLine(name + " is " + age + " years old, their weight is " + weight + "kg and their height is " + height + " m. Their BMI is " + bmi + ".");
            Console.WriteLine();
        }

        public static string PromptFullName(string message)
        {
            Console.WriteLine(message);
            string name = Console.ReadLine();
            return name;
        }

        public static int PromptAge(string message)
        {
            Console.WriteLine(message);
            int age = int.Parse(Console.ReadLine());
            return age;
        }

        public static float PromptWeight(string message)
        {
            Console.WriteLine(message);
            float weight = float.Parse(Console.ReadLine());
            return weight;
        }

        public static float PromptHeight(string message)
        {
            Console.WriteLine(message);
            float height = float.Parse(Console.ReadLine());
            return height;
        }

        public static float CalcBmi(float weight, float height)
        {
            float bmi = weight / (height * height);
            return bmi;
        }
    }
}