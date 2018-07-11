using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Basic

            #region Single Post

            //var client = new RestClient();
            //client.BaseUrl = new Uri("https://jsonplaceholder.typicode.com/posts/1");

            //var request = new RestRequest();

            //IRestResponse<Post> post = client.Execute<Post>(request);
            //string title = post.Data.title;

            //Console.WriteLine(title);

            #endregion

            #region Multiple Posts

            //var client = new RestClient();
            //client.BaseUrl = new Uri("https://jsonplaceholder.typicode.com/posts");

            //var request = new RestRequest();

            //var posts = client.Execute<List<Post>>(request);

            //foreach (var item in posts.Data)
            //{
            //    Console.WriteLine(item.title);
            //}

            #endregion

            #region Single Post with Query Parameters

            //Post post = new Post
            //{
            //    body = "Doby",
            //    title = "Totle",
            //    userId = 1
            //};

            //var client = new RestClient("https://jsonplaceholder.typicode.com/posts");

            //var request = new RestRequest("/", Method.POST);
            //request.RequestFormat = DataFormat.Json;
            //request.AddBody(post);

            //var response = client.Execute(request);

            //var postIncoming = JObject.Parse(response.Content);

            //string title = post.Data.title;

            //Console.WriteLine(title);

            #endregion

            #endregion

            #region Custom API

            #region  GET Single Student

            //var client = new RestClient();
            //client.BaseUrl = new Uri("http://localhost:52832/api/");

            //RestRequest request = new RestRequest("Students", Method.GET);

            //IRestResponse<List<Student>> students = client.Execute<List<Student>>(request);

            //foreach (var item in students.Data)
            //{
            //    Console.WriteLine(item.Name);
            //}

            #endregion

            #region GET all Students

            //var client = new RestClient();
            //client.BaseUrl = new Uri("http://localhost:52832/api/");

            //RestRequest request = new RestRequest("Students", Method.GET);

            //IRestResponse<List<Student>> students = client.Execute<List<Student>>(request);

            //foreach (var item in students.Data)
            //{
            //    Console.WriteLine(item.Name);
            //}

            #endregion

            #region Post Student

            //Student student = new Student
            //{
            //    Address = "Dylan Patrick Address",
            //    DateOfBirth = DateTime.Now,
            //    Name = "Dylan Patrick",
            //    Phone = "464646"
            //};

            //var client = new RestClient("http://localhost:52832/api/");

            //RestRequest request = new RestRequest("Students", Method.POST);
            //request.AddJsonBody(student);

            //IRestResponse response = client.Execute(request);

            //Console.WriteLine(response.StatusCode);

            #endregion

            #endregion

            #region Custom API Secure

            #region  GET Single Student

            //var client = new RestClient();
            //client.BaseUrl = new Uri("http://localhost:52832/api/");
            ////client.Authenticator = new HttpBasicAuthenticator("frank@gmail.com", "Abcd1234.");

            //string token = "lxe0mf8GkHfWoK1dJzKRVg33MfjlWuq-XhvIyWNniW3_1gg-CHCuGfkMCi5OIA5c6NM5nRdENEvGRMjJAl5_Yb8liRlK2E0AcG9QVumrKmF_Bzs8Qnm_XvhYWrk1S8lMHiMlJjDVWZ4pTVHq5zmHa-GRd3usH6vi7SmbUHEvfKmW6cs52k3NAVt9chKX4VMLaJJCDvE5UOsn7kgsw6vFktfL2iNVIXxiwn6sWzM0KkBYaCwrxDvNyF7DTN1QOL7MisdbMM9UZK1UqkNAdppESTn33Jh7J8A_2d6qY_Kx_oW5At35t4K0-sU5q9KHM5gk0BPUiZhzEjW2jbVZSl66EdDReOvjykwjd5h5kgZqSpKUumm3ahf50LpDzBM_rwbZA7RBwR6_eYzSCjQAhYqu5cTDqxG86bm93QFCN8jFcLvV-bEOX1NK1SRB2MvnsykQQSFt9WlupCM_gwzQ-TECS4EEAY27AH1uYUfw8LuzDB3XnKcHLx0xHqQFny9R-5Nz";

            //RestRequest request = new RestRequest("StudentsSecure", Method.GET);
            //request.AddHeader("authorization", "bearer " + token);

            //IRestResponse<List<Student>> students = client.Execute<List<Student>>(request);

            //foreach (var item in students.Data)
            //{
            //    Console.WriteLine(item.Name);
            //}

            #endregion

            #region GET all Students

            //var client = new RestClient();
            //client.BaseUrl = new Uri("http://localhost:52832/api/");

            //RestRequest request = new RestRequest("Students", Method.GET);

            //IRestResponse<List<Student>> students = client.Execute<List<Student>>(request);

            //foreach (var item in students.Data)
            //{
            //    Console.WriteLine(item.Name);
            //}

            #endregion

            #region Post Student

            //Student student = new Student
            //{
            //    Address = "Dylan Patrick Address",
            //    DateOfBirth = DateTime.Now,
            //    Name = "Dylan Patrick",
            //    Phone = "464646"
            //};

            //var client = new RestClient("http://localhost:52832/api/");

            //RestRequest request = new RestRequest("Students", Method.POST);
            //request.AddJsonBody(student);

            //IRestResponse response = client.Execute(request);

            //Console.WriteLine(response.StatusCode);

            #endregion

            #endregion

            Console.ReadKey();
        }
    }
}
