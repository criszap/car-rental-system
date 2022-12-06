### Insert statements that run when the database is first created
### Insert statement for car list table
INSERT INTO CAR_LIST(MAKE, MODEL, YEAR, COLOR, DAILY_PRICE, AVAILABLE)
  VALUES ('Ford', 'Mustang', 2014, 'Red', 69, 'Y'),
         ('Nissan', 'R34 Skyline GT-R', 1998, 'Black', 212, 'N'),
         ('Honda', 'Civic Type-R', 1994, 'White', 80, 'N'),
         ('Mitsubishi', 'Lancer Evo X', 2008, 'Red', 105, 'N'),
         ('RL', 'Octane', 2015, 'White', 315, 'N'),
         ('RL', 'Dominus GT', 2016, 'Purple', 280, 'Y');
         

### Insert statement for customers table
INSERT INTO CUSTOMERS(FIRST_NAME, LAST_NAME, EMAIL)
  VALUES ('Cristian', 'Zapata', 'czapata@gmail.com'),
         ('Alejandro', 'Romero-Lopez', 'aromero@gmail.com'),
         ('Jesus', 'Jimenez', 'jjimenez@gmail.com'),
         ('Kwabena','Adjei','kadjei@gmail.com'),
         ('Nico', 'Zamora', 'nzamora@gmail.com'),
         ('Martin', 'Castillo', 'mcastillo@gmail.com');
         

### Insert statement for rented cars table
INSERT INTO RENTED_CARS(CAR_ID, CUST_ID, CITY, STATE)
  VALUES (5, 1, 'Sunnyvale', 'California'),
         (2, 2, 'Seattle', 'Washington'),
         (6, 3, 'Wichita', 'Kansas'),
         (3, 4, 'Richmond', 'Virginia'),
         (3, 5, 'New York', 'New York'),
         (4, 6, 'Zacatecas', 'Mexico');
         
### insert statement for rental info table
### The getTotalPrice function is a C# function that calculates the difference between 2 dates and then multiplies that difference by the price of a car
INSERT INTO RENTAL_INFO(ORDER_ID, RENT_START, RENT_END, TOTAL_PRICE, TURNED_IN)
  VALUES (1, '05/30/2023', '08/15/2023'," + getTotalPrice("1", "05/30/2023", "08/15/2023") + ", 'N'),
         (2, '05/30/2023', '08/15/2023'," + getTotalPrice("2", "05/30/2023", "08/15/2023") + ", 'N'),
         (3, '12/01/2022', '12/04/2022'," + getTotalPrice("3", "12/01/2022", "12/04/2022") + ", 'N'),
         (4, '03/05/2023', '03/11/2023'," + getTotalPrice("4", "03/05/2023", "03/11/2023") + ", 'Y'),
         (5, '06/01/2023', '08/05/2023'," + getTotalPrice("5", "06/01/2023", "08/05/2023") + ", 'N'),
         (6, '12/01/2022', '01/12/2023'," + getTotalPrice("6", "12/01/2022", "01/12/2023") + ", 'N');
         
         
         

### Insert statements for inserting new data
INSERT INTO CAR_LIST(MAKE, MODEL, YEAR, COLOR, DAILY_PRICE, AVAILABLE)
VALUES(@MAKE, @MODEL, @YEAR, @COLOR, @DAILY_PRICE, @AVAILABLE);

INSERT INTO CUSTOMERS(FIRST_NAME, LAST_NAME, EMAIL)
VALUES(@FIRST_NAME, @LAST_NAME, @EMAIL);

INSERT INTO RENTED_CARS(CAR_ID, CUST_ID, CITY, STATE)
VALUES(@CAR_ID, @CUST_ID, @CITY, @STATE);

INSERT INTO RENTAL_INFO(ORDER_ID, RENT_START, RENT_END, TOTAL_PRICE, TURNED_IN)
VALUES(@ORDER_ID, @RENT_START, @RENT_END, @TOTAL_PRICE, @TURNED_IN);

