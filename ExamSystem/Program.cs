// using System;
// using System.Collections.Generic;
// class Dataentry
// {
// 	protected  string ID;
// 	protected  string name;
// 	public  Dataentry()
// 	{
// 		Console.Write("Enter your name:");
// 		name = Console.ReadLine();
// 		Console.Write("Enter your ID:");
// 		ID = Console.ReadLine();
// 	}
// 	public virtual void Display()
// 	{
// 		Console.WriteLine("Your Name:"+name);
// 		Console.WriteLine("Your ID:"+ID);
// 	}
// }

// class Academicyear:  Dataentry
// {
// 	protected  int level;
// 	public  Academicyear()
// 	{
// 		do
// 		{
// 			Console.Write("Enter your level (1 or 2):");
// 		}
// 		while (!int.TryParse(Console.ReadLine(), out level) || level < 1 || level > 2);
// 	}
// 	public override void Display()
// 	{
//        base.Display();
// 		Console.WriteLine("Your academic level is:" + level);
// 	}
// }


// class Subject
// {
//     private string subjectName;
    
//     public Subject()
//     {
//         Console.WriteLine("\n=== Choose Your Subject ===");
//         Console.WriteLine("Available Subjects:");
//         Console.WriteLine("1. Environmental Sciences");
//         Console.WriteLine("2. Introduction Computer Science");
//         Console.WriteLine("3. English");
//         Console.WriteLine("4. Electronics");
//         Console.WriteLine("5. Calculus");
//         Console.WriteLine("6. Discreet");
        
//         string[] subjects = {
//             "Environmental Sciences",
//             "Introduction Computer Science",
//             "English",
//             "Electronics",
//             "Calculus",
//             "Discreet"
//         };
        
//         int choice;
//         bool validChoice;
        
//         do
//         {
//             Console.Write("\nEnter subject number (1-6): ");
//             validChoice = int.TryParse(Console.ReadLine(), out choice) && 
//                          choice >= 1 && choice <= 6;
            
//             if (!validChoice)
//             {
//                 Console.WriteLine("Invalid choice! Please enter a number between 1 and 6.");
//             }
//         }
//         while (!validChoice);
        
//         subjectName = subjects[choice - 1];
//         Console.WriteLine($"Subject '{subjectName}' has been selected successfully!");
//     }
// }

// class ExamType
// {
//     protected string typeName;
    
//     public ExamType()
//     {
//         Console.WriteLine("\n=== Choose Exam Type ===");
//         Console.WriteLine("Available Exam Types:");
//         Console.WriteLine("1. Practical Exam");
//         Console.WriteLine("2. Final Exam");
        
//         string[] types = {
//             "Practical",
//             "Final"
//         };
        
//         int choice;
//         bool validChoice;
        
//         do
//         {
//             Console.Write("\nEnter exam type number (1-2): ");
//             validChoice = int.TryParse(Console.ReadLine(), out choice) && 
//                          choice >= 1 && choice <= 2;
            
//             if (!validChoice)
//             {
//                 Console.WriteLine("Invalid choice! Please enter 1 or 2.");
//             }
//         }
//         while (!validChoice);
        
//         typeName = types[choice - 1];
//         Console.WriteLine($"✓ Exam Type '{typeName}' has been selected successfully!");
//     }
    
//     public string GetTypeName() => typeName;
// }

// class Question
// {
//     public string Text { get;set;}
//     public string[] Choices{get;set;}
//     public string CorrectAnswer{get;set;}
// }

// class Exam : ExamType
// {
//     private string subjectName;
    
//     public Exam(string subject) : base() // استدعاء constructor الأب
//     {
//         subjectName = subject;
        
//         // التحقق إذا كان نوع الامتحان متاح لهذه المادة
//         ValidateExamAvailability();
//     }
    
//     private void ValidateExamAvailability()
//     {
//         // المواد التي لديها امتحان عملي
//         string[] practicalSubjects = {
//             "Introduction Computer Science",
//             "Electronics"
//         };
        
//         // المواد التي ليس لديها امتحان عملي
//         string[] nonPracticalSubjects = {
//             "Environmental Sciences",
//             "English",
//             "Calculus",
//             "Discreet"
//         };
        
