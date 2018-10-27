using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TreinamentoWeb.Models.DataContract
{
    public class Login
    {
        /// <summary>
        /// Gets or sets the username
        /// </summary>
        [Display(Name ="user", ResourceType = typeof(Resources.Strings))]
        [Required(ErrorMessageResourceType = typeof(Resources.Strings), ErrorMessageResourceName = "required")]
        [RegularExpression(@"^(([A-Za-z0-9]+_+)|([A-Za-z0-9]+\-+)|([A-Za-z0-9]+\.+)|([A-Za-z0-9]+\++))*[A-Za-z0-9]+@((\w+\-+)|(\w+\.))*\w{1,63}\.[a-zA-Z]{2,6}$",
            ErrorMessageResourceType = typeof(Resources.Strings),
            ErrorMessageResourceName ="invalidEmail")]
        public string UserName { get; set; }

        [Display(Name = "password", ResourceType = typeof(Resources.Strings))]
        [Required(ErrorMessageResourceType = typeof(Resources.Strings), ErrorMessageResourceName = "required")]
        public string Password { get; set; }
    }
}