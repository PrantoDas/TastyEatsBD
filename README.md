
## Tools & Technologies Used
1. .Net 8
2. Blazor Server
3. EF Core 8
4. MSSQL Server
5. ASP.NET Identity Framework with Blazor Identity Framework UI
6. Blazor Fluent UI

## **Requirements and Features**

Defining the requirements and features is a crucial first step in designing a system. Let's break this down for each of our primary users: Customers, Restaurants, and Delivery Personnel.


### **Customer Features:**

- [ ] 1. **Account Management**: Customers should be able to create and manage their accounts, which includes setting their addresses and payment information.
- [ ] 2. **Restaurant Browsing**: Customers should be able to browse different restaurants, view their menus, and see reviews and ratings.
- [ ] 3. **Order Placement**: Customers should be able to place orders from restaurants, specifying the items they want and any customizations.
- [ ] 4. **Order Tracking**: After placing an order, customers should be able to track the status of their order in real-time.
- [ ] 5. **Payment Processing**: Customers should be able to pay for their orders securely through the system.
- [ ] 6. **Order History and Reordering**: Customers should be able to see their past orders and easily place the same order again.
- [ ] 7. **Rating and Reviews**: After the delivery, customers should be able to rate and review both the restaurant and the delivery personnel.
- [ ] 8. **Promotions and Discounts**: Customers should be able to see any current promotions or discounts, and these should be automatically applied to their orders if they qualify.
- [ ] 9. **Loyalty Program**: Customers should earn points for every order, and should be able to see their point balance and redeem points for discounts.
- [ ] 10. **Customer Support**: Customers should be able to access customer support via live chat, phone, or email.


### **Restaurant Features:**

- [ ] 1. **Account Management**: Restaurants need to manage their accounts, which includes setting their location, business hours, and bank account information for payouts.
- [ ] 2. **Menu Management**: Restaurants need to be able to update their menus, including adding new items, removing or disabling unavailable items, and updating prices.
- [ ] 3. **Order Management**: Restaurants need to be able to receive new orders, update the status of orders (e.g., preparing, ready for pickup), and see past orders.
- [ ] 4. **Payout Management**: Restaurants need to be able to see their earnings, manage payouts, and see transaction histories.
- [ ] 5. **Rating and Review Responses**: Restaurants should have the ability to respond to customer reviews.
- [ ] 6. **Promotion Management**: Restaurants should be able to offer promotions on their items, subject to any rules or restrictions set by the platform.
- [ ] 7. **Support**: Restaurants should also have access to customer support, in case they encounter any issues with order management, payments, etc.


### **Delivery Personnel Features:**

- [ ] 1. **Account Management**: Delivery personnel needs to manage their accounts, including setting their availability and managing their banking information for payouts.
- [ ] 2. **Delivery Management**: Delivery personnel needs to be able to receive new delivery assignments, navigate to the restaurant and then to the customer, and confirm when deliveries have been completed.
- [ ] 3. **Earnings Management**: Delivery personnel needs to be able to see their earnings, manage payouts, and see their transaction history.
- [ ] 4. **Loyalty Program System**: The backend services also need to support the loyalty program, including point accrual and redemption.
- [ ] 5. **Customer Support System**: There needs to be a system in place for managing customer support inquiries, which could include a ticketing system, chat system, etc.


## **Workflow**

### **For Customers**

1. **Account Creation and Management**:
    * Customers can create an account using their email or through social media integration.
    * Account management includes setting up and editing personal details, delivery addresses, and payment information.
2. **Restaurant Browsing and Filtering**:
    * Customers can browse different restaurants.
    * Advanced filtering options allow sorting by distance, cuisine type, ratings, or delivery time.
3. **Order Placement**:
    * Customers select items from the restaurant’s menu and add them to their cart.
    * At checkout, a detailed summary of the order is provided, including items, quantities, total price, and estimated delivery time.
4. **Payment Processing**:
    * Multiple payment options are available, such as credit/debit cards and mobile banking. Cash on delivery can also be chosen.
5. **Basic Order Tracking**:
    * After placing an order, customers can track its status (e.g., order placed, being prepared, out for delivery).
6. **Ratings and Reviews**:
    * Post-delivery, customers are encouraged to rate and review the restaurant and delivery service.


### **For Restaurants**

1. **Account Creation and Management**:
    * Restaurants set up their profiles, including location, business hours, and bank account information for payouts.
2. **Menu Management**:
    * Restaurants can update their menus, adding new items, modifying existing ones, and managing availability.
3. **Order Management**:
    * Restaurants receive orders, update the status (preparing, ready for pickup), and view past orders.
4. **Basic Analytics and Reporting** (Future Feature):
    * Basic reporting features for tracking sales, popular items, and customer preferences, with more advanced analytics tools planned for future implementation.


