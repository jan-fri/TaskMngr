• How long did you spend on your solution?

Time spent on solution ~3h

• How do you build and run your solution?

Run the TaskMngrApp in VS, it should then lunch in the browser. Wait for it to automatically redirect to localhost

It should load a page displaying tasks in table format (initially empty), with an option to add new tasks, clicking on a task changes its status 

• What technical and functional assumptions did you make when implementing your solution? 

As per technical requirements data is not persisted, there is no DB to store the data

• Briefly explain your technical design and why do you think is the best approach to this problem.
1. The project was created using a ASP .Net Core with Agular tamplate - allowed to quickly start working on the project
2. I've used a static variable to store the list of tasks in the task repository, this is only to simulate storing the data in DB and to demonstrate the use of the WebAPI when adding new tasks and also for unit testing purposes

• If you were unable to complete any user stories, outline why and how would you have liked to implement them.

All stories have been completed, 
