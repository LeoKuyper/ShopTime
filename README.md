# ShopTime

![](https://lh4.googleusercontent.com/Ho_JbODZvkg6sCP25QqnCcpM6JiYFYrwA6wSF17Y9TjuWwllzJeoS5iPrcUx0rE_FUzobl4K1JeisQTa5mN__615J4Qn4Kj9vgTVkEJobN96iTTLBA1WkZnHXjrm2vpExCe_GNfO)

# 1  INTRODUCTION
This project ShopTime was made using Visual Studio, asp.net and Microsoft’s C#. The concept is a type of queuing system which would allow shops to monitor and manage how many clients is in a shop at a time. Through this system, we would be able to more efficiently keep to the social distancing rules.
# 2  CONCEPT (FEATURES + FUNCTIONS)

 -   Core Functionality   
Current queue - Keeping track of where you currently are in a queue
Get in the queue - Allow a user to get in the queue
-   Additional Functionality   
Available Cashiers - Check the available cashiers at a certain shop
General info - Brief description of the shop
 -   Potential Future Functionality
    Estimate time - The estimated time left in the queue
Online booking/shopping - book the items you would like to buy
Map - A map of supported shops
Geolocation - This would only allow a user to make a booking if they are in the shop’s area
Priority user - Will give a disable or elderly person priority in the queue.
# 3  TECHNICAL PLANNING
This project was made using asp .net and C#. I chose to use 3 DataTable for this project, which made us of one2many relations and a few one2one relations. For the database implementation, I chose to use MySQL as it wasn’t so limiting as SQLLite, which is the norm for Mac as I am using.

  

For the Front-end, I used Bootstrap as it is already backed into asp .net.

  

![](https://lh6.googleusercontent.com/q4IHHeQM7PGi7dv--1p-4kHVXCKjC4PP1PTkSCB3qJZg8BSFbyv5m2q0jNabCkijwBDoi7hhmaUqT3PnO6WHNFZ3A5jG5yCxeZNBAEZaQRUyd6HK8ZtxnQM4uE3yr9k23D6dlRjE)

This was my initial design of how my DataTables would function. But after experimentation and talking to my Lecturer I found it not to be very successful.

  

I then did a redesign of the architecture, which led me to the following Table:![](https://lh6.googleusercontent.com/NJ7LzSOQlQJq4J-nMvFhd5616r5pjscx9c65M_3fu6hVzjPc6ZqFE_nI_9zHgNHuKEEffpIITAKna2AiXoErhtKy5QCRj5blcH0_E9pDVlEORtyC6ntP0obqVRFo2dDnH3YpGK1P)

This table was much efficient and easy to understand.

# 4  FINAL OUTCOME AND IMPLEMENTATION
### Implementation + Testing

After my initial testing and experimentation, I saw that my scope was way too big for this project. If since then decided to decrease my initial scope of features. I have as previously discussed changed my DataBase Tables as well.

  

### Highlights and Challenges

Personally I don’t like Visual Studio or asp.net. I have used C# previously in other projects, but it is very unstable on Visual Studio in my experience. I think with that said the biggest challenge was Visual Studio and Asp.net, it was and still is very unstable to work with. I also feel for the type of service they are ‘claiming’ to provide their documentation leaves much desired. Visual Studio on MacOS has also been a huge struggle, as most functions that are available on Windows was seemingly missing or just not functioning properly. Another challenge I experienced was with the default database Visual Studio uses with MacOS which is SQLLite, it had a few problems with managing the foreign key. This made me use MySQL with a MAMP application, it took a while to figure out how to connect it. But in the end I did find a solution for it.

  

What I enjoyed was, how Visual Studio scaffolded the information/data automatically for you. I also enjoyed working with Bootstrap again, it just made building the front-end a breeze.

### Learning

I learned how to build a Website with asp.net using C#. I got a lot more experience in DataBase architecture, and how data should be managed on a website.
# 5  CONCLUSION
This project has surely been a stressful one, compared to the other projects I have done. I am really happy with what I have accomplished with my project, but I do feel I expected a much better result at the beginning of the term. The learning curve for this project was really intense as we didn’t really have a base of asp.net and how to successfully use it. The thing that was the hardest for me was the Windows/MacOS situation, where a certain functionality would work on a certain platform but would fail on the other. This was the same with tutorial and even Official documentation of Microsoft. 

I would never again in my life use Visual Studio or asp.net, I feel there are a lot of better technologies/frameworks available. Which are a lot more stable. 

If I had a chance to redo the project, I would do it on Windows and use a RazorPage template with Authentication, as I found to the end that I could get a lot more up to date tutorials and documentation for it. 

But in the end, I am happy with what I have achieved. It works in the bare minimum of what the brief requires, but it works.

# 6  REFERENCE LIST
https://github.com/LeoKuyper/ShopTime

https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-view?view=aspnetcore-3.1&tabs=visual-studio

https://code-maze.com/asp-net-core-identity-series/

https://www.learnentityframeworkcore.com/

https://blog.ijasoneverett.com/2019/06/net-core-identity-and-mysql-on-macos/

https://www.c-sharpcorner.com/article/how-to-connect-mysql-with-asp-net-core/

https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-3.1&tabs=visual-studio-mac
