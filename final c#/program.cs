// using System;
// using System.Collections.Generic;
// class User
// {
// 	protected  string ID;
// 	protected  string name;
// 	public  User()
// 	{
// 		Console.Write("Enter your name:");
// 		name = Console.ReadLine();
// 		Console.Write("Enter your ID:");
// 		ID = Console.ReadLine();
// 	}
// 	public virtual void Display()
// 	{
// 		Console.WriteLine("Name:"+name);
// 		Console.WriteLine("ID:"+ID);
// 	}
// }

// class Subject
// {

//     public string[] Subjects = {
//         "1-Introduction Computer Science",
//         "2-Environmental Sciences",
//         "3-English",
//         "4-Electronics",
//         "5-Calculus",
//         "6-Discreet"
//     };

//     public Subject()
//     {
//         Console.WriteLine("YOUR SUBJECTS");
//         for (int i = 0; i < Subjects.Length; i++)
//         {
//             Console.WriteLine(Subjects[i]);
//         }

        
//     }
// }

// class Question
// {
//     public string Text;
//     public string[] Choices;
//     public string CorrectAnswer;
// }

// class PracticalExam 
// {
//      public string input;
//     List<Question> questions = new List<Question>();
//     int score = 0;

//     public PracticalExam() : base()
//     {
//         do
//         {
//              Console.WriteLine("\n These subject have a practical exam \n");
//             List <string>pract=new List<string>{
//                 "1-introduction computer science",
//                 "2-electronics"
//             };
//             for(int i=0;i<pract.Count;i++){
//                 Console.WriteLine(pract[i]);
//             }
//             Console.Write("Choose Subject with number:");

//             input = Console.ReadLine();

//             if (input =="1"||
//                 input =="2")
//             {
                
//                 break;
//             }
//             else
//             {
//                 Console.WriteLine("invalid subject, try again\n");
//             }

//         } while (true);
//              if (input =="1"||
//                  input =="2")
//             {
//                 LoadQuestions();
//                 StartExam();
//             }
        
//     }

//     void LoadQuestions()
//     {
//         if (input =="1")
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
//             questions.Add(new Question
//             {
//                 Text = "RAM is?",
//                 Choices = new string[] { "A) Permanent memory", "B) Temporary memory", "C) Secondary memory", "D) External memory" },
//                 CorrectAnswer = "B"
//             });
//             questions.Add(new Question
//             {
//                 Text = "Which is a programming language?",
//                 Choices = new string[] { "A) HTML", "B) C#", "C) CSS", "D) XML" },
//                 CorrectAnswer = "B"
//             });
//             questions.Add(new Question
//             {
//                 Text = "What is the brain of the computer?",
//                 Choices = new string[] { "A) RAM", "B) Hard Disk", "C) CPU", "D) Monitor" },
//                 CorrectAnswer = "C"
//             });
//         }
//         else if (input == "2")
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
//             questions.Add(new Question
//             {
//                 Text = "Which component stores energy in electric field?",
//                 Choices = new string[] { "A) Inductor", "B) Resistor", "C) Capacitor", "D) Diode" },
//                 CorrectAnswer = "C"
//             });
//             questions.Add(new Question
//             {
//                 Text = "Which component allows current to flow in one direction only?",
//                 Choices = new string[] { "A) Diode", "B) Transistor", "C) Capacitor", "D) Resistor" },
//                 CorrectAnswer = "A"
//             });
//             questions.Add(new Question
//             {
//                 Text = "Transistor is used for?",
//                 Choices = new string[] { "A) Switching and Amplifying", "B) Storing energy", "C) Limiting current", "D) Converting AC to DC" },
//                 CorrectAnswer = "A"
//             });
//         }
//     }

//     void StartExam()
//     {
//         for (int i = 0; i < questions.Count; i++)
//         {
//             Console.WriteLine($"\nQ{i + 1} (5 Marks)");
//             Console.WriteLine(questions[i].Text);

//             foreach (string choice in questions[i].Choices)
//             {
//                 Console.WriteLine(choice);
//             }

//             Console.Write("Your answer: ");
//             string ans = Console.ReadLine().ToUpper();

//             if (ans == questions[i].CorrectAnswer.ToUpper())
//             {
//                 score += 2; // each question 2 points
//                 Console.WriteLine("✔ Correct!\n");
//             }
//             else
//             {
//                 Console.WriteLine($"✖ Wrong! Correct answer is {questions[i].CorrectAnswer}\n");
//             }
//         }

//         Console.WriteLine($"🎯 Your Score: {score} / 10");
//     }
// }

// class FinalExam 
// {
//     protected string input;
//      public string[] fin = {
//         "1-Introduction Computer Science",
//         "2-Environmental Sciences",
//         "3-English",
//         "4-Electronics",
//         "5-Calculus",
//         "6-Discreet"
//     };

//     List<Question> questions = new List<Question>();
//     int score = 0;
//     int totalQuestions = 50;
//     List<string> userAnswers = new List<string>();

//     public FinalExam() : base()
//     {
//          do
//         {
//         for (int i = 0; i < fin.Length; i++)
//         {
//             Console.WriteLine(fin[i]);
//         }
//          Console.Write("Choose Subject:");
//             input = Console.ReadLine();

//             Console.WriteLine($"\nFINAL EXAM FOR: {input.ToUpper()}");
//               if (input == "1" ||
//                 input == "2"||
//                 input =="3"||
//                 input =="4" ||
//                 input =="5"||
//                 input =="6")
//             {
                
//                 break;
//             }
//             else
//             {
//                 Console.WriteLine("invalid subject, try again\n");
//             }

//         } while (true);
//             LoadSubjectQuestions();
//             StartExam();
//             DisplayResult();
        
//     }

//     void LoadSubjectQuestions()
//     {
//         questions.Clear();
        
//         switch (input)
//         { 
//             case "1":
//                 LoadComputerScienceQuestions();
//                 break;
//             case "2":
//                 LoadEnvironmentalSciencesQuestions();
//                 break;
//             case "3":
//                 LoadEnglishQuestions();
//                 break;
//             case "4":
//                 LoadElectronicsQuestions();
//                 break;
//             case "5":
//                 LoadCalculusQuestions();
//                 break;
//             case "6":
//                 LoadDiscreetMathQuestions();
//                 break;
//         }
//     }

