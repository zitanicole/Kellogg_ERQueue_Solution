//Nicci Kellogg
//IT 113
//Notes:
//Behaviors not implemented and why: 
//There is a commented out space between lines 32 and 41 which was what I had toward adding the csv file to the ERQueue, but I couldn't quite 
//I'm not sure if the Add function properly adds to the queue 
//I didn't get to the dequeue portion
//I think the listing the ERQueue portion, maybe the console wont display a list because my enqueue function is not set up properly. not sure. 
//The reason why I didn't get this assignment completed is because taking too many classes ultimately caught up to me. I am extrememly disappointed. This will be the first and only assignment out of every class I've taken with you or Jesse in the past 2 years that I will not be getting a 100% on.
//I am also 3 weeks behind in my statistics class and I will be taking an incomplete grade and hopefully finishing all my work for that class before Winter Quarter begins. I managed to pull through this quarter up until the very last couple of weeks. I still haven't even decorated for Christmas because I literally don't do anything but school work from 8 am until midnight, besides taking my son to after school activites. I am so happy to be done with this quarter, but the state of this assigment has me really worried about my overall grade for this class. I hope you will take my history of past assignments into consideration if this assignment harshly affects my overall grade and give me a chance to improve it if necessary. 

using System.IO;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
namespace Kellogg_ERQueue
{ 

	internal class Program
	{
		
		static void Main(string[] args)
		{
			PriorityQueue<Patient, int> ERQueue = new PriorityQueue<Patient, int>();
			string path;
			path = System.Reflection.Assembly.GetEntryAssembly().Location;
			Console.WriteLine(path);
			path = AppDomain.CurrentDomain.BaseDirectory;
			Console.WriteLine(path);
			path += "Patients-1.csv";
		StreamReader sr = new StreamReader(path);
		string line = sr.ReadLine();
			while(line != null)
			{
			
			Console.WriteLine(line);
				line = sr.ReadLine();

				/*
				string[] data = new string[4];
				data = line.Split(',');
				string Fname = data[0];
				string Lname = data[1];
				string dob = data[2];
				int priority = int.Parse(data[3]);
				Patient patient = new Patient(Fname, Lname, dob, priority);
				ERQueue.Enqueue(patient, patient.Priority);
				*/
			}
		sr.Close();
		Console.WriteLine(line);
			char choice = ' ';
			do
			{
				Console.WriteLine("(A)dd Patient\n(P)rocess Current Patient \n(L)ist All in Queue\n(Q)uit\n");
				choice = char.ToUpper(Console.ReadKey().KeyChar);


				if (choice == 'A')
				{
					Console.WriteLine("\nEnter last name:\n");
					string last = Console.ReadLine();
					Console.WriteLine("\nEnter first name:\n");
					string first = Console.ReadLine();
					Console.WriteLine("\nEnter date of birth MM/DD/YYYY:\n");
					string dob = Console.ReadLine();
					Console.WriteLine("\nEnter priority (1 - 5):\n");
					int priority = int.Parse(Console.ReadLine());
					Patient patient = new Patient(last, first, dob, priority);

					ERQueue.Enqueue(patient, patient.Priority);
				

				}

				if (choice == 'L')
				{
					List<Patient> DisplayList = new List<Patient>();
					int length = DisplayList.Count;
					for (int i = 0; i < length; i++)
					{
						Patient patient = DisplayList[i];
						Console.WriteLine($"{patient}");
	
					}
		
				}

			} while (choice != 'Q');
			if (choice == 'Q')
			Environment.Exit(0);
	    }
    }
}