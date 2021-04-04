<h2>Movie-Review</h2>
<b>Movie Review Web API using dotnetcore 3.1</b>



<b>Features:</b>
* Can Add Language.
* Add / Update Movie.
* View / Add Review for Movie
* The whole project is based on Entity Framework, Linq, and Lambda expression.

<b>Language used              : asp.net core web api (MVC)
  
Database                        : Microsoft SQL Server 2017</b>

<h2> How to run the project : </h2>

1. In visual studio, open the solution or project.
3. Modify the Connection String as you needed to connect to database. Go to (inside project) :
appsetting.json. At the last portion, you'll find the connection string like below : 

```
"ConnectionStrings": {
    "MovieConnectionString": "Data Source=server-name\\SQLEXPRESS;Initial Catalog=dbname; Integrated Security=true;"
  }
  ```
  
  * Check on the internet how to write or change Connection Strings, change your <b>data source, user id, password</b> as needed. Or provide <b> Windows Authentication </b>, as your wish.
  
  4. <b>Some word of wisdom : This is a  basic project in ASP.NET CORE WEBAPI. My intention to upload this so that you will, get some idea for your project.</b>
  
  ## Contributing [![contributions welcome](https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat)](https://github.com/tapankumeher/Movie-Review/issues)
      Enjoy !!
