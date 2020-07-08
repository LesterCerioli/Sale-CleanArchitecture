# Sale-CleanArchitecture




As the SOLID principles and the Clean Architecture rules are worth to write about it, I am starting this blogging series explaining the decisions we have made through the development of the Manga Project. Feedback are welcome! Clean Architecture expects at least 4 layers and in each layer there are common components. Starting with the layers from inside to the outer ones:


<img src="https://paulovich.net/img/CleanArchitecture-Uncle-Bob.jpg">

#1.Enterprise Business Rules
#2.Application Business Rules
#3.Interface Adapters
#4.Frameworks & Drivers



#1. Enterprise Business Rules

Beginning with the Enterprise Business Rules Layer we are talking about Aggregates, Entities, Value Objects and others patterns of a rich Domain. In our specific Bounded Context we have the Customer and the Account as Aggregate Roots, also the Credit/Debit transactions as Entities and last but no least we have the Name, Person Number and Amount as Value Objects.

<img src="https://paulovich.net/img/Account-Balance-Context.png">



In short words, the previous components are the business entities that encapsulates fields and prevents unexpected changes or behaviors, these components maintain the application state in the most reliable way. Now, let me highlight some characteristics of this data structures:

Aggregate Roots controls the entities graph and are used by repositories for data persistence. The software craftsman Vaugn Vernon wrote the rules for designing effective aggregates and I highly recommend watching the video Curing you Domain Model Anemia with Effective & Clean Tips from the Real World from Edson Yanaga these helped me a lot to enrich my model.
You will see that majority of the classes have properties with private sets or protected sets in order to prevent unexpected state changes from the several clients along the Use Cases (we avoid public sets when possible).
We had to make exceptions for constructors due of deserialization requirements.
Value Objects are expected to be immutable and they have the most closed fields. Fields that change only when we create a new instance of the Value Object.



You can find interesting Domain Entities in our GitHub, following there are an Aggregate Root example:


#2. Application Business Rules


Let’s move to the Application Business Rules Layer that contains the Use Cases of our Bounded Context. As said by Uncle Bob in his book Clean Architecture:


So our Use Cases implementations are first-class modules in the root of this layer. The shape of a Use Case is an Interactor object that receives an Input, do some work then pass the Output through the currently Presenter instance as shown in the following figure:


<img src="https://paulovich.net/img/Flow-Of-Control.png">


In the previous Flow of Control we ha

    1-An Action in the CustomersController calls a method in the RegisterInteractor with the RegisterInput data;
    2-The RegisterInteractor that implements **IInputBoundary** calls the **CustomerRepository** passing the **CustomerAggregate** object created in that 
    

    Use Case.
    3- Then the RegisterInteractor generates a RegisterOutput data object (POCO) and passes it to the currently IOutputBoundary.
    4-The RegisterPresenter which implements IOutputBoundary receives the RegisterOutput and creates the RegisterModel.
    5-The RegisterModel created in step 4 are returned by the Action.

    In our example application we have other Use Cases that allow Customer Registration and Bank Account transactions. In simple terms these are the Use Cases:


        *Customer Registration.
        *Get Customer Account Details.
        Get Account Details.
        *Deposit to an account.
        *Withdraw from an account.
        *Close an account.
        Continuing to explore our implementation you will see that the RegisterInteractor receives the services by DI. The Process method does the Application Business Rules, calls the Repository and at the end passes the RegisterOutput through the RegisterPresenter instance. Let’s take a look at the RegisterInteractor class:



        What have you seen until here is Enterprise + Application Business Rules enforced without frameworks dependencies or without database coupling. Every details have abstractions protecting the Business Domain to be coupled to tech stuff



#3. Interface Adapters


Now we advance to the next layer, at the Interface Adapters Layer we translate the User input in a way that the Interactors understands, it is good practice to do not reuse entities in this layer because it creates coupling, the front-end has frameworks, other ways of creating his data structures, different presentation for each field and validation rules. In our implementation we have the following components for every use case:


    *Request: a data structure for the user input.
    A Controller with an Action: this component receives the user input, calls the appropriate Interactor which do some processing then pass the output through the Presenter instance.
    *Presenter: it converters the Output to the Model.
    *Model: this is the return data structure for MVC applications.



And this is how looks a Controller for the Register Use Case. We must highlight that the Controller knows which Interactor to call but it does not care about the Output of it, instead the Controller delegates the responsibility of generating a Model to the Presenter instance.



An Presenter class is detailed bellow and it shows a conversion from the RegisterOutput to two different ViewModels. One ViewModel for null Outputs and another ViewModel for successful registrations.


#4. Frameworks & Drivers


Our more external layer is the Frameworks & Drivers who implements Data Base Access, Dependency Injection Framework (DI), JSON Serializer and technology specific stuff. It has an CustomerRepository implementation. See the GitHub for the MongoContext and other Repositories classes.



We group the DI by Autofac Modules and created rules for selecting the interfaces and implementations by namespace patterns.




Summing up, we separated the Solution in projects so we could draw boundaries between the modules, clarify the dependencies and we have small classes that makes easy to create new features without changing the existing ones. These are the Solution Explorer in Visual Studio 2017:


<img src="https://paulovich.net/img/Manga-Solution-Explorer.png">

And to help you understand the dependencies between the projects this diagram:



<img src="https://paulovich.net/img/Layers.png">


Finally, as we did not cover every detail in source code take a look at.



<img src="https://paulovich.net/img/dotnet-new-caju-0.2.84.gif">
