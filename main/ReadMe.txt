===============================================
2015-07-09 ASP.NET MVC ACDF application
=================================================================
/////////////////////////
// Internet Ref. projects
// "Render therefore unto Caesar the things which are Caesar's; and unto God the things that are God's."
////////////////////////////////////////////////////////////////////////////////////////////////////////

////////////////////////
// TODO GENERAL
////////////////////////////////////////////////////////////////////////////////////////////////////////
- [00001] Version 1
    Codeplex http://acdfcasa.codeplex.com/
    ==> done
- [00002] Version 2
    From Y:\MesProjets\_Visual Studio 2013\Projects\AcdfCasa\Main\IkoulaACDF
    From Y:\MesProjets\_Projets 2015\Codeplex\main\Cdf54.Projet2015
    Codeplex http://acdfcasav2.codeplex.com/
    ==> done
- [00003] Version 2.1
    - ADD: SignalR Users online counter
==> XXXX
- [00004] Version 2.2
    - ADD: SignalR Chat
==> XXXX



- [xxxxx]  
==> XXXX

////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////

VERSION PRODUIT : 2.1

////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////

////////////////////////
// TODO
////////////////////////////////////////////////////////////////////////////////////////////////////////
- [xxxxx] -ADD: SignalR Users online counter
    ==> XXXX



- [xxxxx]  
==> XXXX
////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////

VERSION PRODUIT : 2

////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////

////////////////////////
// TODO
////////////////////////////////////////////////////////////////////////////////////////////////////////
- [10005] - ADD: Gravatar
    ==> done
- [10006] - ADD: Social network login
    ==> done
- [10007] - ADD: Social network picture
    ==> done
- [10008] - ADD: ForgotPassword feature
    ==> done
- [10009] - ADD: Email confirmation in AccountController/Register
    ==> done
- [10010] - ADD: Avatar in _LoginPartial
    ==> done
- [10011] - ADD: [ValidateFile] in Models/ManageViewModels for HttpPostedFileWrapper Avatar
    ==> done
- [10012] - ADD: Countries dropdownlist in in Models/ManageViewModels for ChangeProfileViewModel
    ==> done
- [10013] - ADD: Webcam for avatar
    ==> done
- [10014] - ADD: Show claims feature   
    ==> done
- [10015] - MODIF: Change avatar place
    ==> done
- [10016] - BUG: ASP.Net MVC 5 w/identity 2.2.0 Log off not working  
    ==> done
- [10017] - CHANGE: use Pseudo as ViewName instead of UserName
    ==> done
- [10018] - CHANGE: in PhotoViewModel and ModelAcdf replace UserName by Pseudo or ViewName 
    ==> XXXX
- [10019] - CHANGE: Dont remove definitively a user
    ==> XXXX


- [xxxxx] 
    
    ==> XXXX
////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////

////////////////////////
// Version 2.0.Alpha
////////////////////////////////////////////////////////////////////////////////////////////////////////
- 2015-07-09: Project template C#/web/Application Web ASP.NET (Framework 4.6) MVC + WebApi
- ADD: NuGet Packages:
    For Menus:
    <package id="metisMenu" version="1.1.3.1" targetFramework="net46" userInstalled="true" />
    <package id="font-awesome" version="4.3.0" targetFramework="net46" userInstalled="true" />

    <package id="Bootstrap.Datepicker" version="1.4.0" targetFramework="net46" userInstalled="true" />
    <package id="Fancybox" version="2.1.5" targetFramework="net46" userInstalled="true" />
    <package id="jQuery.InputMask" version="3.1.63" targetFramework="net46" userInstalled="true" />
