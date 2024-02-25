using System;
using System.Collections.Generic;

namespace EvceApi.Data.Entities;

public partial class OsusrEvceUtilizador
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Email { get; set; }

    public int? Createdby { get; set; }

    public DateTime? Createddate { get; set; }

    public int? Modifiedby { get; set; }

    public DateTime? Modifieddate { get; set; }

    public bool? Isactive { get; set; }

    public bool? Isadmin { get; set; }

    public DateTime? Lastlogon { get; set; }

    public bool? Changepassword { get; set; }

    public bool? Isexternal { get; set; }

    public int? Entidadeid { get; set; }

    public bool? Isadminentidade { get; set; }

    public bool? IsAuthenticated { get; set; }

    public DateTime? AuthenticationExpiredAt { get; set; }
}
