# Catalog

A basic API based on .NET and C# . It is standalone API , having basic fucntionality of reteriving data over HTTP GET .



<a href = https://github.com/swagger-api/swagger-ui/releases> Swagger UI </a>

For running this u need swagger ui and can be dowloaded from above link

Installation prodecure for swagger 

```
  npm install -g http-server
```

for installation and starting the service of swagger navigate to directory where swagger is unpacked 

```
  npm install
```
then in same directory 

```
  npm start
```
<b> NOTE: </b>  Swagger by default run on localhost:3002 and our program runs on localhost:5001 , so change the port and in url like this

```
  localhost:5001/swagger/index.html
```

Before running program self-signed the certificates for traffic over HTTPS in VScode terminal 

```
  dotnet dev-certs https --trust
```
Then press f5 to run the program 

![Screenshot 2021-12-18 175005](https://user-images.githubusercontent.com/36817376/146640981-daca7242-8ad3-4cf6-a584-713cf155b1a5.png)





![Screenshot 2021-12-18 175054](https://user-images.githubusercontent.com/36817376/146640988-fc2cfba8-1cf2-4a7e-b84c-f05c7e8c250f.png)


Need to add mongo db driver package to connect MongoDB

```
  dotnet add package MongoDB.Driver
```