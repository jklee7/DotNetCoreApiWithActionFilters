An example demonstrating how to implement Action filters in ASP.net Core.

Action filters can run code immediately before and after an individual action method is called. They can be used to manipulate the arguments passed into an action and the result returned from the action.

In this example, we implement a filter to check for the presence of a 'key' header in the HTTP request (_we don't actually care what the key is, only that the header is present_). 

---


# Instructions
#### Packages
No additional packages are required. This is out of the box ASP.net Core MVC.

---

#### Things to note:

- KeyFilter.cs implements the actual filtering action.
- The filter is added to the request pipeline in the Startup class, with the following code:
```c#
public void ConfigureServices(IServiceCollection services)
{
    services.AddMvc(options => { options.Filters.Add(new KeyFilter()); });
}
```
- To test: 
```
curl --header "key: 123" https://localhost:5001/api/v1/message
```

---

#### Useful References

- [Filters in ASP.NET Core][1]


[1]: https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/filters?view=aspnetcore-2.1