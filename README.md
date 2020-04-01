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

![ERD Diagram]
