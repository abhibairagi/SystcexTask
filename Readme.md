<!-- Api List -->
<!-- --- Customers List --- -->
http://localhost:5182/api/customer/count
http://localhost:5182/api/customer/list


<!-- --- Supplier List --- -->
http://localhost:5182/api/supplier/count
http://localhost:5182/api/supplier/list


<!-- --- Meetings List --- -->
http://localhost:5182/api/meetings/count
http://localhost:5182/api/meetings/list

<!-- Trade Transaction List --- -->

http://localhost:5182/api/TradeTransaction/list


<!-- NOTE -->
I opted for a monolithic architecture over microservices due to my recent introduction to .NET and limited time availability. However, I am committed to rapidly learning microservice architecture within a week and am confident that within a month, I will have a solid understanding of both .NET and microservices.




<!-- Brief Overiew -->

Architecture:

Customer: This microservice will handle operations related to customers. It will include APIs to retrieve the count of customer records and to retrieve a list of customer records with their details.

Supplier Service: Similar to the Customer microservice, this microservice will handle operations related to suppliers. It will include APIs to retrieve the count of supplier records and to retrieve a list of supplier records with their details.

Meetings Service: This microservice will handle operations related to meetings. It will include APIs to retrieve the count of meeting records and to retrieve a list of meeting records with their details.

Trade Transactions Service: This service will handle trade transactions based on their IDs. It will include an API to display a list of trade transactions, with statuses reflecting the trade flow as per the provided documentation.


<!-- Setup Instructions -->

1. Create a New ASP.NET Web API Project called TestAPi

2. Define Models:
Define models for Customer, Supplier, Meeting, and Trade Transaction based on your requirements.

3. Implement APIs:
For each module (Customer, Supplier, Meetings), create two APIs as specified:
One to retrieve the count of records.
One to retrieve a list of records providing details for each item.
For trade transactions, create an API to display a list of transactions based on their IDs and their status.

5. Implement Business Logic:
Implement the logic to fetch data from the database or any other source for each API endpoint.

6. Add Swagger:
Add Swagger to document and test your APIs easily. You can do this by installing the Swashbuckle NuGet package.

7. Test Your APIs:
Test each API endpoint thoroughly to ensure they're working as expected.




s








