using HW5.Models;

using Microsoft.AspNetCore.Mvc;

namespace HW5.Controllers
{
    public class FriendController : Controller
    {
        static List<Friend> friends = new List<Friend>()
        {
            new Friend
            {
                Id = 1,
                Name = "Ksyusha",
                Place = "Lviv"
            },
            new Friend
            {
                Id = 2,
                Name = "Egor",
                Place = "Dnipro"
            },
            new Friend
            {
                Id = 3,
                Name = "Sasha",
                Place = "Kyiv"
            }
        };

        public IActionResult Index()
        {
            return View(friends);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Friend friend)
        {

            if (ModelState.IsValid)
            {
                friends.Add(friend);
                return View("Index", friends);
            }
            else
            {
                return View(friend);
            }

        }

        public IActionResult Edit(int id)
        {
            var friend = friends.First(f => f.Id == id);
            return View(friend);
        }

        [HttpPost]
        public IActionResult Edit(Friend friend)
        {
            if (ModelState.IsValid)
            {
                friends.Add(friend);
                return View("Index", friends);
            }
            else
            {
                return View(friend);
            }
        }

    }
}