//     void LoadEnvironmentalSciencesQuestions()
//     {
//         questions.Add(new Question
//         {
//             Text = "What is the main component of Earth's atmosphere?",
//             Choices = new string[] { "A) Oxygen", "B) Nitrogen", "C) Carbon Dioxide", "D) Argon" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which gas is primarily responsible for global warming?",
//             Choices = new string[] { "A) Oxygen", "B) Nitrogen", "C) Carbon Dioxide", "D) Helium" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the ozone layer?",
//             Choices = new string[] { "A) Layer of clouds", "B) Protective layer against UV rays", "C) Water vapor layer", "D) Pollution layer" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a renewable energy source?",
//             Choices = new string[] { "A) Coal", "B) Natural Gas", "C) Solar Power", "D) Petroleum" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What does deforestation primarily cause?",
//             Choices = new string[] { "A) Increased oxygen", "B) Soil erosion", "C) More rainfall", "D) Cooler climate" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a greenhouse gas?",
//             Choices = new string[] { "A) Oxygen", "B) Nitrogen", "C) Methane", "D) Hydrogen" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is biodiversity?",
//             Choices = new string[] { "A) Variety of life forms", "B) Soil quality", "C) Air purity", "D) Water density" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which organization is known for environmental conservation?",
//             Choices = new string[] { "A) WHO", "B) UNESCO", "C) WWF", "D) FIFA" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the main cause of ocean acidification?",
//             Choices = new string[] { "A) Oil spills", "B) Plastic waste", "C) CO2 absorption", "D) Overfishing" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is an example of non-renewable resource?",
//             Choices = new string[] { "A) Wind", "B) Sunlight", "C) Coal", "D) Geothermal" },
//             CorrectAnswer = "C"
//         });
        
//         // Questions 11-20
//         questions.Add(new Question
//         {
//             Text = "What is the primary source of air pollution in cities?",
//             Choices = new string[] { "A) Factories", "B) Vehicles", "C) Agriculture", "D) Construction" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which layer of atmosphere contains weather phenomena?",
//             Choices = new string[] { "A) Troposphere", "B) Stratosphere", "C) Mesosphere", "D) Thermosphere" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is sustainable development?",
//             Choices = new string[] { "A) Rapid industrialization", "B) Meeting needs without harming future", "C) Maximum resource extraction", "D) Urban expansion" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a major water pollutant?",
//             Choices = new string[] { "A) Oxygen", "B) Nitrogen", "C) Industrial waste", "D) Sand" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What causes acid rain?",
//             Choices = new string[] { "A) Sulfur dioxide emissions", "B) Oxygen release", "C) Water evaporation", "D) Soil erosion" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is an endangered species?",
//             Choices = new string[] { "A) Domestic cat", "B) Pigeon", "C) Tiger", "D) Cow" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the greenhouse effect?",
//             Choices = new string[] { "A) Cooling of Earth", "B) Trapping of heat by gases", "C) Oxygen production", "D) Water cycle" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a natural water purification method?",
//             Choices = new string[] { "A) Chlorination", "B) Filtration through soil", "C) Adding chemicals", "D) Boiling only" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is erosion?",
//             Choices = new string[] { "A) Soil formation", "B) Rock melting", "C) Wearing away of land", "D) Plant growth" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which gas do plants absorb?",
//             Choices = new string[] { "A) Oxygen", "B) Nitrogen", "C) Carbon Dioxide", "D) Hydrogen" },
//             CorrectAnswer = "C"
//         });
        
//         // Questions 21-30
//         questions.Add(new Question
//         {
//             Text = "Rainwater harvesting helps in:",
//             Choices = new string[] { "A) Air pollution", "B) Water conservation", "C) Soil erosion", "D) Deforestation" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the main purpose of wildlife sanctuaries?",
//             Choices = new string[] { "A) Hunting", "B) Animal protection", "C) Mining", "D) Agriculture" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a biodegradable material?",
//             Choices = new string[] { "A) Plastic", "B) Glass", "C) Paper", "D) Metal" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the primary function of forests?",
//             Choices = new string[] { "A) Provide timber only", "B) Maintain ecological balance", "C) Create deserts", "D) Increase temperature" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a consequence of ozone depletion?",
//             Choices = new string[] { "A) Global cooling", "B) Increased UV radiation", "C) More rainfall", "D) Earthquakes" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Composting helps in:",
//             Choices = new string[] { "A) Waste management", "B) Air pollution", "C) Water waste", "D) Noise pollution" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a fossil fuel?",
//             Choices = new string[] { "A) Solar energy", "B) Wind energy", "C) Natural gas", "D) Hydro power" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is desertification?",
//             Choices = new string[] { "A) Forest growth", "B) Land turning into desert", "C) Water formation", "D) Soil enrichment" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a clean energy source?",
//             Choices = new string[] { "A) Coal", "B) Nuclear", "C) Wind", "D) Diesel" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What does EPA stand for?",
//             Choices = new string[] { "A) Environmental Protection Agency", "B) Energy Production Association", "C) Earth Preservation Authority", "D) Ecological Progress Association" },
//             CorrectAnswer = "A"
//         });
        
        
//         questions.Add(new Question
//         {
//             Text = "Recycling reduces waste in landfills. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Plastic bags are biodegradable. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Plants produce oxygen during photosynthesis. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Global warming only affects polar regions. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Water is a renewable resource. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Nuclear energy produces greenhouse gases. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Deforestation increases carbon dioxide in atmosphere. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "All pollution is visible. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Organic farming uses chemical pesticides. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "The Great Barrier Reef is affected by climate change. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
        
//         questions.Add(new Question
//         {
//             Text = "Which country emits the most CO2?",
//             Choices = new string[] { "A) USA", "B) China", "C) India", "D) Russia" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What percentage of Earth's water is freshwater?",
//             Choices = new string[] { "A) 10%", "B) 3%", "C) 25%", "D) 50%" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which animal is a keystone species?",
//             Choices = new string[] { "A) Elephant", "B) Bee", "C) Lion", "D) All of above" },
//             CorrectAnswer = "D"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the main purpose of Kyoto Protocol?",
//             Choices = new string[] { "A) Trade agreement", "B) Reduce greenhouse gases", "C) Military alliance", "D) Space exploration" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is NOT a type of pollution?",
//             Choices = new string[] { "A) Air", "B) Water", "C) Soil", "D) Sound", "E) Light", "F) Happiness" },
//             CorrectAnswer = "F"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is ecological footprint?",
//             Choices = new string[] { "A) Shoe size", "B) Impact on environment", "C) Animal track", "D) Plant root system" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which material takes longest to decompose?",
//             Choices = new string[] { "A) Paper", "B) Banana peel", "C) Plastic bottle", "D) Cotton cloth" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the main goal of Agenda 21?",
//             Choices = new string[] { "A) Sustainable development", "B) Space colonization", "C) Military expansion", "D) Economic monopoly" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which energy source is most abundant?",
//             Choices = new string[] { "A) Coal", "B) Oil", "C) Solar", "D) Natural gas" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the role of decomposers in ecosystem?",
//             Choices = new string[] { "A) Produce oxygen", "B) Break down dead matter", "C) Make food", "D) Control temperature" },
//             CorrectAnswer = "B"
//         });
//     }

