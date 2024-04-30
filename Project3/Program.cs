using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;

namespace Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This program will help you select exercises for your workout
            //First you will select upper body or lower body, then it will give you a list of exercises for each muscle group in that body region
            //You select one exercise for each muscle group, and then the program will list out your workout plan for that session
            //The program reads data from csv files containing the lists of exercises for each muscle group

            int a = 0;
            bool validInput = false;

            //Getting input from user to determine if we make an upper or lower body workout plan. Using try/catch to check for incorrect inputs
            do
            {
                WriteLine("Are you training upper body or lower body today?: 1-upper 2-lower");
                string userInput = ReadLine();

                try
                {
                    a = int.Parse(userInput);

                    if (a == 1 || a == 2)
                    {
                        validInput = true;
                    }
                    else
                    {
                        WriteLine("You have entered an incorrect number. Please enter 1 for upper body or 2 for lower body");
                    }
                }
                catch (FormatException)
                {
                    WriteLine("Invalid input. Please enter a numeric value");
                }
            } while (!validInput);

            //Creating the list of upper body exercises and then displaying them to the user with headers
            if (a == 1)
            {
                List<UpperWorkoutPlan> exercises = new List<UpperWorkoutPlan>();

                createUpperWorkout(ref exercises);

                WriteLine("Here is your workout plan for today");
                WriteLine("{0,-25}{1,-25}{2,-25}{3,-25}", "CHEST", "SHOULDERS", "UPPER BACK", "ARMS");
                foreach (UpperWorkoutPlan e in exercises)
                {
                    WriteLine("{0,-25}{1,-25}{2,-25}{3,-25}", e.WorkoutChest, e.WorkoutShoulders, e.WorkoutUpperBack, e.WorkoutArms);
                }
            }

            //Same thing but for lower body
            if (a == 2) 
            {
                List<LowerWorkoutPlan> exercises = new List<LowerWorkoutPlan>();

                createLowerWorkout(ref exercises);

                WriteLine("Here is your workout plan for today");
                WriteLine("{0,-25}{1,-25}{2,-25}{3,-25}{4,-25}", "QUADS", "HAMSTRINGS", "GLUTES", "CALVES", "LOWER BACK");
                foreach (LowerWorkoutPlan e in exercises)
                {
                    WriteLine("{0,-25}{1,-25}{2,-25}{3,-25}{4,-25}", e.WorkoutQuads, e.WorkoutHamstrings, e.WorkoutGlutes, e.WorkoutCalves, e.WorkoutLowerBack);
                }
            }

            //Populating lists of exercises for each muscle group by reading data from csv files, then taking input from user to select their preferred exercise for each muscle group
            static void createUpperWorkout(ref List<UpperWorkoutPlan> e)
            {
                var listOfChestExercises = File.ReadLines("ChestExercises.csv").Select(line => new ChestExercise("Upper Body", line)).ToList();
                var listOfShoulderExercises = File.ReadLines("ShoulderExercises.csv").Select(line => new ShoulderExercise("Upper Body", line)).ToList();
                var listOfUpperBackExercises = File.ReadLines("UpperBackExercises.csv").Select(line => new UpperBackExercise("Upper Body", line)).ToList();
                var listOfArmExercises = File.ReadLines("ArmExercises.csv").Select(line => new ArmExercise("Upper Body", line)).ToList();

                WriteLine("For upper body we will be working out the chest, shoulders, upper back, and arms");

                WriteLine("Please select an exercise for chest");
                foreach (ChestExercise exercise in listOfChestExercises)
                {
                    WriteLine($"{exercise.ChestExerciseID}\t{exercise.ChestExerciseName}");
                }
                int b = Convert.ToInt32(ReadLine());
                string chestExercise = listOfChestExercises[b-1].ChestExerciseName;

                WriteLine("Please select an exercise for shoulders");
                foreach (ShoulderExercise exercise in listOfShoulderExercises)
                {
                    WriteLine($"{exercise.ShoulderExerciseID}\t{exercise.ShoulderExerciseName}");
                }
                b = Convert.ToInt32(ReadLine());
                string shoulderExercise = listOfShoulderExercises[b - 1].ShoulderExerciseName;

                WriteLine("Please select an exercise for upper back");
                foreach (UpperBackExercise exercise in listOfUpperBackExercises)
                {
                    WriteLine($"{exercise.UpperBackExerciseID}\t{exercise.UpperBackExerciseName}");
                }
                b = Convert.ToInt32(ReadLine());
                string upperBackExercise = listOfUpperBackExercises[b - 1].UpperBackExerciseName;

                WriteLine("Please select an exercise for arms");
                foreach (ArmExercise exercise in listOfArmExercises)
                {
                    WriteLine($"{exercise.ArmExerciseID}\t{exercise.ArmExerciseName}");
                }
                b = Convert.ToInt32(ReadLine());
                string armExercise = listOfArmExercises[b - 1].ArmExerciseName;

                e.Add(new UpperWorkoutPlan(chestExercise, shoulderExercise, upperBackExercise, armExercise));
            }

            static void createLowerWorkout(ref List<LowerWorkoutPlan> e)
            {
                var listOfQuadExercises = File.ReadLines("QuadExercises.csv").Select(line => new QuadExercise("Lower Body", line)).ToList();
                var listOfHamstringExercises = File.ReadLines("HamstringExercises.csv").Select(line => new HamstringExercise("Lower Body", line)).ToList();
                var listOfGluteExercises = File.ReadLines("GluteExercises.csv").Select(line => new GluteExercise("Lower Body", line)).ToList();
                var listOfCalfExercises = File.ReadLines("CalfExercises.csv").Select(line => new CalfExercise("Lower Body", line)).ToList();
                var listOfLowerBackExercises = File.ReadLines("LowerBackExercises.csv").Select(line => new LowerBackExercise("Lower Body", line)).ToList();

                WriteLine("For lower body we will be working out the quads, hamstrings, glutes, calves, and lower back");

                WriteLine("Please select an exercise for quads");
                foreach (QuadExercise exercise in listOfQuadExercises)
                {
                    WriteLine($"{exercise.QuadExerciseID}\t{exercise.QuadExerciseName}");
                }
                int b = Convert.ToInt32(ReadLine());
                string quadExercise = listOfQuadExercises[b - 1].QuadExerciseName;

                WriteLine("Please select an exercise for hamstrings");
                foreach (HamstringExercise exercise in listOfHamstringExercises)
                {
                    WriteLine($"{exercise.HamstringExerciseID}\t{exercise.HamstringExerciseName}");
                }
                b = Convert.ToInt32(ReadLine());
                string hamstringExercise = listOfHamstringExercises[b - 1].HamstringExerciseName;

                WriteLine("Please select an exercise for glutes");
                foreach (GluteExercise exercise in listOfGluteExercises)
                {
                    WriteLine($"{exercise.GluteExerciseID}\t{exercise.GluteExerciseName}");
                }
                b = Convert.ToInt32(ReadLine());
                string gluteExercise = listOfGluteExercises[b - 1].GluteExerciseName;

                WriteLine("Please select an exercise for calves");
                foreach (CalfExercise exercise in listOfCalfExercises)
                {
                    WriteLine($"{exercise.CalfExerciseID}\t{exercise.CalfExerciseName}");
                }
                b = Convert.ToInt32(ReadLine());
                string calfExercise = listOfCalfExercises[b - 1].CalfExerciseName;

                WriteLine("Please select an exercise for lower back");
                foreach (LowerBackExercise exercise in listOfLowerBackExercises)
                {
                    WriteLine($"{exercise.LowerBackExerciseID}\t{exercise.LowerBackExerciseName}");
                }
                b = Convert.ToInt32(ReadLine());
                string lowerBackExercise = listOfLowerBackExercises[b - 1].LowerBackExerciseName;

                e.Add(new LowerWorkoutPlan(quadExercise, hamstringExercise, gluteExercise, calfExercise, lowerBackExercise));
            }
        }
    }
}
