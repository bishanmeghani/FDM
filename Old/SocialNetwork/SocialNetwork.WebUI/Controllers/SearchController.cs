﻿using SocialNetwork.DataAccess;
using SocialNetwork.Logic;
using SocialNetwork.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SocialNetwork.WebUI.Controllers
{
    public class SearchController : Controller
    {
        SearchLogic searchLogic;
        Repository<User> userRepo;
        Repository<Post> postRepo;
        List<UserPostViewModel> viewModels;
        List<UserViewModel> userModels;
        UserAccountLogic userLogic;


        public SearchController()
        {
           postRepo = new Repository<Post>();
           userRepo = new Repository<User>();
           searchLogic = new SearchLogic(postRepo,userRepo);
           viewModels = new List<UserPostViewModel>();
           userModels = new List<UserViewModel>();
           userLogic = new UserAccountLogic(new Repository<User>());
        }

        // GET: Search
        [HttpGet]
        [Authorize]
        public ActionResult Search()
        {
            return View("Results");
        }

        [HttpPost]
        [Authorize]
        public ActionResult SearchResults(string searchString)
        {
            User user = userLogic.ViewAccountInfo(User.Identity.Name);          

            try
            {
                if (searchLogic.CheckIfSearchTermInPostDataBase(searchString) == true)
                {
                    List<Post> results = searchLogic.SearchForCode(searchString);
                    foreach (var result in results)
                    {
                        if (result is UserPost) viewModels.Add(new UserPostViewModel() { post = (UserPost)result, user = (result as UserPost).user });
                    }

                    return View("Results", viewModels);
                }

                if (searchLogic.CheckIfSearchTermInUserDataBase(searchString) == true) 
                {
                    List<User> userResult = searchLogic.SearchForUserByName(searchString);
                    foreach (var result in userResult)
                    {
                        if (result is User) userModels.Add(new UserViewModel() { user = result, userLoggedIn = user });
                    }
                    return View("UserResults", userModels);                
                }
            }
            catch (EntityNotFoundException)
            {
                 return View("Error");
            }
            return View("Error");
        }


        [HttpPost]
        public ActionResult AddFriend(UserViewModel friendViewModel)
        {
            User friend = userLogic.ViewAccountInfo(friendViewModel.user.username);
            User user = userLogic.ViewAccountInfo(User.Identity.Name);
            if (Request.IsAjaxRequest())
            {
                try
                {
                    userLogic.AddFriend(user, friend);
                    return PartialView("_FriendAdded");
                }
                catch (EntityAlreadyExistsException)
                {
                    return PartialView("_FriendAlreadyAdded");
                }
                catch (SameEntityException)
                {
                    return PartialView("_UserAddingItself");
                }                
            }
            return RedirectToAction("AddFriend");
        }

        [HttpPost]
        public ActionResult RemoveFriend(UserViewModel friendViewModel)
        {
            User friend = userLogic.ViewAccountInfo(friendViewModel.user.username);
            User user = userLogic.ViewAccountInfo(User.Identity.Name);

            if (Request.IsAjaxRequest())
            {
                try
                {
                    userLogic.RemoveFriend(user, friend);
                    return PartialView("_FriendRemoved");
                }
                catch (UserIsNotYourFriendException)
                {
                    return PartialView("_UserIsNotYourFriend");
                }
                catch (EntityNotFoundException)
                {
                    return PartialView("_UserNotInTheDatabase");
                }
            }
            return RedirectToAction("RemoveFriend");
        }

        [Authorize]
        public ActionResult ProfilePage(string username)
        {
            Repository<User> userRepo = new Repository<User>();
            User user = userRepo.First(u => u.username == username);
            ProfilePageViewModel viewModels = CreateViewModelsForUser(user);

            return View("ProfilePage", viewModels);
        }

        public ProfilePageViewModel CreateViewModelsForUser(User user)
        {
            ProfilePageViewModel posts = new ProfilePageViewModel();

            List<UserPost> listposts = new List<UserPost>();

            foreach (UserPost p in user.posts)
            {
                listposts.Add(p);
            }

            posts.userpost = listposts;

            posts.user = user;

            return posts;
        }
    }
}