//     void LoadComputerScienceQuestions()
//     {
//         questions.Add(new Question
//         {
//             Text = "What does CPU stand for?",
//             Choices = new string[] { "A) Central Process Unit", "B) Central Processing Unit", "C) Computer Personal Unit", "D) Control Program Unit" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is an input device?",
//             Choices = new string[] { "A) Monitor", "B) Printer", "C) Keyboard", "D) Speaker" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is RAM?",
//             Choices = new string[] { "A) Permanent storage", "B) Temporary memory", "C) Processing unit", "D) Output device" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a programming language?",
//             Choices = new string[] { "A) HTML", "B) C#", "C) CSS", "D) XML" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the brain of computer?",
//             Choices = new string[] { "A) RAM", "B) Hard Disk", "C) CPU", "D) Motherboard" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is NOT an operating system?",
//             Choices = new string[] { "A) Windows", "B) Linux", "C) MS Office", "D) macOS" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What does HTTP stand for?",
//             Choices = new string[] { "A) Hyper Text Transfer Protocol", "B) High Tech Transfer Process", "C) Hyper Transfer Text Protocol", "D) High Transfer Text Process" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a database management system?",
//             Choices = new string[] { "A) Excel", "B) Word", "C) MySQL", "D) PowerPoint" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is an algorithm?",
//             Choices = new string[] { "A) Hardware device", "B) Step-by-step procedure", "C) Programming language", "D) Computer brand" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which data structure uses FIFO?",
//             Choices = new string[] { "A) Stack", "B) Queue", "C) Array", "D) Linked List" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is binary system?",
//             Choices = new string[] { "A) Base 10 system", "B) Base 2 system", "C) Base 8 system", "D) Base 16 system" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a high-level language?",
//             Choices = new string[] { "A) Machine code", "B) Assembly", "C) Python", "D) Binary" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What does OOP stand for?",
//             Choices = new string[] { "A) Object-Oriented Programming", "B) Online Operation Process", "C) Organized Object Procedure", "D) Output Operation Program" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a loop structure?",
//             Choices = new string[] { "A) if-else", "B) switch", "C) for", "D) try-catch" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is a compiler?",
//             Choices = new string[] { "A) Hardware device", "B) Program that converts code to machine language", "C) Type of virus", "D) Storage device" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a network device?",
//             Choices = new string[] { "A) Router", "B) Mouse", "C) Keyboard", "D) Monitor" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is cloud computing?",
//             Choices = new string[] { "A) Weather prediction", "B) Internet-based computing", "C) Water cooling system", "D) Satellite communication" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is an example of malware?",
//             Choices = new string[] { "A) Antivirus", "B) Firewall", "C) Virus", "D) Router" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What does URL stand for?",
//             Choices = new string[] { "A) Uniform Resource Locator", "B) Universal Resource Link", "C) Uniform Reference Location", "D) Universal Reference Locator" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a sorting algorithm?",
//             Choices = new string[] { "A) Binary Search", "B) Bubble Sort", "C) Linear Search", "D) DFS" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is a variable?",
//             Choices = new string[] { "A) Constant value", "B) Storage location", "C) Function", "D) Loop" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a scripting language?",
//             Choices = new string[] { "A) C++", "B) Java", "C) JavaScript", "D) C#" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is recursion?",
//             Choices = new string[] { "A) Function calling itself", "B) Infinite loop", "C) Error handling", "D) Data storage" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is NOT a primitive data type?",
//             Choices = new string[] { "A) int", "B) float", "C) string", "D) boolean" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is an IDE?",
//             Choices = new string[] { "A) Integrated Development Environment", "B) Internet Data Exchange", "C) Internal Device Engine", "D) Input Data Editor" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which protocol is used for email?",
//             Choices = new string[] { "A) HTTP", "B) FTP", "C) SMTP", "D) TCP" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is a firewall?",
//             Choices = new string[] { "A) Network security system", "B) Cooling system", "C) Storage device", "D) Programming tool" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a version control system?",
//             Choices = new string[] { "A) Git", "B) Java", "C) Python", "D) SQL" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is SQL used for?",
//             Choices = new string[] { "A) Web design", "B) Database queries", "C) Graphic design", "D) Presentation" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a linear data structure?",
//             Choices = new string[] { "A) Tree", "B) Graph", "C) Array", "D) Map" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "RAM is volatile memory. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "HTML is a programming language. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Python uses indentation for code blocks. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "All programming languages need compilation. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "CPU cache is faster than RAM. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Java is platform independent. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "WiFi uses radio waves. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Binary uses digits 0-9. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Linux is open-source. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Algorithm complexity measures efficiency. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
        
//         questions.Add(new Question
//         {
//             Text = "Which company created Windows?",
//             Choices = new string[] { "A) Apple", "B) Microsoft", "C) Google", "D) IBM" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the smallest unit of data?",
//             Choices = new string[] { "A) Byte", "B) Bit", "C) Kilobyte", "D) Megabyte" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a NoSQL database?",
//             Choices = new string[] { "A) MySQL", "B) Oracle", "C) MongoDB", "D) PostgreSQL" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What does API stand for?",
//             Choices = new string[] { "A) Application Programming Interface", "B) Advanced Programming Instruction", "C) Application Process Integration", "D) Advanced Program Interface" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a cloud service provider?",
//             Choices = new string[] { "A) AWS", "B) USB", "C) CPU", "D) RAM" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is machine learning?",
//             Choices = new string[] { "A) Hardware repair", "B) AI that learns from data", "C) Network setup", "D) Software installation" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a web framework?",
//             Choices = new string[] { "A) Django", "B) Java", "C) C++", "D) SQL" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the Internet?",
//             Choices = new string[] { "A) Global network of networks", "B) Single computer", "C) Software program", "D) Hardware device" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a mobile operating system?",
//             Choices = new string[] { "A) Windows", "B) Linux", "C) Android", "D) macOS" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the purpose of DNS?",
//             Choices = new string[] { "A) Store files", "B) Translate domain names to IP", "C) Run programs", "D) Create websites" },
//             CorrectAnswer = "B"
//         });
//     }

//     void LoadEnglishQuestions()
//     {
        
//         questions.Add(new Question
//         {
//             Text = "Choose the correct spelling:",
//             Choices = new string[] { "A) Recieve", "B) Receive", "C) Receeve", "D) Recive" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the synonym of 'happy'?",
//             Choices = new string[] { "A) Sad", "B) Joyful", "C) Angry", "D) Tired" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a vowel?",
//             Choices = new string[] { "A) B", "B) C", "C) A", "D) D" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the past tense of 'go'?",
//             Choices = new string[] { "A) Went", "B) Gone", "C) Going", "D) Goes" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a plural noun?",
//             Choices = new string[] { "A) Book", "B) Books", "C) Book's", "D) Booking" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Choose the correct article: ___ apple",
//             Choices = new string[] { "A) A", "B) An", "C) The", "D) None" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the opposite of 'hot'?",
//             Choices = new string[] { "A) Warm", "B) Cold", "C) Boiling", "D) Spicy" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which sentence is correct?",
//             Choices = new string[] { "A) He go to school", "B) He goes to school", "C) He going to school", "D) He gone to school" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is a pronoun?",
//             Choices = new string[] { "A) Action word", "B) Describing word", "C) Replaces noun", "D) Naming word" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a conjunction?",
//             Choices = new string[] { "A) And", "B) Happy", "C) Run", "D) Quickly" },
//             CorrectAnswer = "A"
//         });
        
