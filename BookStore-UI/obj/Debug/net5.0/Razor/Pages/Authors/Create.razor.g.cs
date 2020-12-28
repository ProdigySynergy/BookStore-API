#pragma checksum "C:\Users\sageads\Documents\Dev\DOTNET\BookStore\BookStore-UI\Pages\Authors\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9717bfca858be8d53ffc0ae33184397f0906c06"
// <auto-generated/>
#pragma warning disable 1591
namespace BookStore_UI.Pages.Authors
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sageads\Documents\Dev\DOTNET\BookStore\BookStore-UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sageads\Documents\Dev\DOTNET\BookStore\BookStore-UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sageads\Documents\Dev\DOTNET\BookStore\BookStore-UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sageads\Documents\Dev\DOTNET\BookStore\BookStore-UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sageads\Documents\Dev\DOTNET\BookStore\BookStore-UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sageads\Documents\Dev\DOTNET\BookStore\BookStore-UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sageads\Documents\Dev\DOTNET\BookStore\BookStore-UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sageads\Documents\Dev\DOTNET\BookStore\BookStore-UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sageads\Documents\Dev\DOTNET\BookStore\BookStore-UI\_Imports.razor"
using BookStore_UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sageads\Documents\Dev\DOTNET\BookStore\BookStore-UI\_Imports.razor"
using BookStore_UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\sageads\Documents\Dev\DOTNET\BookStore\BookStore-UI\_Imports.razor"
using BookStore_UI.Static;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\sageads\Documents\Dev\DOTNET\BookStore\BookStore-UI\_Imports.razor"
using BookStore_UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\sageads\Documents\Dev\DOTNET\BookStore\BookStore-UI\_Imports.razor"
using BookStore_UI.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\sageads\Documents\Dev\DOTNET\BookStore\BookStore-UI\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\sageads\Documents\Dev\DOTNET\BookStore\BookStore-UI\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sageads\Documents\Dev\DOTNET\BookStore\BookStore-UI\Pages\Authors\Create.razor"
           [Authorize(Roles = "Administrator")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/authors/create/")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"card-title\">Create New Author</h3>\r\n<hr>\r\n<br>");
#nullable restore
#line 12 "C:\Users\sageads\Documents\Dev\DOTNET\BookStore\BookStore-UI\Pages\Authors\Create.razor"
 if (!isSuccess)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BookStore_UI.Shared.ErrorMessage>(1);
            __builder.AddAttribute(2, "Message", "Something Went Wrong With the Operation");
            __builder.CloseComponent();
#nullable restore
#line 15 "C:\Users\sageads\Documents\Dev\DOTNET\BookStore\BookStore-UI\Pages\Authors\Create.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 18 "C:\Users\sageads\Documents\Dev\DOTNET\BookStore\BookStore-UI\Pages\Authors\Create.razor"
                 Model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 18 "C:\Users\sageads\Documents\Dev\DOTNET\BookStore\BookStore-UI\Pages\Authors\Create.razor"
                                       CreateAuthor

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n    ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group");
                __builder2.AddMarkupContent(13, "<label for=\"firstname\">First Name</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(14);
                __builder2.AddAttribute(15, "class", "form-control");
                __builder2.AddAttribute(16, "id", "firstname");
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\sageads\Documents\Dev\DOTNET\BookStore\BookStore-UI\Pages\Authors\Create.razor"
                                Model.Firstname

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Model.Firstname = __value, Model.Firstname))));
                __builder2.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Model.Firstname));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group");
                __builder2.AddMarkupContent(23, "<label for=\"lastname\">Last Name</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "class", "form-control");
                __builder2.AddAttribute(26, "id", "lastname");
                __builder2.AddAttribute(27, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\sageads\Documents\Dev\DOTNET\BookStore\BookStore-UI\Pages\Authors\Create.razor"
                                Model.Lastname

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Model.Lastname = __value, Model.Lastname))));
                __builder2.AddAttribute(29, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Model.Lastname));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n    ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group");
                __builder2.AddMarkupContent(33, "<label for=\"bio\">Biography</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(34);
                __builder2.AddAttribute(35, "class", "form-control");
                __builder2.AddAttribute(36, "id", "bio");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Users\sageads\Documents\Dev\DOTNET\BookStore\BookStore-UI\Pages\Authors\Create.razor"
                                    Model.Bio

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Model.Bio = __value, Model.Bio))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Model.Bio));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n    ");
                __builder2.AddMarkupContent(41, "<button class=\"btn btn-primary\" type=\"submit\"><span class=\"oi oi-pencil\"></span>\r\n        Create Author\r\n    </button>\r\n    ");
                __builder2.OpenElement(42, "button");
                __builder2.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\sageads\Documents\Dev\DOTNET\BookStore\BookStore-UI\Pages\Authors\Create.razor"
                      BackToList

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "class", "btn btn-outline-secondary");
                __builder2.AddMarkupContent(45, "<span class=\"oi oi-media-skip-backward\"></span>\r\n        Back To List\r\n    ");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\sageads\Documents\Dev\DOTNET\BookStore\BookStore-UI\Pages\Authors\Create.razor"
      
    private Author Model = new Author();
    private bool isSuccess = true;

    private async Task CreateAuthor()
    {
        isSuccess = await _repo.Create(Endpoints.AuthorsEndpoint, Model);
        if (isSuccess)
        {
            _toastService.ShowSuccess("Author Created Successfully", "");
            BackToList();
        }
    }

    private void BackToList()
    {
        _navManager.NavigateTo("/authors/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService _toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorRepository _repo { get; set; }
    }
}
#pragma warning restore 1591