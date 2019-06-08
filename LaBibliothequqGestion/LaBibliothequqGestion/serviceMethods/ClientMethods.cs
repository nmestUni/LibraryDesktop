using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LaBibliothequqGestion
{
    public class ClientMethods {

        //private static AsyncMethods methods = new AsyncMethods("http://localhost:49514/");

        private AsyncMethods methods;

        public ClientMethods(String uri) {
            methods = new AsyncMethods(uri);
        }
        
        public List<User> GetAllUsers() {
            return methods.GetAllUsersAsync().Result;
        }

        public User FindUser(int id) {
            return methods.FindUser(id).Result;
        }

        public bool AddUser(User user) {
            return methods.AddUser(user).Result;
        } 
        
        public bool UpdateUser(User user) {
            return methods.UpdateUser(user).Result;
        }

        public bool DeleteUser(int id) {
            return methods.DeleteUser(id).Result;
        }

        public bool UserLimitReached(int id) {
            return methods.UserLimitReached(id).Result;
        }

        public List<Author> GetAllAuthors() {
            return methods.GetAllAuthors().Result;
        }

        public Author FindAuthor(int id) {
            return methods.FindAuthor(id).Result;
        }

        public bool AddAuthor(Author author) {
            return methods.AddAuthor(author).Result;
        }

        public bool UpdateAuthor(Author author) {
            return methods.UpdateAuthor(author).Result;
        }

        public bool DeleteAuthor(int id) {
            return methods.DeleteAuthor(id).Result;
        }

        public List<Book> GetAllBooks() {
            return methods.GetAllBooks().Result;
        }

        public List<Book> GetAvailableBooks() {
            return methods.GetAvailableBooks().Result;
        }

        public Book FindBook(int id) {
            return methods.FindBook(id).Result;
        }

        public bool AddBook(Book book) {
            return methods.AddBook(book).Result;
        }

        public bool UpdateBook(Book book) {
            return methods.UpdateBook(book).Result;
        }

        public bool DeleteBook(int id) {
            return methods.DeleteBook(id).Result;
        }

        public List<Order> GetAllOrders() {
            return methods.GetAllOrders().Result;
        }

        public Order FindOrder(int id) {
            return methods.FindOrder(id).Result;
        }

        public bool AddOrder(Order order) {
            return methods.AddOrder(order).Result;
        }

        public bool UpdateOrder(Order order) {
            return methods.UpdateOrder(order).Result;
        }

        public bool DeleteOrder(int id) {
            return methods.DeleteOrder(id).Result;
        }

        public bool TakeAwayOrder(int id) {
            return methods.TakeAwayOrder(id).Result;
        }

        public bool TakeBackOrder(int id) {
            return methods.TakeBackOrder(id).Result;
        }

        public bool CancelOrder(int id) {
            return methods.CancelOrder(id).Result;
        }

        public bool OrderTakeAwayLimit(int id) {
            return methods.OrderTakeAwayLimit(id).Result;
        }

        public bool OrderTakeBackLimit(int id) {
            return methods.OrderTakeBackLimit(id).Result;
        }

        public bool CancelNotTakenOrders() {
            return methods.CancelNotTakenOrders().Result;
        }

        public bool Login(String pn, String pass) {
            return methods.Login(pn, pass).Result;
        }
    }

}
