Use Case Name:
View Population Statistics and Demographics

Description:
This use case allows the user to interact with the Population Reporting System. The user can choose from several options to view information about countries by population, top cities in a continent, or the number of language speakers worldwide.

Actor(s):
Primary Actor: End User (a person interacting with the Population Reporting System)
Secondary Actor(s): Database (provides data to the system)
Preconditions:
The application is running.
The user has access to the system (i.e., no authentication is required).
The database is populated with relevant population, city, and language data.
Postconditions:
The user receives the requested demographic information displayed in a readable format.
If the user chooses to exit, the system closes.
Trigger:
The user opens the Population Reporting System and is presented with the main menu.

Main Flow:
Display Main Menu: The system presents the main menu with the following options:

View Countries by Population
View Top Cities in a Continent
View Language Speaker Statistics
Exit
User Choice: The user enters a choice (1, 2, 3, or 4).

If the user selects "1" (View Countries by Population), proceed to step 3.
If the user selects "2" (View Top Cities in a Continent), proceed to step 5.
If the user selects "3" (View Language Speaker Statistics), proceed to step 7.
If the user selects "4" (Exit), proceed to step 8.
View Countries by Population: The system displays a list of countries sorted by population in descending order.

Alternative Flow: If the database query fails, an error message is displayed, and the user is prompted to try again.
Return to Menu: After displaying the population list, the system prompts the user to return to the main menu.

View Top Cities in a Continent: The system prompts the user to enter a continent name.

User Input: The user enters the continent name (e.g., Asia, Europe).
The system displays the top cities by population in that continent.
Alternative Flow: If the continent is not found, the system displays an error message and asks the user to try again.
Return to Menu: After displaying the top cities, the system prompts the user to return to the main menu.

View Language Speaker Statistics: The system displays the number of speakers of different languages around the world.

Alternative Flow: If there’s an error with the data, an error message is displayed.
Exit the Program: The user selects to exit, and the system closes.

Alternate Flows:
Invalid User Input: If the user enters a choice that is not listed in the main menu (1, 2, 3, or 4), the system displays an error message and prompts the user to enter a valid option.
Exception Flows:
Database Connection Error: If the system cannot connect to the database, it displays an error message indicating the issue (e.g., "Unable to connect to the database. Please try again later.").

Data Retrieval Failure: If the system fails to retrieve data (e.g., population data, cities, or languages), it displays an error message, such as "Failed to retrieve data. Please try again later."

Requirements:
The system should retrieve up-to-date population, city, and language data from a reliable database.
The system should be able to handle invalid user input gracefully.
The system should allow users to select different options easily.
Frequency of Use:
Daily: Users may interact with the Population Reporting System regularly for demographic statistics.
Occasionally: Users may consult language statistics or city/population data for specific regions or continents.
Special Requirements:
The system must be able to handle large amounts of data efficiently (e.g., millions of country population entries).