//         // Questions 11-20
//         questions.Add(new Question
//         {
//             Text = "Choose the correct: I ___ studying now.",
//             Choices = new string[] { "A) am", "B) is", "C) are", "D) be" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the meaning of 'benevolent'?",
//             Choices = new string[] { "A) Kind", "B) Angry", "C) Sad", "D) Funny" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is an adverb?",
//             Choices = new string[] { "A) Quick", "B) Quickly", "C) Quickness", "D) Quicken" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the superlative of 'good'?",
//             Choices = new string[] { "A) Gooder", "B) Goodest", "C) Better", "D) Best" },
//             CorrectAnswer = "D"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a preposition?",
//             Choices = new string[] { "A) On", "B) Jump", "C) Beautiful", "D) She" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is a homophone?",
//             Choices = new string[] { "A) Same spelling", "B) Same meaning", "C) Same sound", "D) Same origin" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is correct: There are many ___ in the park.",
//             Choices = new string[] { "A) child", "B) childs", "C) children", "D) childrens" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the passive voice of: 'The cat chased the mouse'",
//             Choices = new string[] { "A) The mouse was chased by the cat", "B) The cat was chased by the mouse", "C) The mouse chased the cat", "D) The cat is chasing the mouse" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a compound word?",
//             Choices = new string[] { "A) Football", "B) Ball", "C) Foot", "D) Playing" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What does 'ESL' stand for?",
//             Choices = new string[] { "A) English Second Language", "B) English as a Second Language", "C) English Speaking Learning", "D) English Study Language" },
//             CorrectAnswer = "B"
//         });
        
//         // Questions 21-30
//         questions.Add(new Question
//         {
//             Text = "Choose the correct: She ___ to the market yesterday.",
//             Choices = new string[] { "A) go", "B) goes", "C) went", "D) going" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is an antonym of 'begin'?",
//             Choices = new string[] { "A) Start", "B) Commence", "C) End", "D) Continue" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a proper noun?",
//             Choices = new string[] { "A) city", "B) London", "C) country", "D) river" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is a syllable?",
//             Choices = new string[] { "A) Word meaning", "B) Sound unit", "C) Sentence part", "D) Letter type" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is an interjection?",
//             Choices = new string[] { "A) Wow!", "B) Run", "C) Beautiful", "D) Slowly" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the present participle of 'run'?",
//             Choices = new string[] { "A) Ran", "B) Running", "C) Runs", "D) Runned" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a collective noun?",
//             Choices = new string[] { "A) Team", "B) Player", "C) Game", "D) Win" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is a metaphor?",
//             Choices = new string[] { "A) Direct comparison", "B) Using 'like' or 'as'", "C) Sound word", "D) Human traits to objects" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is correct: Neither John nor Mary ___ coming.",
//             Choices = new string[] { "A) is", "B) are", "C) am", "D) be" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is an idiom?",
//             Choices = new string[] { "A) Literal meaning", "B) Figurative expression", "C) Grammar rule", "D) Pronunciation guide" },
//             CorrectAnswer = "B"
//         });
        
//         // Questions 31-40 (True/False)
//         questions.Add(new Question
//         {
//             Text = "'A' and 'An' are indefinite articles. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "'Their' shows possession. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "'Quickly' is an adjective. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "English has 26 letters. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "'To be or not to be' is from Macbeth. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "A paragraph should have one main idea. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "'Its' and 'It's' mean the same. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Shakespeare wrote in Old English. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "'Affect' is usually a verb. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "English is the most spoken language worldwide. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "B"
//         });
        
//         // Questions 41-50
//         questions.Add(new Question
//         {
//             Text = "Who wrote 'Romeo and Juliet'?",
//             Choices = new string[] { "A) Charles Dickens", "B) William Shakespeare", "C) Jane Austen", "D) Mark Twain" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a phrasal verb?",
//             Choices = new string[] { "A) Look up", "B) See", "C) Observe", "D) Watch" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the study of word origins called?",
//             Choices = new string[] { "A) Syntax", "B) Etymology", "C) Phonetics", "D) Semantics" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which punctuation shows excitement?",
//             Choices = new string[] { "A) Period", "B) Comma", "C) Exclamation mark", "D) Question mark" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is a thesis statement?",
//             Choices = new string[] { "A) Main argument", "B) Conclusion", "C) Example", "D) Title" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is the longest word in English?",
//             Choices = new string[] { "A) Supercalifragilisticexpialidocious", "B) Pneumonoultramicroscopicsilicovolcanoconiosis", "C) Antidisestablishmentarianism", "D) Hippopotomonstrosesquippedaliophobia" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What does 'CV' stand for?",
//             Choices = new string[] { "A) Curriculum Vitae", "B) Current Version", "C) Common Vocabulary", "D) Career Vision" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a formal greeting?",
//             Choices = new string[] { "A) Hey", "B) Hi", "C) Hello", "D) Yo" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is a synonym for 'intelligent'?",
//             Choices = new string[] { "A) Smart", "B) Dull", "C) Slow", "D) Simple" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is the correct order: adjectives of size, color, material?",
//             Choices = new string[] { "A) Big red wooden", "B) Red wooden big", "C) Wooden big red", "D) Big wooden red" },
//             CorrectAnswer = "A"
//         });
//     }

//     void LoadElectronicsQuestions()
//     {
//         questions.Add(new Question
//         {
//             Text = "What is the unit of electrical resistance?",
//             Choices = new string[] { "A) Volt", "B) Ampere", "C) Ohm", "D) Watt" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What does LED stand for?",
//             Choices = new string[] { "A) Light Emitting Diode", "B) Low Energy Device", "C) Light Energy Display", "D) Laser Emitting Device" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which component stores electrical charge?",
//             Choices = new string[] { "A) Resistor", "B) Capacitor", "C) Transistor", "D) Inductor" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Ohm's Law states:",
//             Choices = new string[] { "A) V = I/R", "B) V = I × R", "C) V = R/I", "D) V = I + R" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is a semiconductor?",
//             Choices = new string[] { "A) Perfect conductor", "B) Perfect insulator", "C) Partial conductor", "D) Magnetic material" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which device amplifies signals?",
//             Choices = new string[] { "A) Diode", "B) Transistor", "C) Resistor", "D) Capacitor" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the unit of capacitance?",
//             Choices = new string[] { "A) Ohm", "B) Farad", "C) Henry", "D) Tesla" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which circuit has only one path for current?",
//             Choices = new string[] { "A) Parallel", "B) Series", "C) Complex", "D) Mixed" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What converts AC to DC?",
//             Choices = new string[] { "A) Transformer", "B) Rectifier", "C) Inverter", "D) Amplifier" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a logic gate?",
//             Choices = new string[] { "A) AND", "B) OR", "C) NOT", "D) All of above" },
//             CorrectAnswer = "D"
//         });
        
