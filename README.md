<img align="left" width="116" height="116" src="net-logo.svg" />

# &nbsp;**Welcome to the .NET Incubator**

<br/><br/>

### **Learning Overview?**

- [ ] What is .NET?
- [ ] Where can I ask for help?
- [ ] Solving the most common problems found to solve
  - [ ] CRUD System
  - [ ] Handling Background Jobs
  - [ ] Creating an API
    - [ ] RESTful
  - [ ] Bulding a Front-End to consume your API - **your choice*
    - [ ] Blazor or
    - [ ] React or
    - [ ] Angular

## **Resources**
- [Entelect Stream](https://web.microsoftstream.com/channel/fe5bc582-9acb-4952-9b71-b29aab0bc9e9)

## **Prerequirements**

- [ ] .NET Fundamentals - [Read more...](https://github.com/entelect-incubator/.Net/tree/master/Fundamentals)
- [ ] .NET Overview - [Read more...](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/?view=aspnetcore-3.1&tabs=windows)

For this Incubator we will be using [.NET Core 3.1](https://dotnet.microsoft.com/download) - Scan through the basic concepts.

    1. The Startup class
    2. Dependency injection (services)
    3. Middleware
    4. Servers
    5. Configuration
    6. Options
    7. Environments (dev, stage, prod)
    8. Logging
    9. Routing
    10. Handle errors
    11. Make HTTP requests
    12. Static files

- [ ] Principles, Frameworks and Architectures

In this Incubator, we will build a solution based on the Single Responsibility Principle. To help us achieve this we will be making use of the CQRS pattern alongside a Clean Code Architecture. If you have never heard about these terms, don't worry we will be discussing them in detail.

## **Setup**

- [ ] Setup your environment - [How to video](https://www.youtube.com/watch?v=G1-Zfr9-3zs&list=PLLWMQd6PeGY2GVsQZ-u3DPXqwwKW8MkiP)
  - [ ] [Visual Studio 2019 Community](https://visualstudio.microsoft.com/downloads/) Installed
  - [ ] [.NET Core 3.1](https://dotnet.microsoft.com/download) Installed
  - [ ] [SQL Server Developer](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) Installed
  - [ ] [SQL Server Management Studio SSMS](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15) Installed
- [ ] SQL Incubator - [SQL basics for Beginners](https://www.youtube.com/watch?v=9Pzj7Aj25lw)

# **Pezza Digital Solutions**

In this section, we will start building projects to allow Pezza to manage their stock and a front-end website where customers can order their favourite pizza online.

## **Intro**

Restaurant staff should be able to manage the stock through a web application as well as manage their different restaurants. Customers should be able to order a pizza online, this order should be visible to the selected restaurant. The customer should also be notified that their pizza is on its way. We will start solving these business requirements by doing the following:

- Create a CRUD System in .Net MVC Project to manage stock and restaurants. Allow restaurants to place a request stock from head-office.

- Expose your Stock Management through an API using .Net Web API that will be used by the front-end application.
- Allow for customer notifications to be sent out.
- Create a Customer Facing Website in your choice of Front-End Library.
  
![Phase 1 High Level Design](./Assets/phase1-hld.svg)

## **Learning Outcomes**

### **Phase 1** Getting started

Let's start off with how to make a basic project and refactor it into a solution following the Single Responsibility principle (SOLID principles) and how to set up a basic clean code architecture. You will be using this setup format throughout the rest of the incubator.

Overview
- [ ] [TDDD and Unit Testing](https://web.microsoftstream.com/video/ffd65354-c7b0-49c2-a9f7-2d90a7fbb565?channelId=fe5bc582-9acb-4952-9b71-b29aab0bc9e9)
- [ ] [Data Access](https://web.microsoftstream.com/video/198f0339-10e0-4b09-9bb0-b9c3f092c9c4?channelId=fe5bc582-9acb-4952-9b71-b29aab0bc9e9)

[Click here to get started](https://github.com/entelect-incubator/.NET/tree/master/Phase%201)

### **Phase 2** Scaffolding

Here we will extend the foundation from Phase 1 to all Entities CRUD operations, as well as make use of the CQRS Pattern and Mediatr NuGet Package.

Overview
- [ ] [Working with Data in C#](https://web.microsoftstream.com/channel/fe5bc582-9acb-4952-9b71-b29aab0bc9e9)


[Click here to get started](https://github.com/entelect-incubator/.NET/tree/master/Phase%202)

### **Phase 3 - Handling Data**

Now that we have deployed phase 2, let's make a few enhancements. It will be easier for the customer and admin to search and filter through the data, so let's add that in.

Overview
- [ ] [Concurrency](https://web.microsoftstream.com/video/56e7e456-69e6-4f2b-8eec-ddb118c3aa5f?channelId=fe5bc582-9acb-4952-9b71-b29aab0bc9e9)

Improve how data is displayed and validated

- [ ] Fluent Validation
- [ ] Filtering
- [ ] Searching
- [ ] Pagination

### **Phase 4 - Standards and Error Handling**

Good error handling will save you a lot of headaches later as well as time. The same goes for coding standards. When working as part of a team, it is good practice to adhere to coding standards so that the team can switch between each other's code seamlessly. Let's have a look at how we can enforce some of the most basic standards and add error handling.
  
Overview
- [ ] [Error Handling](https://web.microsoftstream.com/video/5fcd4c8a-4e7b-41ac-9836-d1366da97c82?channelId=fe5bc582-9acb-4952-9b71-b29aab0bc9e9)

- [ ] Coding Standards
  
### **Phase 5** - Improving Performance

Next is performance. Who wants to use a good system if it's slow, right? Data that won't change often can be cached to increase speed and compression reduces the payload. Do it right and even IE can run it fast... well maybe. These are relatively small changes that make a big difference, so let's get started.

Overview
- [ ] [Performance and Memory Management](https://web.microsoftstream.com/video/64098be8-6979-4c10-85f4-efa91d0cb1f1?channelId=fe5bc582-9acb-4952-9b71-b29aab0bc9e9)

Increasing Performance

- [ ] Caching
- [ ] Compression

### **Phase 6** - Events

The customer has to be notified as soon as his order has been completed and ready for collection. We will use emails for notifications and trigger it using Domain Events.

Increasing Performance

- [ ] Domain Events
- [ ] Simple Email Notification

### **Phase 7**

Now that we have increased the performance and can notify the customers of orders, we need to secure the website.

Overview
- [ ] [Security](https://web.microsoftstream.com/video/2a2b5226-34cb-49ac-b8fe-880cb9ac893c?channelId=fe5bc582-9acb-4952-9b71-b29aab0bc9e9)

Add Security
- [ ] API Oauth / JWT Token
- [ ] MVC Antiforgy Tokens

### **Phase 8** UI

Overview
- [ ] [MVC Part 1](https://web.microsoftstream.com/video/61e64cfa-c3ba-45c3-9811-e5bc25968a2a?channelId=fe5bc582-9acb-4952-9b71-b29aab0bc9e9)
- [ ] [MVC Part 2](https://web.microsoftstream.com/video/315b2034-0aa5-43ee-b030-562f4a597cfd?channelId=fe5bc582-9acb-4952-9b71-b29aab0bc9e9)

Now we can start building a basic pizza website for customers and a basic back-end for the admin. To help us with this, we will make use of the Pezza Branding Guide & Design System.

[Documentation](https://web.microsoftstream.com/video/315b2034-0aa5-43ee-b030-562f4a597cfd?channelId=fe5bc582-9acb-4952-9b71-b29aab0bc9e9)

**Pezza Website**

- 
- AngularJS - Coming Soon
- ReactJS - Coming Soon

**Pezza Admin Back-End**

- MVC - [Click here to get started](https://web.microsoftstream.com/video/315b2034-0aa5-43ee-b030-562f4a597cfd?channelId=fe5bc582-9acb-4952-9b71-b29aab0bc9e9)
- AngularJS - Coming Soon
- ReactJS - Coming Soon
 
[Click here to get started]()
  
### **Phase 9** - Coming soon

Now that the basics are done, how about giving customers the ability to track their orders? To do this in real-time, we will use SignalR.
- [ ] SignalR
