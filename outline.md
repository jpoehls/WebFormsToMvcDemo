# Title

## Intro to me

* I'm Joshua.
* I work at InterWorks.
* InterWorks rocks.

## What I hope you get out of this

* Recipe for taking an existing WebForms app you have and migrating it to MVC.
* I want you to leave feeling confident and ready to add some MVC to your app on Monday morning.

## MVC Basics

* Controllers
* Views
* Routing

* Have links ready for learning resources.

## Our WebForms app

* Quick walkthrough of it.
* Summarize what we will be doing.

## Step 1

* Setup project for MVC 3

* Have links ready for NuGet package and how to post.

## Step 2

* Create MVC layouts to mirror your MasterPages
* Intro to Razor

## Step 3

* Create a new MVC controller
* Create a new MVC view
* Intro to ViewModels and ViewBag
* Add tests for new controller (assert what is in ViewBag and ViewResult).

* Have MVC Mocking helpers ready.

## Step 4

* Make the view accessible to authenticated users only.
* Show how to add role-based authorization. ([AuthorizeAttribute] on controller or action).

## Step 5

* Give the view a fatal exception.
* Show default exception handling (none).
* Add [HandleError] as a global filter.
* Show custom exception handling in place.

## Step 6

* Recap. Now we've seen how to get MVC in your project.
* ... how to add new MVC pages using layouts that match the rest of your site.
* ... how to secure those MVC pages under the same security model as the rest of your site.
* ... how to add custom error handling
* Now let's work on migrating an existing page to MVC.

## Step 7

* Show existing WebForms CRUD pages.
* Create new controller and views.
* Migrate code.

* Make sure CRUD page uses `<asp:ScriptManager />`, `<asp:GridView />` and validators.
* Have Script Manager replacement ready.
* Have GridView replacement ready.

## Step 8

* Migrate CRUD page JavaScript
* Show working MVC crud pages

* WebForms JavaScript should use static classes w/ state.

## Step 9

* Add JavaScript tests
* Overview principals for testable JavaScript
    * No static classes with state.

* Have JavaScript learning links ready.

## Step 10

* Routing. Make new MVC page's URL the same as the old WebForms page.

## Step 11

* Permission checks in views. Show how to show/hide stuff based on user permissions.

## Step 12

* Specific examples. Moving from an Update Panel to jQuery and a Partial View Result.