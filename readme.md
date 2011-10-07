**ASP.NET WebForms to MVC & jQuery:**  
Real-world tricks to make the switch

These demos were originally built for [Tulsa TechFest 2011](http://techfests.com/Tulsa/2011/Speakers/JoshuaPoehls/default.aspx).

## Synopsis

Have WebForms? Want MVC? No time to rewrite? You don't have to!

Come watch as we transform a pseudo-production application from WebForms to MVC using best practices and incremental strategies that you can use on your own projects!

Along the way we'll see:

* how MVC makes your life easier
* ways to incrementally migrate your app to MVC without a big rewrite
* common pitfalls (and solutions!) on the path from WebForms to MVC
* leveraging jQuery as a replacement for the `<asp:UpdatePanel />`, `<asp:GridView />`, and more!
* how to structure your JavaScript in a testable way

No slides. This will be a live coding event with unit tests along the way. I'll be showing off testing both controllers and JavaScript! You are definitely going to learn something in this session!

## Steps to add MVC 3 to Web Forms 4 project

[Hanselman's Steps](http://www.hanselman.com/blog/IntegratingASPNETMVC3IntoExistingUpgradedASPNET4WebFormsApplications.aspx)

Add these folders and files to the root of your Web Forms project:

* Content
* Controllers
* Models
* Scripts
* Views
* Global.asax

Add these references to your Web Forms project:

* Microsoft.CSharp
* System.Web.Mvc
* System.Web.WebPages
* System.Web.Razor
* System.ComponentModel.DataAnnotations

Make the following changes to `Web.config`.

	<appSettings>
   	   <add key="ClientValidationEnabled" value="true"/> 
   	   <add key="UnobtrusiveJavaScriptEnabled" value="true"/> 
	</appSettings>

	<compilation debug="true" targetFramework="4.0">
  	  <assemblies>
    	<add assembly="System.Web.Abstractions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35" />
    	<add assembly="System.Web.Helpers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35" />
    	<add assembly="System.Web.Routing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35" />
    	<add assembly="System.Web.Mvc, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35" />
    	<add assembly="System.Web.WebPages, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35" />
  	  </assemblies>
	</compilation>

	<system.web>
  	  <pages>
     	 <namespaces>
       	   <add namespace="System.Web.Helpers" />
       	   <add namespace="System.Web.Mvc" />
       	   <add namespace="System.Web.Mvc.Ajax" />
       	   <add namespace="System.Web.Mvc.Html" />
       	   <add namespace="System.Web.Routing" />
       	   <add namespace="System.Web.WebPages"/>
     	 </namespaces>
   	   </pages>
	</system.web>

	<!-- for IIS7 (including IIS Express) -->
	<system.webServer>
  	  <validation validateIntegratedModeConfiguration="false"/>
  	  <modules runAllManagedModulesForAllRequests="true"/>
	</system.webServer>

	<!-- avoid issues if you have MVC 1 or 2 in your GAC -->
	<configuration>
 	 <runtime>
    	<assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
      	  <dependentAssembly>
        	<assemblyIdentity name="System.Web.Mvc" publicKeyToken="31bf3856ad364e35" />
        	<bindingRedirect oldVersion="1.0.0.0-2.0.0.0" newVersion="3.0.0.0" />
      	  </dependentAssembly>
    	</assemblyBinding>
  	  </runtime>
	</configuration>

Update your `Global.asax.cs`:

	public static void RegisterGlobalFilters(GlobalFilterCollection filters)
	{
		filters.Add(new HandleErrorAttribute());
	}
 
	public static void RegisterRoutes(RouteCollection routes)
	{
		routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
 
		routes.MapRoute(
			"Default", // Route name
			"{controller}/{action}/{id}", // URL with parameters
			new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
		);
 
	}
 
	protected void Application_Start()
	{
		AreaRegistration.RegisterAllAreas();
 
		RegisterGlobalFilters(GlobalFilters.Filters);
		RegisterRoutes(RouteTable.Routes);
	}

Add `{E53F8FEA-EAE0-44A6-8774-FFD645390401};` to the `<ProjectTypeGuids>` in the web project file.