//         // Questions 11-20
//         questions.Add(new Question
//         {
//             Text = "What is the unit of frequency?",
//             Choices = new string[] { "A) Hertz", "B) Watt", "C) Ohm", "D) Volt" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which material is best conductor?",
//             Choices = new string[] { "A) Glass", "B) Copper", "C) Rubber", "D) Wood" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What does IC stand for?",
//             Choices = new string[] { "A) Integrated Circuit", "B) Internal Current", "C) Inductive Capacitance", "D) Input Control" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a passive component?",
//             Choices = new string[] { "A) Transistor", "B) Resistor", "C) Diode", "D) IC" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is Kirchhoff's Current Law?",
//             Choices = new string[] { "A) Sum of currents at junction = 0", "B) Voltage drops sum to source", "C) Power conservation", "D) Energy conservation" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which device stores energy in magnetic field?",
//             Choices = new string[] { "A) Capacitor", "B) Inductor", "C) Resistor", "D) Diode" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the unit of inductance?",
//             Choices = new string[] { "A) Farad", "B) Henry", "C) Ohm", "D) Tesla" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a digital circuit?",
//             Choices = new string[] { "A) Amplifier", "B) Filter", "C) Counter", "D) Oscillator" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is a multimeter used for?",
//             Choices = new string[] { "A) Measure multiple parameters", "B) Generate signals", "C) Store data", "D) Amplify sound" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is NOT a type of diode?",
//             Choices = new string[] { "A) Zener", "B) LED", "C) Transistor", "D) Photodiode" },
//             CorrectAnswer = "C"
//         });
        
//         // Questions 21-30
//         questions.Add(new Question
//         {
//             Text = "What is the color code for 1kΩ resistor?",
//             Choices = new string[] { "A) Brown-Black-Red", "B) Red-Black-Brown", "C) Brown-Black-Orange", "D) Brown-Black-Black" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is an active component?",
//             Choices = new string[] { "A) Transistor", "B) Resistor", "C) Capacitor", "D) Inductor" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the unit of power?",
//             Choices = new string[] { "A) Volt", "B) Watt", "C) Joule", "D) Ampere" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which circuit has multiple paths?",
//             Choices = new string[] { "A) Series", "B) Parallel", "C) Linear", "D) Nonlinear" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is a transformer used for?",
//             Choices = new string[] { "A) Change voltage level", "B) Store energy", "C) Convert AC to DC", "D) Amplify signals" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a sensor?",
//             Choices = new string[] { "A) Thermistor", "B) Resistor", "C) Capacitor", "D) Inductor" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the function of a fuse?",
//             Choices = new string[] { "A) Overcurrent protection", "B) Voltage regulation", "C) Signal amplification", "D) Energy storage" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a voltage source?",
//             Choices = new string[] { "A) Battery", "B) Resistor", "C) Capacitor", "D) Inductor" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is soldering?",
//             Choices = new string[] { "A) Joining metals with alloy", "B) Cutting wires", "C) Measuring current", "D) Programming chips" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is an analog circuit?",
//             Choices = new string[] { "A) Amplifier", "B) Counter", "C) Flip-flop", "D) Register" },
//             CorrectAnswer = "A"
//         });
        
//         // Questions 31-40 (True/False)
//         questions.Add(new Question
//         {
//             Text = "Current flows from positive to negative. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "A diode allows current in both directions. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Capacitors block DC. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Transistors have two terminals. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Resistance increases with temperature for metals. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "AC means Alternating Current. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "LEDs work only with DC. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "A voltmeter is connected in series. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Silicon is a common semiconductor. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Power = Voltage × Current. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
//         // Questions 41-50
//         questions.Add(new Question
//         {
//             Text = "What is the typical voltage of AA battery?",
//             Choices = new string[] { "A) 1.5V", "B) 9V", "C) 3V", "D) 12V" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a programmable device?",
//             Choices = new string[] { "A) Resistor", "B) Capacitor", "C) Microcontroller", "D) Diode" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is a PCB?",
//             Choices = new string[] { "A) Printed Circuit Board", "B) Power Control Box", "C) Program Counter Buffer", "D) Pulse Code Broadcast" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a communication protocol?",
//             Choices = new string[] { "A) I2C", "B) USB", "C) SPI", "D) All of above" },
//             CorrectAnswer = "D"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is an op-amp?",
//             Choices = new string[] { "A) Operational amplifier", "B) Optical amplifier", "C) Output amplifier", "D) Oscillating amplifier" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a display technology?",
//             Choices = new string[] { "A) LCD", "B) LED", "C) OLED", "D) All of above" },
//             CorrectAnswer = "D"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is a relay?",
//             Choices = new string[] { "A) Electromagnetic switch", "B) Resistor type", "C) Capacitor type", "D) Transistor type" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which company makes Arduino?",
//             Choices = new string[] { "A) Microsoft", "B) Apple", "C) Arduino LLC", "D) Google" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is a potentiometer?",
//             Choices = new string[] { "A) Variable resistor", "B) Fixed resistor", "C) Capacitor", "D) Inductor" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a wireless technology?",
//             Choices = new string[] { "A) Bluetooth", "B) WiFi", "C) RFID", "D) All of above" },
//             CorrectAnswer = "D"
//         });
//     }

//     void LoadCalculusQuestions()
//     {
//         // 50 سؤال في التفاضل والتكامل
//         questions.Add(new Question
//         {
//             Text = "What is the derivative of x²?",
//             Choices = new string[] { "A) x", "B) 2x", "C) 2", "D) x³/3" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "∫(2x)dx = ?",
//             Choices = new string[] { "A) x²", "B) 2x²", "C) x² + C", "D) 2x + C" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the derivative of sin(x)?",
//             Choices = new string[] { "A) cos(x)", "B) -cos(x)", "C) -sin(x)", "D) tan(x)" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the limit as x→0 of sin(x)/x?",
//             Choices = new string[] { "A) 0", "B) 1", "C) ∞", "D) -1" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "d/dx(eˣ) = ?",
//             Choices = new string[] { "A) eˣ", "B) ln(x)", "C) xeˣ", "D) 0" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "∫(1/x)dx = ?",
//             Choices = new string[] { "A) ln|x| + C", "B) 1/x² + C", "C) x + C", "D) ln(x) + C" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the derivative of ln(x)?",
//             Choices = new string[] { "A) 1/x", "B) x", "C) eˣ", "D) 0" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is ∫cos(x)dx?",
//             Choices = new string[] { "A) sin(x) + C", "B) -sin(x) + C", "C) cos(x) + C", "D) -cos(x) + C" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the second derivative called?",
//             Choices = new string[] { "A) Acceleration", "B) Velocity", "C) Slope", "D) Tangent" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "d/dx(xⁿ) = ?",
//             Choices = new string[] { "A) nxⁿ⁻¹", "B) xⁿ⁺¹", "C) n!x", "D) 0" },
//             CorrectAnswer = "A"
//         });
        