### **For Delivery Personnel**

1. **Account Creation and Management**:
    * Delivery personnel manage their profiles, including setting their availability and bank information for payouts.
2. **Delivery Management**:
    * They receive delivery assignments, navigate to the restaurant and customer’s location, and confirm delivery completion.


### **General System Features**

* **Security**: Basic security measures are in place, ensuring data protection and transaction safety.
* **Scalability**: The system is designed to handle an increasing number of users, orders, and data volume.
* **User Interface**: The system features a user-friendly interface for easy navigation and operation across all user types.


### **Future Enhancements**

* Implementation of a comprehensive customer support system.
* Real-time location tracking for orders.
* Advanced analytics tools for restaurants.
* Feedback mechanism for continuous system improvement.


## **Estimations**

### **Estimations for Initial Launch**


#### **1. Customer Base**

* **Target**: 1,000,000 customers.
* **Consideration**: Diverse geographical locations, varying peak usage times.


#### **2. Restaurant and Delivery Personnel**

* **Assumption**: A ratio can be established for restaurants and delivery personnel to customers. For instance, 1 restaurant per 50 customers and 1 delivery person per 100 customers.
* **Estimation**: Approximately 20,000 restaurants and 10,000 delivery personnel.


#### **3. Order Volume**

* **Assumption**: Average order frequency per customer (e.g., 4 orders per month).
* **Estimation**: Around 4,000,000 orders per month.


#### **4. Data Volume**

* **Estimation**: Large data sets encompassing user profiles, order histories, menu items, etc.


#### **5. Traffic and Usage Patterns**

* **Peak Times**: Estimate peak traffic times (e.g., weekends, evenings).
* **Load Variation**: Plan for normal load and peak load scenarios.


### **Growth Projections**

#### **Scaling to 100x**

* **Long-Term Target**: 100,000,000 customers.
* **Implications**: Exponential increase in restaurants and delivery personnel, order volume, and data handling.


### **Calculations**

1. **Restaurants:**
    * Assumption: 1 restaurant per 50 customers.
    * Calculation: 1,000,000 customers / 50 = 20,000 restaurants.
2. **Delivery Personnel:**
    * Assumption: 1 delivery person per 100 customers.
    * Calculation: 1,000,000 customers / 100 = 10,000 delivery personnel.
3. **Order Volume:**
    * Assumption: Average 4 orders per customer per month.
    * Calculation: 1,000,000 customers * 4 orders per month = 4,000,000 orders per month.


### **Memory & Quantity Calculation for each Table**

<table>
  <tr>
   <td><strong>Table Name</strong>
   </td>
   <td><strong>Row Count Calculation</strong>
   </td>
   <td><strong>Average Record Size Calculation</strong>
   </td>
   <td><strong>Memory Size Calculation</strong>
   </td>
   <td><strong>Database</strong>
   </td>
  </tr>
  <tr>
   <td><strong>Account Table</strong>
   </td>
   <td>103M (100M + 2M + 1M)
   </td>
   <td>4 (INT) + 780 (NVARCHAR) + 9 (DECIMAL) + 16 (DATETIME) = 809 bytes
   </td>
   <td>103M × 809 bytes = 83.347 GB
   </td>
   <td>Azure SQL Database
   </td>
  </tr>
  <tr>
   <td><strong>Customer Table</strong>
   </td>
   <td>100M (customers)
   </td>
   <td>8 (INT) + 200 (NVARCHAR) + 16 (DATETIME) = 224 bytes
   </td>
   <td>100M × 224 bytes = 22.4 GB
   </td>
   <td>Azure SQL Database
   </td>
  </tr>
  <tr>
   <td><strong>Restaurant Table</strong>
   </td>
   <td>2M (restaurants)
   </td>
   <td>8 (INT) + 200 (NVARCHAR) + 16 (DATETIME) = 224 bytes
   </td>
   <td>2M × 224 bytes = 448 MB
   </td>
   <td>Azure SQL Database
   </td>
  </tr>
  <tr>
   <td><strong>Rider Table</strong>
   </td>
   <td>1M (riders)
   </td>
   <td>8 (INT) + 200 (NVARCHAR) + 16 (DATETIME) = 224 bytes
   </td>
   <td>1M × 224 bytes = 224 MB
   </td>
   <td>Azure SQL Database
   </td>
  </tr>
  <tr>
   <td><strong>Order Table</strong>
   </td>
   <td>400M (100M customers × 4)
   </td>
   <td>12 (INT) + 18 (DECIMAL) + 300 (NVARCHAR) + 16 (DATETIME) = 346 bytes
   </td>
   <td>400M × 346 bytes = 138.4 GB
   </td>
   <td>Azure Cosmos DB
   </td>
  </tr>
  <tr>
   <td><strong>Delivery Order Table</strong>
   </td>
   <td>400M (orders)
   </td>
   <td>20 (INT) + 32 (DATETIME) + 200 (NVARCHAR) = 252 bytes
   </td>
   <td>400M × 252 bytes = 100.8 GB
   </td>
   <td>Azure Cosmos DB
   </td>
  </tr>
  <tr>
   <td>Location Table
   </td>
   <td>402M (400M orders + 2M restaurants)
   </td>
   <td>DECIMAL: 18 bytes (2 fields), NVARCHAR: 710 bytes (355 chars) = 728 bytes
   </td>
   <td>402M × 728 bytes ≈ 292.66 GB
   </td>
   <td>Azure Cosmos DB
   </td>
  </tr>
  <tr>
   <td><strong>Item Order Table</strong>
   </td>
   <td>1.2B (400M orders × 3 items/order)
   </td>
   <td>16 (INT) + 9 (DECIMAL) = 25 bytes
   </td>
   <td>1.2B × 25 bytes = 30 GB
   </td>
   <td>Azure Cosmos DB
   </td>
  </tr>
  <tr>
   <td>Item Table
   </td>
   <td>40M (20 items/restaurant × 2M restaurants)
   </td>
   <td>INT: 8 bytes (2 fields), DECIMAL: 18 bytes (2 fields), NVARCHAR: 510 bytes (255 chars) = 536 bytes
   </td>
   <td>40M × 536 bytes ≈ 21.44 GB
   </td>
   <td>Azure SQL Database
   </td>
  </tr>
  <tr>
   <td>Ledger Table
   </td>
   <td>1.6B (4 transactions/order × 400M orders)
   </td>
   <td>INT: 12 bytes (3 fields), DECIMAL: 9 bytes, DATETIME: 8 bytes, NVARCHAR: 400 bytes (200 chars) = 429 bytes
   </td>
   <td>1.6B × 429 bytes ≈ 686.4 GB
   </td>
   <td>Azure Cosmos DB
   </td>
  </tr>
