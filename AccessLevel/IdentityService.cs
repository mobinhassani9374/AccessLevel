using AccessLevel.Attributes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace AccessLevel
{
    public class IdentityService
    {
        public List<Models.Module> GetModule()
        {
            var assembly = Assembly.GetExecutingAssembly();

            var controllers = assembly
                  .GetTypes()
                  .Where(c => typeof(Controller).IsAssignableFrom(c) &&
                  c
                  .CustomAttributes
                  .Any(i => i.AttributeType
                  .Equals(typeof(HasModuleAttribute))))
                  .ToList();

            var modules = new List<Models.Module>();

            controllers.ForEach(c =>
            {
                var module = new Models.Module();

                var attribute = c
                .CustomAttributes
                .FirstOrDefault(i => i.AttributeType.Equals(typeof(HasModuleAttribute)));

                module.Title = attribute.NamedArguments.FirstOrDefault(i => i.MemberName ==
                  "Title").TypedValue.Value?.ToString();

                module.LinkName = attribute.NamedArguments.FirstOrDefault(i => i.MemberName ==
                 "LinkName").TypedValue.Value?.ToString();

                module.Image = attribute.NamedArguments.FirstOrDefault(i => i.MemberName ==
                "Image").TypedValue.Value?.ToString();

                module.Icon = attribute.NamedArguments.FirstOrDefault(i => i.MemberName ==
               "Icon").TypedValue.Value?.ToString();

                module.Description = attribute.NamedArguments.FirstOrDefault(i => i.MemberName ==
               "Description").TypedValue.Value?.ToString();


                // actions

                var methods = c.GetMethods()
                   .Where(i => i.IsPublic && i.CustomAttributes.Any(o => o.AttributeType.Equals(typeof(HasActionAttribute))))
                   .ToList();

                methods.ForEach(u =>
                {
                    var attr = u
                    .CustomAttributes
                    .FirstOrDefault(p => p.AttributeType.Equals(typeof(HasActionAttribute)));

                    module.Actions.Add(new Models.Action
                    {
                        Title = attr.NamedArguments
                        .FirstOrDefault(p => p.MemberName == "Title")
                        .TypedValue
                        .Value?
                        .ToString(),

                        ControllerName = c.Name.Substring(0, c.Name.IndexOf("Controller")),

                        ActionName = u.Name
                    });
                });

                modules.Add(module);
            });

            return modules.OrderBy(c => c.Order).ToList();
        }
    }
}