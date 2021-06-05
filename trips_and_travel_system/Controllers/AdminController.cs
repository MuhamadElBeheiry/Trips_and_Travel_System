using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using trips_and_travel_system.Models;

using Newtonsoft.Json;
using System.IO;

namespace trips_and_travel_system.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Profile()
        {
            /*using (var db = new TripsAndTravelContext())
            {
                db.RoleMasters.Add(new RoleMaster() { RoleName = "Admin" });
                db.RoleMasters.Add(new RoleMaster() { RoleName = "Agency" });
                db.RoleMasters.Add(new RoleMaster() { RoleName = "Traveler" });
                db.SaveChanges();

                using (StreamReader sr1 = new StreamReader(Server.MapPath("~/Database/Json/Admin_Agency.json")))
                {
                    var users = JsonConvert.DeserializeObject<List<Class1>>(sr1.ReadToEnd());
                    StreamReader sr2 = new StreamReader(Server.MapPath("~/Database/Json/Agency_name.json"));
                    var agencies = JsonConvert.DeserializeObject<List<Class2>>(sr2.ReadToEnd());
                    StreamReader sr3 = new StreamReader(Server.MapPath("~/Database/Json/Posts.json"));
                    var posts = JsonConvert.DeserializeObject<List<Class3>>(sr3.ReadToEnd());

                    db.Users.Add(new User()
                    {
                        roleId = users[0].role,
                        username = users[0].username,
                        email = users[0].email_address,
                        password = users[0].password,
                        firstName = users[0].first_name,
                        lastName = users[0].last_name,
                        phone = users[0].phone,
                        photo = users[0].photo
                    });
                    db.SaveChanges();
                    for (int i = 0; i < 99; i++)
                    {
                        db.Posts.Add(new Post()
                        {
                            Agency = new Agency()
                            {
                                user = new User()
                                {
                                    roleId = users[i + 1].role,
                                    username = users[i + 1].username,
                                    email = users[i + 1].email_address,
                                    password = users[i + 1].password,
                                    firstName = users[i + 1].first_name,
                                    lastName = users[i + 1].last_name,
                                    phone = users[i + 1].phone,
                                    photo = users[i + 1].photo
                                },
                                agencyName = agencies[i].agency_name
                            },
                            title = posts[i].title,
                            details = posts[i].details,
                            tripDestination = posts[i].trip_destination,
                            tripImage = "~/Database/Images/PostDefaultImage.jpg",
                            tripPrice = float.Parse(posts[i].trip_price),
                            tripDate = DateTime.Parse(posts[i].trip_date),
                            postDate = DateTime.Parse(posts[i].post_date),
                            accepted = posts[i].accepted
                        });
                    }
                }
                db.SaveChanges();

                using (StreamReader sr4 = new StreamReader(Server.MapPath("~/Database/FAQs.json")))
                {
                    StreamReader sr = new StreamReader(Server.MapPath("~/Database/Json/Users.json"));
                    var users = JsonConvert.DeserializeObject<List<Class1>>(sr.ReadToEnd());
                    var faqs = JsonConvert.DeserializeObject<List<Class4>>(sr4.ReadToEnd());
                    for (int i = 0; i < 99; i++)
                    {
                        db.FAQs.Add(new FAQ()
                        {
                            traveler = new User()
                            {
                                roleId = users[i].role,
                                username = users[i].username,
                                email = users[i].email_address,
                                password = users[i].password,
                                firstName = users[i].first_name,
                                lastName = users[i].last_name,
                                phone = users[i].phone,
                                photo = users[i].photo
                            },
                            agencyId = i + 1,
                            postId = i + 1,
                            question = faqs[i].question,
                            answer = faqs[i].answer
                        });
                    }
                }
                db.SaveChanges();
            }*/
            return View();
        }
        public ActionResult Posts()
        {
            return View();
        }
        public ActionResult Users()
        {
            return View();
        }
        public ActionResult PostsRequests()
        {
            return View();
        }
    }
}