//         // Questions 11-20
//         questions.Add(new Question
//         {
//             Text = "What is the chain rule?",
//             Choices = new string[] { "A) d/dx[f(g(x))] = f'(g(x))·g'(x)", "B) Product of derivatives", "C) Sum of functions", "D) Quotient rule" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "∫eˣ dx = ?",
//             Choices = new string[] { "A) eˣ + C", "B) ln(x) + C", "C) xeˣ + C", "D) eˣ/x + C" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the derivative of constant?",
//             Choices = new string[] { "A) 0", "B) 1", "C) Constant", "D) ∞" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is ∫dx?",
//             Choices = new string[] { "A) x + C", "B) 1 + C", "C) 0", "D) C" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "d/dx(tan(x)) = ?",
//             Choices = new string[] { "A) sec²(x)", "B) cos²(x)", "C) cot(x)", "D) sin(x)" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the product rule?",
//             Choices = new string[] { "A) (uv)' = u'v + uv'", "B) (uv)' = u'v'", "C) (u/v)' = u'v - uv'", "D) Chain rule" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "∫sin(x)dx = ?",
//             Choices = new string[] { "A) -cos(x) + C", "B) cos(x) + C", "C) sin(x) + C", "D) -sin(x) + C" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the derivative of √x?",
//             Choices = new string[] { "A) 1/(2√x)", "B) √x", "C) 2√x", "D) x^(-1/2)" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is L'Hôpital's Rule used for?",
//             Choices = new string[] { "A) Evaluate limits", "B) Integrate functions", "C) Differentiate products", "D) Solve equations" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "∫xⁿ dx = ? (n ≠ -1)",
//             Choices = new string[] { "A) xⁿ⁺¹/(n+1) + C", "B) nxⁿ⁻¹ + C", "C) ln|x| + C", "D) xⁿ + C" },
//             CorrectAnswer = "A"
//         });
        
//         // Questions 21-30
//         questions.Add(new Question
//         {
//             Text = "What is the quotient rule?",
//             Choices = new string[] { "A) (u/v)' = (u'v - uv')/v²", "B) (u/v)' = u'v'", "C) (u/v)' = u'/v'", "D) Product rule" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "d/dx(cos(x)) = ?",
//             Choices = new string[] { "A) -sin(x)", "B) sin(x)", "C) -cos(x)", "D) tan(x)" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is definite integral?",
//             Choices = new string[] { "A) Area under curve", "B) Slope of tangent", "C) Rate of change", "D) Limit" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "∫sec²(x)dx = ?",
//             Choices = new string[] { "A) tan(x) + C", "B) sec(x) + C", "C) cot(x) + C", "D) sin(x) + C" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the derivative of arcsin(x)?",
//             Choices = new string[] { "A) 1/√(1-x²)", "B) 1/(1+x²)", "C) √(1-x²)", "D) -1/√(1-x²)" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is integration by parts?",
//             Choices = new string[] { "A) ∫u dv = uv - ∫v du", "B) Chain rule", "C) Product rule", "D) Quotient rule" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "d/dx(aˣ) = ?",
//             Choices = new string[] { "A) aˣ ln(a)", "B) xaˣ⁻¹", "C) aˣ", "D) 0" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the fundamental theorem of calculus?",
//             Choices = new string[] { "A) Connects differentiation and integration", "B) Product rule", "C) Chain rule", "D) Limits" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "∫1/(1+x²) dx = ?",
//             Choices = new string[] { "A) arctan(x) + C", "B) ln(1+x²) + C", "C) arcsin(x) + C", "D) 2x/(1+x²) + C" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is implicit differentiation?",
//             Choices = new string[] { "A) Differentiate both sides of equation", "B) Explicit formula", "C) Chain rule only", "D) Product rule" },
//             CorrectAnswer = "A"
//         });
        
//         // Questions 31-40 (True/False)
//         questions.Add(new Question
//         {
//             Text = "Derivative of constant is zero. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "∫f'(x)dx = f(x) + C. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "All continuous functions are differentiable. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "d/dx(x³) = 3x². (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "∫0 dx = C. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Derivative measures slope. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Integral measures area. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Chain rule is for composite functions. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "L'Hôpital's Rule requires 0/0 form. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Derivative of |x| exists at x=0. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "B"
//         });
        
//         // Questions 41-50
//         questions.Add(new Question
//         {
//             Text = "Who developed calculus independently?",
//             Choices = new string[] { "A) Newton and Leibniz", "B) Einstein", "C) Pythagoras", "D) Euclid" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the derivative of sec(x)?",
//             Choices = new string[] { "A) sec(x)tan(x)", "B) -csc(x)cot(x)", "C) -sin(x)", "D) cos(x)" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "∫csc²(x)dx = ?",
//             Choices = new string[] { "A) -cot(x) + C", "B) tan(x) + C", "C) -tan(x) + C", "D) cot(x) + C" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is differential equation?",
//             Choices = new string[] { "A) Equation involving derivatives", "B) Algebraic equation", "C) Polynomial", "D) Inequality" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is u-substitution?",
//             Choices = new string[] { "A) Integration technique", "B) Differentiation rule", "C) Limit evaluation", "D) Series expansion" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "d/dx(arctan(x)) = ?",
//             Choices = new string[] { "A) 1/(1+x²)", "B) 1/√(1-x²)", "C) -1/(1+x²)", "D) √(1+x²)" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the mean value theorem?",
//             Choices = new string[] { "A) f'(c) = [f(b)-f(a)]/(b-a)", "B) Intermediate value", "C) Extreme value", "D) Rolle's theorem" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "∫1/√(1-x²) dx = ?",
//             Choices = new string[] { "A) arcsin(x) + C", "B) arccos(x) + C", "C) arctan(x) + C", "D) ln|x| + C" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is partial derivative?",
//             Choices = new string[] { "A) Derivative with respect to one variable", "B) Total derivative", "C) Ordinary derivative", "D) Integral" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is Taylor series?",
//             Choices = new string[] { "A) Infinite polynomial approximation", "B) Finite sum", "C) Differential equation", "D) Integral form" },
//             CorrectAnswer = "A"
//         });
//     }

