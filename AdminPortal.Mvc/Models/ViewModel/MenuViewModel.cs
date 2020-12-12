using System;
using System.Collections.Generic;

namespace AdminPortal.Mvc.Models.ViewModel
{
    public class MenuViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<SubMenu> SubMenu { get; set; }
        public string DisplayName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string TargetLink { get; set; }
        public string icon { get; set; }
    }

    public class SubMenu
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string TargetLink { get; set; }
        public List<ChildMenu> ChildMenu { get; set; }
    }

    public class ChildMenu
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string TargetLink { get; set; }
    }
}
