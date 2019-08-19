﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookingSystem.Domain.WebUI
{
    public class MenuVM : IModel
    {
        public MenuVM()
        {
            SubMenu = new List<MenuVM>();
        }

        [Required]
        public int Id { get; set; }

        [Required]
        public int ParentId { get; set; }

        [Required]
        public string Title { get; set; }

        public int Order { get; set; }
        public string IconClass { get; set; }

        public bool IsActive { get; set; }
        public List<MenuVM> SubMenu { get; set; }
    }
}