Questions

1). A program is required for a computer game. The user keys in the number of rounds he wishes toplay.For each round the user enters his lucky number. The program takes the number and divides it withasecret number. If the remainder of the division is zero, it is considered a draw for the round and the totalscore is incriminated by 1. Otherwise if it is any other even number, it is considered a win for the round and the total score is incremented by 3. However if it is an odd number, it is considered a loss for the round and the total score is decremented by 3. This is done until he completes his rounds. He wins if the total score at the end is a positive number. Write a C# program to accomplish this.

2). Using nested loops, write a C# application program that produces the following output. & & & & & &
                            * & * * * *
                            * * & * * *
                            * * * & * *
                            * * * * & *
                            & & & & & &

3). Write C# application program to be used to evaluate the credit worthy of a client. The programreadsthecredit limit and the price and quantity of the item to be purchased by the client. If the value of thegoodsis more than the credit limit, the program displays “Sorry you cannot purchase goods worthysuchavalueon credit” and allows the customer to re-enter the quantity, otherwise, displays “Thank Youfor
purchasing from us” and the value of the purchase. This should be repeated for n customers.

 4). Write a complete C# application program to calculate the area of a triangle, rectangle or circle. Theprogram should have a decision making statement(s) to decide:  If the figure is a triangle then ask for base and height values to input.  If the figure is a rectangle the ask for length and breath values to input  If the figure is a circle then ask for the radius values to input
The program should display the output on the screen and should enable the user to re-enter choiceforatmost three times incase a wrong selection is entered

5). A company distributes 5 different items around Nairobi through its 10 salesmen. Using arrays writeaC#application program to input a salesman name and the corresponding sales made by each of thesalesmanfor each of the item. The program should then output each of the salesman’s name, sales, total salesaswell as grand total using the format shown below. Name Item1 Item2 Item3 Item3 Item4 Item5 TotalSales ___________________________________________________ Brian 20 50 25 10 0 15 120
Joan 45 55 10 25 5 30 170 …. …. GrandTotal xx





📌 Project Contribution Guide
🔹 1. Clone the repository

Each team member must first copy the project to their machine:

git clone https://github.com/your-username/your-repo.git
cd your-repo
🔹 2. Pull latest changes (VERY IMPORTANT)

Before doing anything:

git pull

 This prevents conflicts

 3. Create your own branch (MANDATORY)

 DO NOT work on main/master

Each member must create their own branch:

git checkout -b question1-solution

(Change name depending on your task)

 4. Work on your assigned question

Each member works on a separate file inside src/

Example:

src/question1.py
src/question2.py

👉 DO NOT edit someone else’s file

 5. Save your work (commit)
git add .
git commit -m "Solved question 1"

👉 Use meaningful commit messages

🔹 6. Push your branch
git push origin question1-solution