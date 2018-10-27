using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using TreinamentoWeb.Models.MetaData;

namespace TreinamentoWeb.Models.Entity
{
    [MetadataType(typeof(UsersMetaData))]
    public partial class users
    {
    }
}