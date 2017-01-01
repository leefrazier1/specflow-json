# Generating Gherkin JSON from your SpecFlow test suite [![Build status](https://ci.appveyor.com/api/projects/status/yk664hx48ei6l5s2?svg=true)](https://ci.appveyor.com/project/williamsia/specresults) [![NuGet version](https://badge.fury.io/nu/SpecNuts.svg)](https://badge.fury.io/nu/SpecNuts)


[SpecNuts](https://www.nuget.org/packages/SpecNuts) was created to get Gherkin JSON from your automated [SpecFlow](http://www.specflow.org/) testsuite. With unit tests most times reporting is only interesting for developers and testers. But when practicing BDD, the output of your automated tests might be valuable for the whole development team, management and perhaps even end-users. You can use tool such as [Donut](https://github.com/MagenTys/donut) to generate a better looking report from your JSON file.

## Table of contents
  -  [Usage](#usage)

## Usage

Make your existing [StepDefinitions class](https://github.com/techtalk/SpecFlow/wiki/Step-Definitions) inherit from [SpecResults.ReportingStepDefinitions](https://github.com/specflowreporting/SpecResults/blob/master/SpecResults/ReportingStepDefinitions.cs)

Initialize and add the reporter(s) in [BeforeTestRun] and register on one of the [events](https://github.com/specflowreporting/SpecResults/blob/master/SpecResults/Reporters.Events.cs) to get notified when something gets reported:

<pre>
[Binding]
public class StepDefinitions : ReportingStepDefinitions
{
	[BeforeTestRun]
	public static void BeforeTestRun()
	{
		Reporters.Add(new JsonReporter());
		
		Reporters.FinishedReport += (sender, args) => {
			Console.WriteLine(args.Reporter.WriteToString());
		};
	}
}	
</pre>