</table>


Notes:



* “Row Count Calculation” is based on the final growth projections. For example, the Account Table’s row count is the sum of customers, restaurants, and riders.
* “Average Record Size Calculation” is the sum of bytes used by each type of field in a record. For example, in the Account Table, we calculate the bytes for each field type (INT, NVARCHAR, DECIMAL, DATETIME) and sum them up.
* “Memory Size Calculation” multiplies the total row count by the average record size to estimate the total memory required for each table.
* These estimates are for planning purposes and actual database sizes may vary based on real-world data distributions, database engine specifics, and other factors like compression and indexing.


## **Architectural Considerations**

With these calculations in hand, we can now consider the architectural aspects:

1. **Scalability:** The system must be able to scale effectively to handle the large number of users, restaurants, delivery personnel, and the high order volume.
2. **Elasticity:** The architecture should dynamically adapt to varying loads, especially during peak times like weekends and evenings.
3. **Reliability and Availability:** The system should be designed for high reliability and availability, including redundant components and failover mechanisms to handle system failures without impacting user experience.
4. **Performance:** Optimize for fast response times and efficient processing to handle real-time operations like order tracking and payment processing.
5. **Security and Data Management:** Implement robust security measures for data protection, and design a system that can handle large data sets (user profiles, order histories, menu items, etc.) with durability and integrity.
6. **User Interface:** Ensure the system is user-friendly for all user types (customers, restaurants, delivery personnel).
7. **Integration of Services:** Seamlessly integrate various services like account management, payment processing, order tracking, customer support, etc.


### **Architectural Implications**

With such significant growth projections, several key architectural considerations must be addressed:

1. **Advanced Scalability:** The system must be designed for extreme scalability, capable of handling 100 times the initial user and transaction volume.
2. **Robust Infrastructure:** The infrastructure must be robust enough to support the exponential increase in users, orders, and data, possibly requiring cloud solutions with global distribution and high resilience.
3. **Enhanced Performance:** Performance optimization becomes even more critical, with a focus on efficient processing and low latency to handle a substantially higher volume of real-time transactions.
4. **Data Handling and Storage:** Data management strategies need to be scalable and efficient, capable of handling exponentially larger datasets.
5. **Advanced Analytics:** Implementing advanced analytics tools will be essential for understanding customer behavior, optimizing restaurant performance, and streamlining delivery operations at this scale.
6. **Automated Scaling and Load Balancing:** Automated scaling solutions and sophisticated load balancing will be necessary to efficiently manage the variable and high-volume traffic.
7. **Continuous System Improvement:** A feedback mechanism should be in place for continuous system improvement, considering user feedback, system performance data, and evolving business needs.