//         Console.WriteLine($"\n🔍 Validating exam availability for {subjectName}...");
        
//         // التحقق من الامتحان العملي
//         if (typeName.ToLower() == "practical")
//         {
//             bool hasPractical = false;
            
//             foreach (string sub in practicalSubjects)
//             {
//                 if (sub.ToLower() == subjectName.ToLower())
//                 {
//                     hasPractical = true;
//                     break;
//                 }
//             }
            
//             if (hasPractical)
//             {
//                 Console.WriteLine($"✅ {subjectName} has a Practical Exam available!");
//             }
//             else
//             {
//                 Console.WriteLine($"❌ {subjectName} does NOT have a Practical Exam!");
//                 Console.WriteLine("Subjects with Practical Exam are:");
//                 foreach (string sub in practicalSubjects)
//                 {
//                     Console.WriteLine($"  - {sub}");
//                 }
                
//                 // إعادة اختيار نوع الامتحان تلقائياً
//                 RetryExamType();
//             }
//         }
//         // التحقق من الامتحان النهائي (كل المواد لديها امتحان نهائي)
//         else if (typeName.ToLower() == "final")
//         {
//             Console.WriteLine($"✅ {subjectName} has a Final Exam available!");
//         }
//     }
    
//     private void RetryExamType()
//     {
//         Console.WriteLine("\n⚠️ Please choose a different exam type:");
//         Console.WriteLine("1. Final Exam (available for all subjects)");
        
//         int choice;
//         bool validChoice;
        
//         do
//         {
//             Console.Write("\nEnter exam type number (1): ");
//             validChoice = int.TryParse(Console.ReadLine(), out choice) && choice == 1;
            
//             if (!validChoice)
//             {
//                 Console.WriteLine("Invalid choice! Please enter 1.");
//             }
//         }
//         while (!validChoice);
        
//         typeName = "Final";
//         Console.WriteLine($"✓ Exam Type changed to 'Final' successfully!");
//     }
    
//     public void StartExam()
//     {
//         Console.WriteLine($"\n📝 ==== {typeName.ToUpper()} EXAM STARTING ==== 📝");
//         Console.WriteLine($"Subject: {subjectName}");
        
//         if (typeName.ToLower() == "practical")
//         {
//             StartPracticalExam();
//         }
//         else if (typeName.ToLower() == "final")
//         {
//             StartFinalExam();
//         }
//     }
    
//     private void StartPracticalExam()
//     {
//         Console.WriteLine("\nStarting Practical Exam Questions...");
        
//         // أسئلة الامتحان العملي
//         List<Question> questions = new List<Question>();
        
//         if (subjectName.ToLower() == "introduction computer science")
//         {
//             questions.Add(new Question
//             {
//                 Text = "What does CPU stand for?",
//                 Choices = new string[] { "A) Central Process Unit", "B) Central Processing Unit", "C) Computer Personal Unit", "D) Control Program Unit" },
//                 CorrectAnswer = "B"
//             });
//             questions.Add(new Question
//             {
//                 Text = "Which one is an input device?",
//                 Choices = new string[] { "A) Monitor", "B) Printer", "C) Keyboard", "D) Speaker" },
//                 CorrectAnswer = "C"
//             });
//         }
//         else if (subjectName.ToLower() == "electronics")
//         {
//             questions.Add(new Question
//             {
//                 Text = "What is a resistor used for?",
//                 Choices = new string[] { "A) To store data", "B) To limit current", "C) To amplify signal", "D) To convert AC to DC" },
//                 CorrectAnswer = "B"
//             });
//             questions.Add(new Question
//             {
//                 Text = "Ohm's Law formula is?",
//                 Choices = new string[] { "A) V = I + R", "B) V = I × R", "C) V = I / R", "D) V = R / I" },
//                 CorrectAnswer = "B"
//             });
//         }
        
//         // عرض الأسئلة وجمع النقاط
//         int score = 0;
//         for (int i = 0; i < questions.Count; i++)
//         {
//             Console.WriteLine($"\nQ{i + 1}: {questions[i].Text}");
//             foreach (string choice in questions[i].Choices)
//             {
//                 Console.WriteLine(choice);
//             }
            
