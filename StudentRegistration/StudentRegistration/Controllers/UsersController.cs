using Microsoft.AspNetCore.Mvc;
using StudentRegistration.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;

namespace StudentRegistration.Controllers
{
    public class UsersController : Controller
    {
        public int UsersCount { get; private set; }
        public int TotalPages { get; private set; }

        public IActionResult GetUsers()
        {

            IEnumerable<Data> users = null;
            using (var client = new HttpClient())
            {
                var responseTask = client.GetAsync("http://localhost:64846/api/Default/GetUsers");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Data>>();
                    readTask.Wait();
                    users = readTask.Result;
                }
                else
                {
                    users = Enumerable.Empty<Data>();
                    ModelState.AddModelError(string.Empty, "Server error try after some time.");
                }
            }
            UsersCount = users.Count();
            TotalPages = (UsersCount / 5) + 1;

            int recordstoSkip = 0;

            PagingViewModel pagingViewModel = new PagingViewModel()
            {
                users = users.Skip(recordstoSkip).Take(5).ToList(),
                TotalPages = TotalPages,
            };
            return View(pagingViewModel);
        }
        public IActionResult Paging(int page)
        {
            IEnumerable<Data> users = null;
            using (var client = new HttpClient())
            {
                var responseTask = client.GetAsync("http://localhost:64846/api/Default/GetUsers");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Data>>();
                    readTask.Wait();
                    users = readTask.Result;
                }
                else
                {
                    users = Enumerable.Empty<Data>();
                    ModelState.AddModelError(string.Empty, "Server error try after some time.");
                }
            }
            int recordstoSkip = (page - 1) * 5;
            return PartialView("_GetUsersPartial", users.Skip(recordstoSkip).Take(5).ToList());
        }

        public IActionResult SearchUserByDetails(Data model)
        {
            IEnumerable<Data> users = null;

            using (var client = new HttpClient())
            {
                var input = ToQueryString(model);
                var responseTask = client.GetAsync("http://localhost:64846/api/Default/SearchResult?" + input);
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Data>>();
                    readTask.Wait();
                    users = readTask.Result;
                }
                else
                {
                    users = Enumerable.Empty<Data>();
                    ModelState.AddModelError(string.Empty, "Server error try after some time.");
                }
            }
            return PartialView("_GetUsersPartial", users);
        }

        private string ToQueryString(object model, string prefix = null)
        {
            if (model == null)
            {
                return null;
            }

            var attributes = model.GetType().GetProperties().Where(x => x.CanRead).Where(x => x.GetValue(model, null) != null)
                .ToDictionary(x => x.Name, x => x.GetValue(model, null));

            return string.Join("&", attributes.Select(kvp => MakeQueryString(kvp, prefix)));
        }

        private string MakeQueryString(KeyValuePair<string, object> attributeList, string prefix)
        {
            if (attributeList.Value.GetType() == typeof(DateTime))
            {
                var dateFormatTable = attributeList.Value as IFormattable;
                var value = dateFormatTable == null ? attributeList.Value.ToString() : dateFormatTable.ToString("o", CultureInfo.InvariantCulture);

                return $"{GetAttributePrefix(prefix)}{Uri.EscapeDataString(attributeList.Key)}={Uri.EscapeDataString(value)}";
            }
            else if (attributeList.Value.GetType().IsValueType || attributeList.Value.GetType() == typeof(string))
            {
                return $"{GetAttributePrefix(prefix)}{Uri.EscapeDataString(attributeList.Key)}={Uri.EscapeDataString(attributeList.Value.ToString())}";
            }
            else
            {
                if (string.IsNullOrWhiteSpace(prefix))
                {
                    return ToQueryString(attributeList.Value, attributeList.Key);
                }
                else
                {
                    return ToQueryString(attributeList.Value, prefix + "." + attributeList.Key);
                }
            }
        }

        private string GetAttributePrefix(string prefix)
        {
            return !string.IsNullOrWhiteSpace(prefix) ? $"{prefix}." : string.Empty;
        }
        public IActionResult RegisterUser(Data model)
        {

            using (var client = new HttpClient())
            {
                var input = ToQueryString(model);
                var responseTask = client.GetAsync("http://localhost:64846/api/Default/Register?" + input);
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("GetUsers");
                }
            }
            return View();
        }

        public ActionResult Edit(string name)
        {
            Data user = new Data();
            IEnumerable<Data> users = null;
            using (var client = new HttpClient())
            {

                var responseTask = client.GetAsync("http://localhost:64846/api/Default/GetUser?name=" + name);
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Data>>();
                    readTask.Wait();
                    users = readTask.Result;
                    foreach (var item in users)
                    {
                        user.Name = item.Name;
                        user.Address = item.Address;
                        user.PhoneNo = item.PhoneNo;
                        user.Email = item.Email;
                        user.State = item.State;
                        user.Approved = item.Approved;
                    }

                }
                else
                {
                    user = new Data();
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(user);
        }

        public ActionResult Update(Data model)
        {
            using (var client = new HttpClient())
            {
                var input = ToQueryString(model);
                var responseTask = client.GetAsync("http://localhost:64846/api/Default/Update?" + input);
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("GetUsers");
                }
            }
            return View();
        }

    }
}





