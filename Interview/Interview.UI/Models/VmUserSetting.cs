﻿using Interview.Entities;

namespace Interview.UI.Models
{
    
    public class VmUserSetting : VmBase
    {

        public VmUserSetting()
        {
            EmailTemplateEquities = new List<VmUserSettingEquity>();
            Equities = new List<VmEquity>();
        }

        public Guid ContestId { get; set; }
        public Guid? UserLanguageId { get; set; }
        public Guid RoleId { get; set; }
        public Guid UserId { get; set; }
        public string? UserFirstname { get; set; }
        public string? UserLastname { get; set; }
        public bool? IsExternal { get; set; }
        public DateTime DateInserted { get; set; }

        public UserLanguage? UserLanguage { get; set; }
        public Role? Role { get; set; }

        // Many to Many
        // https://learn.microsoft.com/en-us/ef/core/modeling/relationships/many-to-many
        public List<VmUserSettingEquity> EmailTemplateEquities { get; set; }
        public List<VmEquity> Equities { get; set; }

    }

}