//     void LoadDiscreetMathQuestions()
//     {
//         questions.Add(new Question
//         {
//             Text = "Which is a logical connective?",
//             Choices = new string[] { "A) AND", "B) OR", "C) NOT", "D) All of above" },
//             CorrectAnswer = "D"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is a set?",
//             Choices = new string[] { "A) Collection of distinct objects", "B) Sequence of numbers", "C) Mathematical operation", "D) Logical statement" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a graph theory concept?",
//             Choices = new string[] { "A) Vertex", "B) Edge", "C) Node", "D) All of above" },
//             CorrectAnswer = "D"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is propositional logic?",
//             Choices = new string[] { "A) Study of logical statements", "B) Set operations", "C) Number theory", "D) Calculus" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a binary operation?",
//             Choices = new string[] { "A) Union", "B) Intersection", "C) Complement", "D) A and B" },
//             CorrectAnswer = "D"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is a function?",
//             Choices = new string[] { "A) Mapping from domain to codomain", "B) Set of ordered pairs", "C) Both A and B", "D) None" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a proof technique?",
//             Choices = new string[] { "A) Mathematical induction", "B) Direct proof", "C) Contradiction", "D) All of above" },
//             CorrectAnswer = "D"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is combinatorics?",
//             Choices = new string[] { "A) Study of counting", "B) Arrangements", "C) Selections", "D) All of above" },
//             CorrectAnswer = "D"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a relation property?",
//             Choices = new string[] { "A) Reflexive", "B) Symmetric", "C) Transitive", "D) All of above" },
//             CorrectAnswer = "D"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is Boolean algebra?",
//             Choices = new string[] { "A) Algebra of truth values", "B) Binary operations", "C) Logical gates", "D) All of above" },
//             CorrectAnswer = "D"
//         });
        
//         // Questions 11-20
//         questions.Add(new Question
//         {
//             Text = "What is a tree in graph theory?",
//             Choices = new string[] { "A) Connected acyclic graph", "B) Cycle graph", "C) Complete graph", "D) Directed graph" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a counting principle?",
//             Choices = new string[] { "A) Multiplication principle", "B) Addition principle", "C) Both", "D) None" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is a permutation?",
//             Choices = new string[] { "A) Ordered arrangement", "B) Unordered selection", "C) Combination", "D) Set" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a logical equivalence?",
//             Choices = new string[] { "A) De Morgan's Law", "B) Distributive Law", "C) Associative Law", "D) All of above" },
//             CorrectAnswer = "D"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is modular arithmetic?",
//             Choices = new string[] { "A) Arithmetic of remainders", "B) Clock arithmetic", "C) Both", "D) None" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a graph type?",
//             Choices = new string[] { "A) Directed", "B) Undirected", "C) Weighted", "D) All of above" },
//             CorrectAnswer = "D"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is a recurrence relation?",
//             Choices = new string[] { "A) Equation defining sequence", "B) Recursive definition", "C) Both", "D) None" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a set operation?",
//             Choices = new string[] { "A) Union", "B) Intersection", "C) Difference", "D) All of above" },
//             CorrectAnswer = "D"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is predicate logic?",
//             Choices = new string[] { "A) Logic with quantifiers", "B) Propositional logic extension", "C) Both", "D) None" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a proof by contradiction?",
//             Choices = new string[] { "A) Assume opposite, derive contradiction", "B) Direct proof", "C) Induction", "D) Exhaustion" },
//             CorrectAnswer = "A"
//         });
        
//         // Questions 21-30
//         questions.Add(new Question
//         {
//             Text = "What is a bipartite graph?",
//             Choices = new string[] { "A) Vertices divided into two sets", "B) Complete graph", "C) Tree", "D) Cycle" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a logical quantifier?",
//             Choices = new string[] { "A) ∀ (for all)", "B) ∃ (there exists)", "C) Both", "D) None" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the pigeonhole principle?",
//             Choices = new string[] { "A) If n items in m containers, n>m, one container has >1 item", "B) Counting principle", "C) Both", "D) None" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a graph algorithm?",
//             Choices = new string[] { "A) Dijkstra's", "B) DFS", "C) BFS", "D) All of above" },
//             CorrectAnswer = "D"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is a generating function?",
//             Choices = new string[] { "A) Represents sequence as power series", "B) Counting tool", "C) Both", "D) None" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a relation type?",
//             Choices = new string[] { "A) Equivalence", "B) Partial order", "C) Total order", "D) All of above" },
//             CorrectAnswer = "D"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is a Hamiltonian path?",
//             Choices = new string[] { "A) Visits each vertex exactly once", "B) Euler path", "C) Shortest path", "D) Minimum spanning tree" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a combinatorial identity?",
//             Choices = new string[] { "A) Pascal's identity", "B) Binomial theorem", "C) Both", "D) None" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is a truth table?",
//             Choices = new string[] { "A) Lists all truth values", "B) Logical equivalence check", "C) Both", "D) None" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a discrete structure?",
//             Choices = new string[] { "A) Set", "B) Graph", "C) Tree", "D) All of above" },
//             CorrectAnswer = "D"
//         });
        
//         // Questions 31-40 (True/False)
//         questions.Add(new Question
//         {
//             Text = "Discrete math deals with continuous values. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "A set can have duplicate elements. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "All graphs have Euler circuits. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Mathematical induction proves for all natural numbers. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "A function can map one input to multiple outputs. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Every tree is a graph. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Propositional logic uses quantifiers. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "The empty set is a subset of every set. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "A relation can be reflexive and irreflexive. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "B"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Combinatorics includes permutations and combinations. (True/False)",
//             Choices = new string[] { "A) True", "B) False" },
//             CorrectAnswer = "A"
//         });
        
//         // Questions 41-50
//         questions.Add(new Question
//         {
//             Text = "Who is considered father of graph theory?",
//             Choices = new string[] { "A) Euler", "B) Gauss", "C) Pascal", "D) Leibniz" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the complement of a graph?",
//             Choices = new string[] { "A) Same vertices, complementary edges", "B) Reverse edges", "C) Weighted version", "D) Directed version" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a logical fallacy?",
//             Choices = new string[] { "A) Affirming the consequent", "B) Denying the antecedent", "C) Both", "D) None" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the principle of inclusion-exclusion?",
//             Choices = new string[] { "A) Counting principle for unions", "B) Set cardinality", "C) Both", "D) None" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a planar graph?",
//             Choices = new string[] { "A) Can be drawn without edge crossings", "B) Complete graph K5", "C) Both", "D) None" },
//             CorrectAnswer = "A"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is a monoid?",
//             Choices = new string[] { "A) Set with associative binary operation and identity", "B) Group without inverses", "C) Both", "D) None" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a proof by cases?",
//             Choices = new string[] { "A) Consider all possible cases", "B) Exhaust all possibilities", "C) Both", "D) None" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is chromatic number?",
//             Choices = new string[] { "A) Minimum colors for vertex coloring", "B) Graph coloring", "C) Both", "D) None" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "Which is a recurrence relation solution method?",
//             Choices = new string[] { "A) Characteristic equation", "B) Generating function", "C) Both", "D) None" },
//             CorrectAnswer = "C"
//         });
        
//         questions.Add(new Question
//         {
//             Text = "What is the study of discrete math essential for?",
//             Choices = new string[] { "A) Computer science", "B) Cryptography", "C) Algorithms", "D) All of above" },
//             CorrectAnswer = "D"
//         });
//     }

//     void StartExam()
//     {
//         Console.WriteLine("\nInstructions:");
//         Console.WriteLine("1. Answer all 50 questions");
//         Console.WriteLine("2. Type A, B, C, or D for your answer");
//         Console.WriteLine("3. Each question worth 1 mark");
//         Console.WriteLine("\nPress Enter to begin...");
//         Console.ReadLine();

