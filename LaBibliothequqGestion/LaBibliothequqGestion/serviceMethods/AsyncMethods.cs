using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LaBibliothequqGestion {
    class AsyncMethods {
        private HttpClient client = new HttpClient();

        public AsyncMethods(String uri) {
            client.BaseAddress = new Uri(uri);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<User>> GetAllUsersAsync() {
            HttpResponseMessage response = await client.GetAsync("api/User/");
            if (response.IsSuccessStatusCode) {
                IList<User> users = await response.Content.ReadAsAsync<IList<User>>();
                return users.ToList();
            }
            else {
                return new List<User>();
            }
        }

        public async Task<User> FindUser(int id) {
            String url = "api/User/" + id;
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode) {
                User user = await response.Content.ReadAsAsync<User>();
                return user;
            }
            else {
                return null;
            }
        }

        public async Task<bool> AddUser(User user) {
            HttpResponseMessage response = await client.PostAsJsonAsync("api/User/", user);
            if (response.IsSuccessStatusCode) {
                return true;
            } else {
                return false;
            }
        }

        public async Task<bool> UpdateUser(User user) {
            HttpResponseMessage response = await client.PutAsJsonAsync("api/User/", user);
            if (response.IsSuccessStatusCode) {
                return true;
            } else {
                return false;
            }
        }

        public async Task<bool> DeleteUser(int id) {
            String url = "api/User/" + id;
            HttpResponseMessage response = await client.DeleteAsync(url);
            if (response.IsSuccessStatusCode) {
                return true;
            } else {
                return false;
            }
        }

        public async Task<bool> UserLimitReached(int id) {
            String url = "api/User/" + id + "/limit";
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode) {
                var customerJsonString = await response.Content.ReadAsStringAsync();
                bool result = JsonConvert.DeserializeObject<bool>(custome‌​rJsonString);
                return result;
            } else {
                return false;
            }
        }

        public async Task<List<Author>> GetAllAuthors() {
            HttpResponseMessage response = await client.GetAsync("api/Author/");
            if (response.IsSuccessStatusCode) {
                IList<Author> authors = await response.Content.ReadAsAsync<IList<Author>>();
                return authors.ToList();
            }
            else {
                return new List<Author>();
            }
        }

        public async Task<Author> FindAuthor(int id) {
            String url = "api/Author/" + id;
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode) {
                Author author = await response.Content.ReadAsAsync<Author>();
                return author;
            }
            else {
                return null;
            }
        }

        public async Task<bool> AddAuthor(Author author) {
            HttpResponseMessage response = await client.PostAsJsonAsync("api/Author/", author);
            if (response.IsSuccessStatusCode) {
                return true;
            }
            else {
                return false;
            }
        }

        public async Task<bool> UpdateAuthor(Author author) {
            HttpResponseMessage response = await client.PutAsJsonAsync("api/Author/", author);
            if (response.IsSuccessStatusCode) {
                return true;
            }
            else {
                return false;
            }
        }

        public async Task<bool> DeleteAuthor(int id) {
            String url = "api/Author/" + id;
            HttpResponseMessage response = await client.DeleteAsync(url);
            if (response.IsSuccessStatusCode) {
                return true;
            }
            else {
                return false;
            }
        }

        public async Task<List<Book>> GetAllBooks() {
            HttpResponseMessage response = await client.GetAsync("api/Book/");
            if (response.IsSuccessStatusCode) {
                IList<Book> books = await response.Content.ReadAsAsync<IList<Book>>();
                return books.ToList();
            }
            else {
                return new List<Book>();
            }
        }

        public async Task<List<Book>> GetAvailableBooks() {
            HttpResponseMessage response = await client.GetAsync("api/Book/available");
            if (response.IsSuccessStatusCode) {
                IList<Book> books = await response.Content.ReadAsAsync<IList<Book>>();
                return books.ToList();
            }
            else {
                return new List<Book>();
            }
        }

        public async Task<Book> FindBook(int id) {
            String url = "api/Book/" + id;
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode) {
                Book book = await response.Content.ReadAsAsync<Book>();
                return book;
            }
            else {
                return null;
            }
        }

        public async Task<bool> AddBook(Book book) {
            HttpResponseMessage response = await client.PostAsJsonAsync("api/Book/", book);
            if (response.IsSuccessStatusCode) {
                return true;
            }
            else {
                return false;
            }
        }

        public async Task<bool> UpdateBook(Book book) {
            HttpResponseMessage response = await client.PutAsJsonAsync("api/Book/", book);
            if (response.IsSuccessStatusCode) {
                return true;
            }
            else {
                return false;
            }
        }

        public async Task<bool> DeleteBook(int id) {
            String url = "api/Book/" + id;
            HttpResponseMessage response = await client.DeleteAsync(url);
            if (response.IsSuccessStatusCode) {
                return true;
            }
            else {
                return false;
            }
        }

        public async Task<List<Order>> GetAllOrders() {
            HttpResponseMessage response = await client.GetAsync("api/Order/");
            if (response.IsSuccessStatusCode) {
                IList<Order> orders = await response.Content.ReadAsAsync<IList<Order>>();
                return orders.ToList();
            }
            else {
                return new List<Order>();
            }
        }

        public async Task<Order> FindOrder(int id) {
            String url = "api/Order/" + id;
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode) {
                Order order = await response.Content.ReadAsAsync<Order>();
                return order;
            }
            else {
                return null;
            }
        }

        public async Task<bool> AddOrder(Order order) {
            HttpResponseMessage response = await client.PostAsJsonAsync("api/Order/", order);
            if (response.IsSuccessStatusCode) {
                return true;
            }
            else {
                return false;
            }
        }

        public async Task<bool> UpdateOrder(Order order) {
            HttpResponseMessage response = await client.PutAsJsonAsync("api/Order/", order);
            if (response.IsSuccessStatusCode) {
                return true;
            }
            else {
                return false;
            }
        }

        public async Task<bool> DeleteOrder(int id) {
            String url = "api/Order/" + id;
            HttpResponseMessage response = await client.DeleteAsync(url);
            if (response.IsSuccessStatusCode) {
                return true;
            }
            else {
                return false;
            }
        }

        public async Task<bool> TakeAwayOrder(int id) {
            String url = "api/Order/" + id + "/takeaway";
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode) {
                return true;
            }
            else {
                return false;
            }
        }

        public async Task<bool> TakeBackOrder(int id) {
            String url = "api/Order/" + id + "/takeback";
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode) {
                return true;
            }
            else {
                return false;
            }
        }

        public async Task<bool> CancelOrder(int id) {
            String url = "api/Order/" + id + "/cancel";
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode) {
                return true;
            }
            else {
                return false;
            }
        }

        public async Task<bool> OrderTakeAwayLimit(int id) {
            String url = "api/Order/" + id + "/takeawaylimit";
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode) {
                var customerJsonString = await response.Content.ReadAsStringAsync();
                bool result = JsonConvert.DeserializeObject<bool>(custome‌​rJsonString);
                return result;
            }
            else {
                return false;
            }
        }

        public async Task<bool> OrderTakeBackLimit(int id) {
            String url = "api/Order/" + id + "/takebacklimit";
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode) {
                var customerJsonString = await response.Content.ReadAsStringAsync();
                bool result = JsonConvert.DeserializeObject<bool>(custome‌​rJsonString);
                return result;
            }
            else {
                return false;
            }
        }

        public async Task<bool> CancelNotTakenOrders() {
            String url = "api/Order/cancelnottaken";
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode) {
                var customerJsonString = await response.Content.ReadAsStringAsync();
                bool result = JsonConvert.DeserializeObject<bool>(custome‌​rJsonString);
                return result;
            }
            else {
                return false;
            }
        }

        public async Task<bool> Login(string pn, string pass) {
            String url = "api/user/" + pn + "/"+pass;
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