- CHANGE: /App_Start/BundleConfig.cs consequently
- COPY: /Content/fonts/*.* to /fonts (correct bug)
- ADD: _Layout.cshtml from previous version (VS2013) with some modifs
- ADD: site.css from previous version (VS2013) with some modifs
- ADD: App_Code/MyRazorHelpers.cshtml from previous version (VS2013) with some modifs
- ADD: Scripts/metisMenu.acdf.js
- ADD: DefaultConnection in web.config
- EXEC: PM> Enable-Migrations -ContextTypeName Ja.Mvc.Acdf.Models.ApplicationDbContext –EnableAutomaticMigrations
- EXEC: PM> Add-Migration Initialisation
- EXEC: PM> Update-Database
- ADD: user = admin@free.fr password = P@ssw0rd2015
- [10000]: No ApplicationRoleManager in this template
    http://www.codeproject.com/Articles/762428/ASP-NET-MVC-and-Identity-Understanding-the-Basics
    *** From Cdf54.Ja.SignalR.Chat project ***
    - ADD: AdminViewModel
    - ADD: RolesAdminController
    - ADD: Views/RolesAdmin files
- [10001] ADD: public string Pseudo { get; set; } in IdentityModels
    - EXEC: PM> Add-Migration Pseudo
    - EXEC: PM> Update-Database
- [10002] ADD: Login with name or email
    http://anthonychu.ca/post/aspnet-identity-20---logging-in-with-email-or-username/
    *** From Cdf54.Ja.SignalR.Chat project ***
    - ADD: public string PseudoOrEmail { get; set; } in AccountViewModels/LoginViewModel
    - ADD: public string Pseudo { get; set; } in AccountViewModels/RegisterViewModel
    - CHANGE: Register and Login Action in AccountController
    - CHANGE: Register and Login View
- [10003] use Pseudo as ViewName, UserName is ReadOnly
    - CHANGE: _LoginPartial.cshtml
    - CHANGE: _Layout.cshtml
- 2015-07-14: New properties added to extend Application User class
    - [10004] ADD: User properties for profile.
        - EXEC: PM> Add-Migration Profile
        - EXEC: PM> Update-Database
        - ADD: Models/ManageViewModels/ChangeProfileViewModel and ChangePhotoViewModel
        - ADD: Controllers/ManageController/ChangeProfile ChangePhoto
        - ADD: Scripts/app/cdf54.ja.utils.js , Ja.Mvc.Acdf.namespace.js , Ja.Mvc.Acdf.avatar.js
        - ADD: Views/Manage/ChangePhoto.cshtml and ChangeProfile.cshtml views 
    - [10005] - ADD: Gravatar
    - [10006] - ADD: Social network login
    - [10007] - ADD: Social network picture
        - EXEC: PM> Add-Migration GravSoNetPic
        - EXEC: PM> Update-Database
    - [10008] - ADD: ForgotPassword feature
    - [10009] - ADD: Email confirmation in AccountController/Register
    - [10010] - ADD: Avatar in _LoginPartial
    - [10011] - ADD: [ValidateFile] in Models/ManageViewModels for HttpPostedFileWrapper Avatar
        - ADD: CustomFiltersAttributes/MyCustomAttributes.cs from IkoulaACDF
    - [10012] - ADD: Countries dropdownlist in in Models/ManageViewModels for ChangeProfileViewModel
    - [10013] - ADD: Webcam for avatar
    - [10014] - ADD: Show claims feature
        - ADD: Manage/GetUserClaims and GetUserIdentityClaims
- 2015-07-28 COMMIT: Codeplex http://acdfcasav2.codeplex.com/ (2018) Archivage initial
- 2015-07-28 COMMIT: Codeplex http://acdfcasav2.codeplex.com/ (2021) ADD: App_Data\Acdf.mdf database file
- [10015] - MODIF: Change avatar place
    in _LoginPartial and _Layout
    ==> done
- 2015-07-30 COMMIT: Codeplex http://acdfcasav2.codeplex.com/ (2178) MODIF: Change avatar place
- [10016] - BUG: ASP.Net MVC 5 w/identity 2.2.0 Log off not working
    - http://stackoverflow.com/questions/28642284/asp-net-mvc-5-w-identity-2-2-0-log-off-not-working
    ==> done
- [10017] - CHANGE: use Pseudo as ViewName instead of UserName
    see Create and Edit in PhotoController
    ==> done
- 2015-08-02 COMMIT: Codeplex http://acdfcasav2.codeplex.com/ (?) MODIF: [10016] [10017] Minor modifications


////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////

VERSION PRODUIT : 1

////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////

==========
WORK ITEMS
====================================
* Contact page
* Photo page [provisional]
* About page
* Carousel
* Video gallery
* Users managment
* Documents managment
* Forum
* Photo gallery
* Thought for the day
=====
TODO
====================================
* Google Analytics ==> done
* CHANGE: Video title position ==> done
* CHANGE: Home prev-next image ==> done
* ADD: Contact view map details in popup window ==> done
* BUG: Video popup ==> OK (bad name lib in BundleConfig.cs)
* Photo thumbnails ==> done
* BUG: Index photo page lose responsive when using tablesorter
* Exception managment ==> done
* See static method for saving Avatar ==> done
* BUG: thumbPath lost when edit record ==> done
* BUG: Date culture datepicker ==> done
* BUG: Security a User can edit anPlace profil : http://localhost:35772/ACDF/account/edit/toto ==> done
* ADD: Message when editing profile or photo ==> done
* CHANGE: Create photos
====================================
Version 00 = V0.0.0.0 {0.0.Alpha}
====================================
* ADD: Change some styles in Site.css
* ADD: MyRazorHelpers.cshtml
* ADD: Google map in Contact
* Install-Package PagedList.Mvc 
* ADD: Photo Controller, Views, ViewModel with modal view
* Install-Package Fancybox 2.1.5
* ADD: Fancybox instead of bootstrap modal with fb version 2.1.5 vs 1.3.4
* ADD: Video Controller, View with fancybox media
* ADD: manualy flexsplider plugin
* ADD: Carousel in Home page
====================================
Version 01 = V0.0.0.1 {0.1.Alpha}
====================================
* ADD: Photo edition capabilities (CRUD) with DropDownListFor usage
* DEL: CategoryName and SubCategoryName from AcdfPhoto table
* Install manualy jquery.tablesorter and jquery.tablesorter.widgets v2.0 (thead tbody must be present)
    added images/bg.gif,asc.gif,desc.gif
    added CUSTOMIZE TABLES in sites.css
* ADD: Thumbnails
* ADD: ThumPath column
* ADD: CategoryId, SubCategoryId columns
* DEL: CategoryName, SubCategoryName columns
====================================
Version 02 = V0.0.0.2 {0.2.Alpha}
====================================
* ADD: Trace capabilities in Utils.cs
* ADD: MyErrorController
* ADD: <customErrors> in Web.Config
* ADD: Views/MyError
* ADD: Completed RegisterViewModel + CustomFiltersAttributes/ValidateFileAttribute
* ADD: public class IdentityManager
* ADD: class EditUserViewModel, SelectUserRolesViewModel, SelectRoleEditorViewModel in AccountViewModel.cs
* ADD: Edit, Delete, UserRoles actions in AccountController and modified Register
* MODIF: View Register
* ADD: Util, SavePhotoFileToDisk
* ADD: uploads directory and BlankPhoto.jpg
* ADD: Views/Account/Index.cshtml
* ADD: Views/Account/UserRoles.cshtml
* ADD: Shared/EditorTemplate/SelectRoleEditorViewModel.cshtml
* ADD: Initialization to Migrations/Configuration.cs
* MODIF: _LoginPartial / @Html.ActionLink("Bonjour " + User.Identity.GetUserName() + "!", "Edit", "Account", routeValues: new{id=User.Identity.GetUserName()}, htmlAttributes: new { title = "Administrer"})
* PM > Enable-Migrations -ContextTypeName IkoulaACDF.Models.ApplicationDbContext –EnableAutomaticMigrations
* PM> Add-Migration Initialisation
* PM> Update-Database (after delete existing tables from NorthWind54)
* ADD: in EditUserViewModel for dropdownlist
        public IEnumerable<System.Web.Mvc.SelectListItem> YearFirst { get; set; }
        public IEnumerable<System.Web.Mvc.SelectListItem> YearLast { get; set; }
====================================
Version 03 = V0.0.0.3 {0.3.Alpha}
====================================
* ADD: language "fr" to datapicker
* BUG: birthday date in index ==>  [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
* ADD: Photo Actions: Category, SubCategory, GetPhotos and GetNoSubCategoryPhotos with Views
    Views are provisionnal
* ADD: Photo Action: RecentPhoto with View
    View is provisionnal
* ADD: Photo Gallery
* BUG: Image deformation when resized
====================================
Version 04 = V0.0.0.4 {0.4.Alpha}
====================================
* ADD: RegistrationDate
    PM> Add-Migration RegistrationDate
    PM> Update-Database
* TODO: Add http://tympanus.net/codrops/2011/09/20/responsive-image-gallery/ but not used pb with fancybox
* ADD: Review some styles
* ADD: font-awesome http://astronautweb.co/snippet/font-awesome/ <i class="fa fa-external-link"></i>
* Refactor BundleConfig
* ADD: _RecentPhoto.cshtml for Home/Index/NEW
* ADD: Left and right side in Home page
* ADD: Modal _RecentPhotoPartial.cshtml and _HomeRecentPhotoPartial.cshtml
* ADD: Manualy pdf.js and open in fancybox: 
    http://stackoverflow.com/questions/13840524/using-pdf-js-in-asp-net-mvc3
    http://stackoverflow.com/questions/12681588/is-it-possible-to-open-a-pdf-with-fancybox-2-1-in-ie8
* ADD: PdfViewer controller + Index and Viewer views
* ADD: AcdfGuessBook table
* ADD: GuessBookController
* BUG: GuessBook user must be authenticated to sign GuessBook ==> done [Authorize(Roles = "User")] in GuessBook/Create 
* ADD: Change Home/Index action to use _HomeAspNetUserPartial and _HomeGuessBookPartial Home partial views
* BUG: Exception when delete user <<The DELETE statement conflicted with the REFERENCE constraint "FK_AcdfGuessBook_AspNetUsers".>> ==> Added DELETE CASCADE 
* ADD: Birthday in Home page
* BUG: Birthday Date in Edit ==> done
* BUG: datepicker dont retreive correct date after POST ==> correct in Edit, Create and Date .cshtml
* ADD: GO TOP button
====================================
Version 05 = V0.0.0.5 {0.5.Alpha}
====================================
* CHANGE: Site style http://startbootstrap.com/sb-admin-v2
* ADD: Annotation RegularExpression in Regeister and Edit account
* ADD: RestrictedUsersListViewModel, RestrictedUsersList action, RestrictedUsersList.cshtml view
* ADD: Send email to new user
* ADD: function in GetPhotos to set div.panel-body with p.flex-caption text value
* BUG: Exception in http://www.jow-alva.net/ACDF/Photo/GetPhotos?categoryID=16&subCategoryID=50 no element
* TODO: add edition capability in GetPhotos
* ADD: Email verification http://code.msdn.microsoft.com/ASPNET-MVC-5-Conferma-30d8b426
* ADD: PM> Add-Migration ConfirmedEmail & PM> Update-Database
* ADD: _HomeLastFiveGuessBookPartial.cshtml
* ADD: Home/Tramp.cshtml
* ADD: Action /Home/Anecdotes
* BUG: need ViewBag to be global for badges value ==> Resolve using Application var: 
    this.HttpContext.ApplicationInstance.Application.Add("CountMembers", ViewBag.CountMembers); Not completely resolved
====================================
Version 06 = V0.0.0.6 {0.6.Alpha}
====================================
* ADD: Google Docs in place of pdf.js
* BUG: julio plusieurs inscriptions ? ==> ADD: if (user.ConfirmedEmail == false) in ConfirmEmail(string Token, string Email) dont know if resolve pb ?
* BUG: case à cocher ?
* BUG: Medias menu hidden in mobile mode body {padding-top: 60px to 120px; in Site.css
* CHANGE: Refactoring home page
* BUG: Dont save guessbook if empty ==> if (acdfguessbook.Message != string.Empty) in GuessBook controller
* BUG: Dont show user if email not confirmed ==> where u.ConfirmedEmail == true
* INSTALL: Install-Package jQuery.InputMask -Version 2.5.0 
* TODO: Version with local database
* ID: using Microsoft.AspNet.Identity; for extension method: User.Identity.GetUserId()
* TODO: Slider filter ==> ADD periode in GetPhoto
* BUG Edit account dont display errors
* ADD: Dropdownlist for period
====================================
Version 07 = V0.0.0.7 {0.7.Alpha}
====================================
* TODO: Messagerie
* BUG: With empty database dont progress to GetPhotos
* TODO: Review Photo Database Schema
* ADD: Folder photos creation
* TODO: return on subCategory AUCUNE = 33
* TODO: CreateNew

