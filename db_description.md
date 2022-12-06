### Description
###### This database is a system created for a rental car service business. Using this system, an employee can contain a list of 
###### cars that the rental business owns, keep a list of customers that they have rented cars out to, determine where a car is currently 
###### located, and rental information containing reciepts of each order as well as the total cost of each rental.

### Table 1
    Table1 (car list):
    CAR_ID, 
    MAKE, 
    MODEL, 
    YEAR, 
    COLOR,
    DAILY_PRICE

    FD's: CAR_ID -> MAKE, CAR_ID -> MODEL, CAR_ID -> YEAR, CAR_ID -> COLOR, CAR_ID -> DAILY_PRICE, CAR_ID -> AVAILABLE

    CREATE TABLE CAR_LIST(
      CAR_ID INT PRIMARY_KEY, 
      MAKE TEXT, 
      MODEL TEXT, 
      YEAR INT, 
      COLOR TEXT, 
      DAILY_PRICE INT,
      AVAILABLE TEXT
    );

### Table 2
    Table2 (customers):
    CUST_ID, 
    FIRST_NAME, 
    LAST_NAME, 
    EMAIL

    FD's: CUST_ID -> FIRST_NAME, CUST_ID -> LAST_NAME, CUST_ID -> EMAIL
    
    CREATE TABLE CUSTOMERS(
      CAR_ID INT PRIMARY_KEY, 
      MAKE TEXT, 
      MODEL TEXT, 
      YEAR INT, 
      COLOR TEXT, 
      DAILY_PRICE INT,
      AVAILABLE TEXT
    );

### Table 3
    Table3 (rented_cars):
    ORDER_ID, 
    CAR_ID,
    CUST_ID, 
    CITY, 
    STATE

    FDs: ORDER_ID -> CAR_ID, ORDER_ID -> CUST_ID, ORDER_ID -> (CITY, STATE)

    CREATE TABLE RENTED_CARS (
      ORDER_ID INT PRIMARY KEY,
      CAR_ID INT,
      CUST_ID INT,
      CITY TEXT,
      STATE TEXT,
      FOREIGN KEY (CAR_ID) REFERENCES CAR_LIST(CAR_ID),
      FOREIGN KEY (CUST_ID) REFERENCES CUSTOMERS(CUST_ID),
    );

### Table 4
    Table4 (rental_info):
    ORDER_ID, 
    RENT_START, 
    RENT_END, 
    TOTAL_PRICE

    FD's: ORDER_ID -> (RENT_START, RENT_END), ORDER_ID -> TOTAL_PRICE

    CREATE TABLE RENTAL_INFO (
      ORDER_ID INT PRIMARY KEY, 
      RENT_START TEXT,
      RENT_END TEXT,
      TOTAL_PRICE INT,
      TURNED_IN TEXT
    );
