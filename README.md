# GilbertoHeroKare-Assesment

Steps to run the project

Run this command in the nugger package manager console to install dependencies -> npm install

Change database connection string inside Web.config file Locate connectionStrings tag

This project is using code first approach to create and fill data. Run update-database in the package console

Project structure and desicions

I'm using model, view and controller to separate logic, data and UI components.

Models: I decided to create two models. Hero and Rating. These models are inside the Models folder Hero has it's own properties and a list of ratings. Rating has it's own properties and a key to reference the Hero

Services / Repositories: (HeroService / HeroRepository)

Repository calls database Service calls repository Service is injected in the controller

Repository layer is implemented to access the database. Whereas a service layer consists business logic. I'ts better to have a separate repository layer and service layer. Having separate repository and service layers make the code more modular and decouple the database from business logic and easies to make unit testing as well.

I decided to user Ninject as dependency injection framework in order to te able to inject interfaces inside the controllers, so we don't have to worry about creating the service within the controller.

Median calculator helper C# is not able to calculate median, so I added a custom helper to calculate it located in the Helpers folder

ContextInitializer it's the file located DbContextConfig folder. This file will heelp us call the create database method with our custom seed method to fill data to the database.

View folder contains the razor files

Hero.cshtml contains the razor to render the list of heroes.
