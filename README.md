# Simplified Software Complexity
## Description
### Proposed solution to simplifying software complexities that arise from extensive software capability. This project is inspired by the work that I do in IT, which encapsulates a lot of my unique experiences in IT. I really hope you enjoy this readme.md and my code. Please leave comments and feedback to me via LinkedIn as seen on my GitHub profile.
---
## Project namespace or folder definitions
* Fundamentals - The core of this project, an attempt to define complexity more simply. This would be shared across the software solution.
* Features - Notes features of a solution to easily see what the software is doing. In this project there are two features IFundamentals and ILog.
* Displays  - Notes things that display information, for example closest to where a user, API, or client application may see it. Furthest away from Archives, where you may get information from a database for example. Archives are explained later.
* Classes - A class can be an interface that is implemented. A folder you can stick feature logic that is neat. For example, we would not want to put Fundamentals feature inside this space, but it is fine to put the Log feature.
* Interfaces - An interface can define what a class should do and can be used to describe a class. This folder at the highest level can be used to support the Classes namespace or folder, where inside the Classes folder, you implement your interfaces.
* Globals - Where you can put things that you know certainly, they will be used by all logic in a software construct. Fundamentals is also considered a type of global. Global means shareable across everywhere.
* Services - This can be optional depending on the type of software you are using. An IService (the interface form) would be something that is shared that handles an underlying HTTP connection as one example, and ensures resources are accessed responsibly by, as one example a solution's dependency injection. I plan to add more of these structures as time goes on, such as IManagers.
---
## Definitions of Fundamentals
* IFundamental - Fundamental classification for separation of software concerns.
* IFramework - This is where the bulk of the definitions for Fundamentals are defined and how this framework is defined. We will focus on IFrameworks to show relationships.
* IDo - Where a more basic action is performed, such as a computer read, write, relate (to identify from one place to another across variables or objects), IAction (to descriptively define what action is being done on the data, like CRUD), etc.
* IGeneral - Definitions of typical things we may expect to be in common with every software solution, such as descriptions of an application, a type of change record for changes made, and session information.
* ITime - All computers time, right? More specifically, the quartz crystal, or similar, that resonates in a computer's CPU clock at a certain speed to define the electrical executions and state of the machine, to a scientifically predictable practical manner. We could consider time a fundamental type. We could, likely should, know when something executes. General and adaptable indicator that an interface measures time. It defines things such as IDurationArchive, IDurationRecord, ITimestampArchive, and ITimeLogic.
---
## Definitions of IFramework
* IFramework - How software logic will be defined within the code.
* IArchive - Intended to only be concerned with storing data in basic parameters. Interfaces with IRecords.
* IRecord - Intended to read and write with IArchives. These can be used for simpler implementations of software and can substitue as IDisplays or ViewModels. Interfaces with IArchives and ILogics.
* ILogic - Intended for complex logic, possibly involving multiple records, for reading and writing data. Interfaces with IDisplays (optionally, see IDisplay) and ILogicRecords (inherits from IRecord).
* ILogicRecord - Intended usually to house multiple IRecords. Couples with an ILogic.
* IDisplay - Intended only for complex logic related to displaying information. Interfaces with ILogics. These can also be known as ViewModels. An ILogic does not need to have an IDisplay, as it could just be used as backend code and not for display purposes.
* IService - To indicate something is a service where it may centrally handle either network or data type connections.
---
## Definitions of IDo
* IDo - Describes that something does something.
* IAction - Actions intended to label data to associate for backend jobs, like Azure Functions, such as for databases. Can be used to defer work for later.
* IRead - Intended for the retrieval of data usually.
* IWrite - Intended logic to save data in some manner.
* IReadWrite - Intended to have logic intended for writing and reading.
* IRelate - Intended to identify from one place to another across variables or objects. Such as to map two IArchives together, like how relational databases are designed.
---
## Interfaces with map (enhances definitions when viewed at a glance)
*Subjects are named followed by the symbol "-". Interfaces with equals the symbol ">". Subsequent symbols ">" shows the typical hierarchy. Subjects are named followed by the symbol "-". Subjects can be in the middle to note hierarchy. Symbol "=" notes that a subject inherits from all interfaces collectively.*  
### IFramework
* IArchive - IArchive.
* IArchive = IRead, ITime, IRelate, IFramework.
* IRecord - IArchive > IRecord.
* IRecord = IReadWrite.
* ILogicRecord - IArchive > IRecord > ILogicRecord.
* ILogic - IArchive > IRecord > ILogicRecord > ILogic.
* IDisplay - IArchive > IRecord > ILogicRecord > ILogic > IDisplay.
### ILog (Example of a Fundamental feature implemented)
* ILogArchive = ISessionsArchive, IDurationArchive, IArchive, ILog.
* ILogRecord = ILogArchive, IRecord.
* ILogLogicRecord = ILogRecord, ISessionRecord, IDurationRecord, ILogicRecord.
* ILogLogic = ILogLogicRecord, ILogic. 
  * Note: It is the LogLogic's responsibility to retrieve LogLogicRecords, write to logging system, display Record properties and possibly translate them externally to an IDisplay, and to implement basic textual informational as exception alerting and possibly handling.
* ILogicDisplay = ILogLogic, IDisplay.
---
## Naming schemas and organization
* Typically, for each interface, class, and the like, it will be structured as FeatureNameFundamentalTypeName.
* If there is a major feature, such as IFundamental, each sub-feature such as IFramework will be clearly labeled on each subsequent sub-categorization.

