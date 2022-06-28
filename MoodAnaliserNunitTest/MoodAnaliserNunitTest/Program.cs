// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome Mood Analyser Problem");

//UC-1
//Given a Message, ability
//to analyse and respond
//Happy or Sad Mood - Create MoodAnalyser Object - Call analyseMood function with message as
//parameter and return Happy or Sad Mood

//REFACTOR
//Refactor the code to take
//the mood message in
//Constructor

//- Note:
//-MoodAnalyser will have a message Field
//- MoodAnalyser will have 2 Constructors –
//Default - MoodAnalyser() and with
//Parameters – MoodAnalyser(message)
//-analyseMood method will change to
//support no parameters and use message
//Field defined for the Class

//RESULT
//Tests
//  Tests in group: 4

//  Total Duration: 14 ms

//Outcomes
//   4 Passed
//------------------------------------------------------------------//
//UC-2
//Handle Exception if User Provides Invalid Mood
//- Like NULL

//RESULT
//Tests
//  Tests in group: 5

//  Total Duration: 22 ms

//Outcomes
//   5 Passed
//------------------------------------------------------------------//
//UC-3
//Inform user if entered Invalid Mood
//- In case of NULL or Empty Mood throw Custom Exception MoodAnalysisException
//- Use Enum to differentiate the Mood Analysis Errors

//Results
//Tests
//  Tests in group: 7

//  Total Duration: 11 ms

//Outcomes
//   7 Passed
//------------------------------------------------------------------//