//             Console.Write("Your answer: ");
//             string answer = Console.ReadLine().ToUpper();
            
//             if (answer == questions[i].CorrectAnswer.ToUpper())
//             {
//                 score += 5;
//                 Console.WriteLine("✅ Correct! +5 points");
//             }
//             else
//             {
//                 Console.WriteLine($"❌ Wrong! Correct answer is {questions[i].CorrectAnswer}");
//             }
//         }
        
//         Console.WriteLine($"\n🎯 Practical Exam Completed!");
//         Console.WriteLine($"Your Score: {score} / {questions.Count * 5}");
//     }
    
//     private void StartFinalExam()
//     {
//         Console.WriteLine("\nStarting Final Exam Questions...");
        
//         List<Question> questions = new List<Question>();
        
//         // كل المواد لديها أسئلة فاينل
//         if (subjectName.ToLower() == "environmental sciences")
//         {
//             questions.Add(new Question
//             {
//                 Text = "What is the main greenhouse gas?",
//                 Choices = new string[] { "A) Oxygen", "B) Carbon Dioxide", "C) Nitrogen", "D) Hydrogen" },
//                 CorrectAnswer = "B"
//             });
//         }
//         else if (subjectName.ToLower() == "introduction computer science")
//         {
//             questions.Add(new Question
//             {
//                 Text = "What does OOP stand for?",
//                 Choices = new string[] { "A) Object-Oriented Programming", "B) Object-Oriented Process", "C) Output Oriented Program", "D) Operational Object Program" },
//                 CorrectAnswer = "A"
//             });
//         }
//         else if (subjectName.ToLower() == "english")
//         {
//             questions.Add(new Question
//             {
//                 Text = "Which is a synonym for 'happy'?",
//                 Choices = new string[] { "A) Sad", "B) Joyful", "C) Angry", "D) Tired" },
//                 CorrectAnswer = "B"
//             });
//         }
//         else if (subjectName.ToLower() == "electronics")
//         {
//             questions.Add(new Question
//             {
//                 Text = "What is the unit of resistance?",
//                 Choices = new string[] { "A) Volt", "B) Ampere", "C) Ohm", "D) Watt" },
//                 CorrectAnswer = "C"
//             });
//         }
//         else if (subjectName.ToLower() == "calculus")
//         {
//             questions.Add(new Question
//             {
//                 Text = "What is the derivative of x²?",
//                 Choices = new string[] { "A) x", "B) 2x", "C) x³/3", "D) 2" },
//                 CorrectAnswer = "B"
//             });
//         }
//         else if (subjectName.ToLower() == "discreet")
//         {
//             questions.Add(new Question
//             {
//                 Text = "What is a set with no elements called?",
//                 Choices = new string[] { "A) Infinite Set", "B) Null Set", "C) Universal Set", "D) Singleton Set" },
//                 CorrectAnswer = "B"
//             });
//         }
        
//         // عرض الأسئلة وجمع النقاط
//         int score = 0;
//         for (int i = 0; i < questions.Count; i++)
//         {
//             Console.WriteLine($"\nQ{i + 1}: {questions[i].Text}");
//             foreach (string choice in questions[i].Choices)
//             {
//                 Console.WriteLine(choice);
//             }
            
//             Console.Write("Your answer: ");
//             string answer = Console.ReadLine().ToUpper();
            
//             if (answer == questions[i].CorrectAnswer.ToUpper())
//             {
//                 score += 10;
//                 Console.WriteLine("✅ Correct! +10 points");
//             }
//             else
//             {
//                 Console.WriteLine($"❌ Wrong! Correct answer is {questions[i].CorrectAnswer}");
//             }
//         }
        
//         Console.WriteLine($"\n🎯 Final Exam Completed!");
//         Console.WriteLine($"Your Score: {score} / {questions.Count * 10}");
//     }
// }


// class HelloWorld
// {
// 	static void Main()
// 	{
//         // Academicyear A=new Academicyear();
//         // A.Display();
//         Subject s=new Subject();
//         ExamType E=new ExamType();
//         Exam e=new Exam(s.GetSubjectName());
//         e.StartExam();
// 	}
// }
