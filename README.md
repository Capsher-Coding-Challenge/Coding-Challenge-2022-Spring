# Capsher Technology Spring 2022 ACC Coding Challenge

Welcome to Capsher Technology's Spring 2022 ACC Coding Challenge!

Our challenge to you is to create a 3rd party integration manager. That's it! You get to decide what this integration will do and how you want to develop it. All that we ask is that you create something novel and useful.

### Categories
1. 1,2,3- Best overall (Useful, creative, documented, functioning)
1. S- Creative solution
1. S- Best designed and documented

### Prizes
1. 1st Place: Airpods + $100 Amazon Gift Card OR Network Power Adapter + $100 Amazon Gift Card OR $250 Amazon Giftcard
1. 2nd Place: The Art of Computer Programming Vol 1 OR $100 Amazon Gift Card
1. 3rd Place: Ergonomic Keyboard or $50 Amazon Gift Card
1. Specialty categories: Same as 3rd Place

### Contents:
1. Getting Started
2. Requirements For Submission
3. Sample Bot
4. Helpful Links

## Getting Started
There are a couple of things you need to do before writing your first line of code for this challenge.
1. [Register](https://docs.google.com/forms/d/e/1FAIpQLSd4rGZYdQqsgcQ8ZjnPXwvrokRvh38P0W1kbPSUfZsxM4-miw/viewform) for our challenge here
    1. You can sign-up in teams of up to 4 people
1. Sign-up for a GitHub account
    1. As part of your submission you'll need to [submit](https://docs.google.com/forms/d/e/1FAIpQLSfr2Oi_QSrYYH5t62tZEK4B6ObFCIW_Y3nKmPuW-IVqaguGkA/viewform) a link to your GitHub Repository so we can check out your source code
    1. Even if you won't be hosting the project repository, you'll probably want collaboration access for the repo
    1. You'll also need to download git (the program) so that you can use GitHub
    1. Any updates will be posted to this README on GitHub. Add a watch on this repo for updates

## Requirements For Submission
1. User Documentation
    1. Describe how your integration solves a problem (i.e. Problem Statement)
    1. Describe how a user would utilize your integration (i.e. Product Overview & User Commands)
1. Technical Documentation
    1. Provide an architectural overview of how your app works
        1. Detail major system components and how they communicate with each other
    1. Detail any integrated technologies and how your app uses them
        1. Libraries
        1. APIs
        1. Hosting services
1. GitHub Repository Link
    1. Submissions should include a GitHub repository link so we can reference your source code and documentation
1. It's highly recommended to host your integration on a server to get user feedback and ease testing/judging. This also provides good practice with CI/CD pipelines

## Scaffolding
We've included a scaffolded ASP.Net API as a starting point to shorten ramp-up time. It's incomplete and not thoroughly tested; it's purpose is to provide initial direction and good patterns to use to save early development time.

If you prefer a different language, the [Capsher Coding Challenge](https://github.com/Capsher-Coding-Challenge) GitHub account has previous scaffolded examples from historical contests.

### Dependencies
1. Your favorite editor and C# compiler
    1. Ex: [VSCode](https://code.visualstudio.com/) with [C# extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)
1. The [ASP.NET Core 3.1 Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-aspnetcore-3.1.22-windows-hosting-bundle-installer)

### Setup
1. Run `dotnet restore` to install the relevant packages
1. Run `dotnet run` or use the IDE's launch tasks to run

### Pieces to consider adding
1. Authentication - Currently, there is none
1. A web interface for a nicer user experience
1. Persisted storage of state


## Helpful Links

### Tutorials and Articles
* Git
  * [Intro](https://guides.github.com/activities/hello-world/#repository)
  * [Fix my Git](https://sethrobertson.github.io/GitFixUm/fixup.html)
* [ASP.Net](https://docs.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-3.1)

* Deployment
  * [AWS EC2](https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EC2_GetStarted.html)
  * [Azure App Service](https://docs.microsoft.com/en-us/azure/app-service/overview)
  * [Heroku with Docker](https://dev.to/alrobilliard/deploying-net-core-to-heroku-1lfe)
