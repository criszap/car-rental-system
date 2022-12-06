# 
# CRUD on CAR_LIST
#

## CREATE (insert based on user-entered fields)
    INSERT INTO CAR_LIST(MAKE, MODEL, YEAR, COLOR, DAILY_PRICE, AVAILABLE) 
    VALUES(@MAKE, @MODEL, @YEAR, @COLOR, @DAILY_PRICE, @AVAILABLE);
## READ
    SELECT * FROM CAR_LIST
## UPDATE (based on selected row fields)
    UPDATE CAR_LIST SET
        MAKE = makeField.Text,
        MODEL = modelField.Text,
        YEAR = yearField.Text,
        COLOR = colorField.Text,
        DAILY_PRICE = dailyPriceField.Text,
        AVAILABLE = avail_field
    WHERE CAR_ID = car_list.CurrentRow.Cells[0].FormattedValue.ToString();  
## DELETE (based on ID of selected row)
    DELETE FROM CAR_LIST 
    WHERE CAR_ID = car_list.CurrentRow.Cells[0].FormattedValue.ToString();
   
#   
# CRUD on CUSTOMERS
#

## CREATE (insert based on user-entered fields)
    INSERT INTO CUSTOMERS(FIRST_NAME, LAST_NAME, EMAIL) 
    VALUES(@FIRST_NAME, @LAST_NAME, @EMAIL);
## READ
    SELECT * FROM CUSTOMERS
## UPDATE (based on selected row fields)
    UPDATE CUSTOMERS SET
        FIRST_NAME = customerFNField.Text,
        LAST_NAME = customerLNField.Text,
        EMAIL = customerEmailField.Text
    WHERE CUST_ID = customersTable.CurrentRow.Cells[0].FormattedValue.ToString();
## DELETE (based on ID of selected row)
    DELETE FROM CUSTOMERS
    WHERE CUST_ID = customersTable.CurrentRow.Cells[0].FormattedValue.ToString();
    
#    
# CRUD on RENTED_CARS
#

## CREATE (insert based on user-entered fields)
    INSERT INTO RENTED_CARS(CAR_ID, CUST_ID, CITY, STATE)
    VALUES(@CAR_ID, @CUST_ID, @CITY, @STATE);
## READ
    SELECT * RENTED_CARS
## UPDATE (based on selected row fields)
    UPDATE RENTED_CARS SET
        CAR_ID = rcCARIDField.Text,
        CUST_ID = rcCUSTIDField.Text,
        CITY = rcCITYField.Text,
        STATE = rcSTATEField.Text
    WHERE ORDER_ID = rentedCarsTable.CurrentRow.Cells[0].FormattedValue.ToString();
## DELETE (based on ID of selected row)
    DELETE FROM RENTED_CARS
    WHERE ORDER_ID = rentedCarsTable.CurrentRow.Cells[0].FormattedValue.ToString(); 
    
#    
# CRUD on RENTAL_INFO
#

## CREATE (insert based on user-entered fields)
    INSERT INTO RENTAL_INFO(ORDER_ID, RENT_START, RENT_END, TOTAL_PRICE, TURNED_IN)
    VALUES(@ORDER_ID, @RENT_START, @RENT_END, @TOTAL_PRICE, @TURNED_IN);
## READ
    SELECT * RENTAL_INFO
## UPDATE (based on selected row fields & total price calc'd)
    UPDATE RENTAL_INFO SET
        ORDER_ID = rentalOrderIdField.Text,
        RENT_START = rentStartField.Text,
        RENT_END = rentEndField.Text,
        TOTAL_PRICE = getTotalPrice(rentalOrderIdField.Text, rentStartField.Text, rentEndField.Text),
        TURNED_IN = avail_field
    WHERE ORDER_ID = rentalInfoTable.CurrentRow.Cells[0].FormattedValue.ToString();
## DELETE (based on ID of selected row)
    DELETE FROM RENTAL_INFO 
        WHERE ORDER_ID = rentalInfoTable.CurrentRow.Cells[0].FormattedValue.ToString();
