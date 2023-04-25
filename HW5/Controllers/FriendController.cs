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
                return RedirectToAction("Index");
            }
            else
            {
                return View(friend);
            }

        }

        public IActionResult Edit(int? id)
        {
            var friend = friends.FirstOrDefault(f => f.Id == id);
            if (id == null || friend == null)
            {
                return NotFound();
            }
            return View(friend);
        }

        [HttpPost]
        public IActionResult Edit(int? id, Friend updatedFriend)
        {
            var friend = friends.FirstOrDefault(f => f.Id == id);
            if (id == null || friend == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                friend.Id = updatedFriend.Id;
                friend.Name = updatedFriend.Name;
                friend.Place = updatedFriend.Place;

                return RedirectToAction("Index");
            }
            else
            {
                return View(friend);
            }
        }

        public IActionResult Details(int? id)
        {
            var friend = friends.FirstOrDefault(f => f.Id == id);
            if (id == null || friend == null)
            {
                return NotFound();
            }

            return View(friend);
        }

        public IActionResult Delete(int? id)
        {
            var friend = friends.FirstOrDefault(f => f.Id == id);
            if (id == null || friend == null)
            {
                return NotFound();
            }

            return View(friend);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var friend = friends.FirstOrDefault(f => f.Id == id);
            if (id == null || friend == null)
            {
                return NotFound();
            }

            if (friend != null)
            {
                friends.Remove(friend);
            }

            return RedirectToAction(nameof(Index));
        }

    }
}