//         score = 0;
//         userAnswers.Clear();
//         Random rnd = new Random();
//         var shuffledQuestions = questions.OrderBy(q => rnd.Next()).Take(totalQuestions).ToList();

//         for (int i = 0; i < shuffledQuestions.Count; i++)
//         {
//             Console.Clear();
//             Console.WriteLine($"Question {i + 1} of {totalQuestions}");
//             Console.WriteLine("══════════════════════════════════════════");
//             Console.WriteLine($"Q{i + 1}: {shuffledQuestions[i].Text} (1 mark)");

//             foreach (var choice in shuffledQuestions[i].Choices)
//             {
//                 Console.WriteLine($"  {choice}");
//             }

//             Console.Write("\nYour answer (A/B/C/D): ");
//             string answer = Console.ReadLine()?.Trim().ToUpper();

//             while (string.IsNullOrEmpty(answer) || !"ABCDEF".Contains(answer))
//             {
//                 Console.Write("Invalid input. Please enter A, B, C, or D: ");
//                 answer = Console.ReadLine()?.Trim().ToUpper();
//             }

//             userAnswers.Add(answer);

           
//             if (answer == shuffledQuestions[i].CorrectAnswer)
//             {
//                 score++;
//             }

           
//             if (i < shuffledQuestions.Count - 1)
//             {
//                 Console.WriteLine("\nMoving to next question...");
//                 Thread.Sleep(1000);
//             }
//         }

//         Console.WriteLine("\nExam completed! Calculating results...");
//         Thread.Sleep(2000);
//     }

//     void DisplayResult()
//     {
//         Console.Clear();
//         double percentage = (double)score / totalQuestions * 100;
        
//         Console.WriteLine("══════════════════════════════════════════");
//         Console.WriteLine("              EXAM RESULTS                ");
//         Console.WriteLine("══════════════════════════════════════════");
    
//         Console.WriteLine($"Subject: {input.ToUpper()}");
//         Console.WriteLine($"Total Questions: {totalQuestions}");
//         Console.WriteLine($"Marks per Question: 1");
//         Console.WriteLine($"Correct Answers: {score}");
//         Console.WriteLine($"Total Marks: {score}/{totalQuestions}");
//         Console.WriteLine($"Percentage: {percentage:F1}%");
//         Console.WriteLine("══════════════════════════════════════════");
        
//         if (percentage >= 90)
//         {
//             Console.WriteLine("Grade: A+ (Excellent!)");
//             Console.WriteLine("Remarks: Outstanding performance!");
//         }
//         else if (percentage >= 80)
//         {
//             Console.WriteLine("Grade: A (Very Good)");
//             Console.WriteLine("Remarks: Excellent work!");
//         }
//         else if (percentage >= 70)
//         {
//             Console.WriteLine("Grade: B (Good)");
//             Console.WriteLine("Remarks: Good performance!");
//         }
//         else if (percentage >= 60)
//         {
//             Console.WriteLine("Grade: C (Satisfactory)");
//             Console.WriteLine("Remarks: You passed!");
//         }
//         else if (percentage >= 50)
//         {
//             Console.WriteLine("Grade: D (Pass)");
//             Console.WriteLine("Remarks: Minimum passing grade.");
//         }
//         else
//         {
//             Console.WriteLine("Grade: F (Fail)");
//             Console.WriteLine("Remarks: Needs improvement.");
//         }
        
//         Console.WriteLine("══════════════════════════════════════════");
        
//         // عرض الإجابات الصحيحة والخاطئة
//         Console.WriteLine("\nWould you like to review your answers? (Y/N): ");
//         string review = Console.ReadLine()?.Trim().ToUpper();
        
//         if (review == "Y")
//         {
//             Console.Clear();
//             Console.WriteLine("══════════════════════════════════════════");
//             Console.WriteLine("             ANSWER REVIEW                ");
//             Console.WriteLine("══════════════════════════════════════════");
            
//             for (int i = 0; i < Math.Min(userAnswers.Count, 50); i++)
//             {
//                 Console.WriteLine($"Q{i + 1}: Your answer: {userAnswers[i]} | Correct: {questions[i].CorrectAnswer} | " + 
//                                 (userAnswers[i] == questions[i].CorrectAnswer ? "✓ Correct" : "✗ Incorrect"));
//             }
//         }
        
//         Console.WriteLine("\n══════════════════════════════════════════");
//         if (percentage >= 50)
//             Console.WriteLine("CONGRATULATIONS! You passed the final exam! 🎉");
//         else
//             Console.WriteLine("Don't give up! Review the material and try again. 💪");
            
//         Console.WriteLine("\nPress Enter to return to main menu...");
//         Console.ReadLine();
//     }
// }



// class Program
// {
//     static void Main()
//     {
//         Console.Clear();
        
//         // تصميم نيون للعنوان الرئيسي
//         Console.ForegroundColor = ConsoleColor.Cyan;
//         Console.WriteLine("\n");
//         Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
//         Console.WriteLine("║                                                            ║");
//         Console.ForegroundColor = ConsoleColor.Magenta;
//         Console.WriteLine("║    ███████╗██╗  ██╗ █████╗ ███╗   ███╗██╗███╗   ██╗        ║");
//         Console.WriteLine("║    ██╔════╝╚██╗██╔╝██╔══██╗████╗ ████║██║████╗  ██║        ║");
//         Console.WriteLine("║    █████╗   ╚███╔╝ ███████║██╔████╔██║██║██╔██╗ ██║        ║");
//         Console.WriteLine("║    ██╔══╝   ██╔██╗ ██╔══██║██║╚██╔╝██║██║██║╚██╗██║        ║");
//         Console.WriteLine("║    ███████╗██╔╝ ██╗██║  ██║██║ ╚═╝ ██║██║██║ ╚████║        ║");
//         Console.WriteLine("║    ╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝╚═╝     ╚═╝╚═╝╚═╝  ╚═══╝        ║");
//         Console.ForegroundColor = ConsoleColor.Cyan;
//         Console.WriteLine("║                                                            ║");
//         Console.WriteLine("║     E X A M I N A T I O N   S Y S T E M                    ║");
//         Console.WriteLine("║                                powered by:yousef karim     ║");
//         Console.WriteLine("║                                                            ║");
//         Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
//         Console.ResetColor();
        
    
//         bool exit = false;
//     User d=new User();
//     Subject s=new Subject();
//     string type;
//     int Type;
//      do{Console.Write("\n Entre The Exam type 1-final or 2-practical:");
//      type=Console.ReadLine();
//    Type=Convert.ToInt32(type);
//      }while(Type !=1&&Type !=2);
//       if(Type==1){
//    FinalExam f=new FinalExam();
//    }
//    else if (Type == 2)
//        {
//            PracticalExam p=new PracticalExam();
//        }
//     }
// }
