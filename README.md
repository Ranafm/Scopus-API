# Scoups API:
### Scoups provides API to get access to:
#### - Citation data and abstracts from virtually all relevant scholarly journals, as indexed by Scopus, Elsevier's citation database.
#### - Journals and books published by Elsevier on ScienceDirect full-text platform;
#### - Research metrics available on SciVal, Elsevier's platform for research performance benchmarking.
#### - Engineering resources available on Engineering Village.
#### - Curated abstracts, indices and other metadata indexed by Embase, Elsevier's biomedical abstract and indexing database.
You need to request an API key from Scoups Developers Portal.
# Requirements:

To run the Project First Create ASP.NET Web application  (.NET Framework). After the project is created do the following:
- On the solution  create a Console Application.
- Install the following from the NuGet Packages. 
- - Newtonsoft.Json
- - Microsoft.AspNet.WebApi.Client
- - System.Net.Http
- Create a folder named Entities, then add a new class named (entry) and paste the class variables (you can change the variables names and types based on your API you are requesting).
#### Then, paste the Program.cs code in your program.cs and add your API key. To run the console application set it as start project then press Ctrl+F5 to view the output.
Next, in the Web Application project do the following :
- in Reference at the Web Application  Project >> add new reference >> projects >> choose the Console Application  Project.
- Then paste the HTML and the CS code into a web form.
#### To run the project, set it as the start project and browse it.
#### You can request another API, but you should know how to store the data wanted from the response by knowing the difference between objects and arrays.



