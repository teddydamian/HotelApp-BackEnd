# ASYNC-Inn

### Author: Teddy Damian and Carrington Beard
##### April 1st 2020
## Description
This is an API server for a Hotel Asset Management system.
We created our ERD Diagram that contains:
1. (1) Joint Entity Table with Payload
2. (1) Pure Join Table
3. (1) Enum

The location table has distinct columns for City, State, Address, Phone Number, and Number of rooms. Every Location can have many Hotels, but every hotel can only have one location. So this is represented with a 1-many relationship.

The hotel table inherits the foreign key of Location Name from the location table and uses its own Hotel Name as a primary key. Each Hotel can have many rooms, and many different amenity packages, and each room type and amenity package can be included with many hotels, as represented by the many-many relationships.

Each room has its own nickname, but inherits its location as a foreign key. Every hotel can have many rooms, and every room type can be in many hotels, as is represented by the many-many relationships. There are also many amenities that are available to each room, but every room can only have one amenity package.

![ERD Diagram](https://github.com/teddydamian/ASYNC-Inn/blob/master/assets/ERD%20Diagram.png)
![Database](https://github.com/teddydamian/ASYNC-Inn/blob/master/assets/SQLDB.png)
#### Directions for Mac User:
- Download Docker
- Download SQL Server on Mac
- run this command for container:
`docker run -d --name sql_server_demo -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=reallyStrongPwd123' -p 1433:1433 microsoft/mssql-server-linux`
- Strong password required
- Double check username

# Next Step
Using ERD Diagram, convert each entity into a model within your newly created MVC web application.
#### Direction
- For each Entity that you have in your ERD, create a new class in your Models folder.
- Inside your DbContext, create a new table/DbSet<T> for each of your created entity classes
- Add your composite key associations to your overridden OnModelCreating method.
- Run the command add-migration {nameOfMigration}
- Run the command Update-database and confirm your database now has the appropriate tables.

![Table in Db](https://github.com/teddydamian/ASYNC-Inn/blob/master/assets/Table.png)

# Next Step
- Create Interface.
- Setup Service.
- Fix Controllers.
- Make API calls 
![API](https://github.com/teddydamian/ASYNC-Inn/blob/master/assets/Rooms.png)

# DTOs

![API](https://github.com/teddydamian/ASYNC-Inn/blob/master/assets/DTOS.png)
### Change Log
1.0 Created MVC, Database. April 1st 2020
1.1 Created Database Tables with Columns and Keys. April 2nd 2020
1.2 Created CRUD Operations and Seeded Database using Database injection. April 7th 2020
