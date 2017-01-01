> __Attention:__ this project was formerly known as SpecFlow.Reporting. This is
> not an offical SpecFlow package and the name clashed with some of the
> official SpecFlow packages/namespace. Therefor it was renamed to
> SpecResults.
>
> All previous published versions of SpecFlow.Reporting are still available on
> NuGet.org, alltough they aren't listed anymore.

# Generating better SpecFlow reports [![Build status](https://ci.appveyor.com/api/projects/status/yk664hx48ei6l5s2?svg=true)](https://ci.appveyor.com/project/williamsia/specresults) [![NuGet version](https://badge.fury.io/nu/SpecNuts.svg)](https://badge.fury.io/nu/SpecNuts)


[SpecResults](https://www.nuget.org/packages/SpecResults) was created to get better feedback from your automated [SpecFlow](http://www.specflow.org/) testsuite. With unit tests most times reporting is only interesting for developers and testers. But when practicing BDD, the output of your automated tests might be valuable for the whole development team, management and pherhaps even end-users.

SpecResults makes it easy to extend SpecFlow by creating reporters which can write output in all kinds of formats and can even be enriched with additional data.

## Table of contents
  -  [Usage](#usage)
  -  [Create your own reporter](#create-your-own-reporter)
  -  [Wanted reporters](#wanted-reporters)

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

## Create your own reporter

Create a new project and add the [SpecResults package](https://www.nuget.org/packages/SpecResults)

Add a class which inherits from [SpecResults.Reporter](https://github.com/specflowreporting/SpecResults/blob/master/SpecResults/Reporter.cs) and implement the WriteToStream method:

<pre>
namespace SpecResults.MyFormat
{
	public class MyFormatReporter : SpecResults.Reporter
	{
		public override void WriteToStream(Stream stream)
		{
			//
			// TODO: Serialize this.Report to the stream
			//
		}
	}
}
</pre>

