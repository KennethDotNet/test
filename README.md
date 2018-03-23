# testTest document

You will need to adjust the appsettings.json to meet an instance of sql server to host the identity database. 
Default username: test with password: Password!123
HUBS:
•	/test (gives errors)
•	/testme (no errors)


Original issues: Cannot connect to the Hub, gets a not authorized error. See github issue:
https://github.com/aspnet/SignalR/issues/1687

Currently I have not reproduced this in a new test project, but I have now an issue with it connects and then 
drops the connection right after 
 
This happened after adding the HubWithPrencese classes. Which I think is the reason for the original issues. 

Test case 1
Start the application and log on with the testuser. Check the console log of the browser. I will show the about error

Buy changing the hub to /testme it works as excepted. 





