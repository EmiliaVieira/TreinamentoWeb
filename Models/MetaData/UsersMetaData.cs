using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TreinamentoWeb.Models.MetaData
{
    public class UsersMetaData
    {

        [Display(Name = "name", ResourceType = typeof(Resources.Strings))]
        [Required(ErrorMessageResourceType = typeof(Resources.Strings), ErrorMessageResourceName = "required")]
        [MaxLength(100, ErrorMessageResourceType = typeof(Resources.Strings), ErrorMessageResourceName ="maxLength100")]
        public string name { get; set; }

        [Display(Name = "email", ResourceType = typeof(Resources.Strings))]
        [Required(ErrorMessageResourceType = typeof(Resources.Strings), ErrorMessageResourceName = "required")]
        [MaxLength(100, ErrorMessageResourceType = typeof(Resources.Strings), ErrorMessageResourceName = "maxLength100")]
        [RegularExpression(@"^(([A-Za-z0-9]+_+)|([A-Za-z0-9]+\-+)|([A-Za-z0-9]+\.+)|([A-Za-z0-9]+\++))*[A-Za-z0-9]+@((\w+\-+)|(\w+\.))*\w{1,63}\.[a-zA-Z]{2,6}$",
            ErrorMessageResourceType = typeof(Resources.Strings),
            ErrorMessageResourceName = "invalidEmail")]
        public string email { get; set; }

        [Display(Name = "ldap_uid", ResourceType = typeof(Resources.Strings))]
        [Required(ErrorMessageResourceType = typeof(Resources.Strings), ErrorMessageResourceName = "required")]
        [MaxLength(100, ErrorMessageResourceType = typeof(Resources.Strings), ErrorMessageResourceName = "maxLength100")]
        public string ldap_uid { get; set; }

        [Display(Name = "ative", ResourceType = typeof(Resources.Strings))]
        public string ative { get; set; }

        [Display(Name = "password", ResourceType = typeof(Resources.Strings))]
        [Required(ErrorMessageResourceType = typeof(Resources.Strings), ErrorMessageResourceName = "required")]
        [MaxLength(100, ErrorMessageResourceType = typeof(Resources.Strings), ErrorMessageResourceName = "maxLength100")]
        public string password { get; set; }
    }
}