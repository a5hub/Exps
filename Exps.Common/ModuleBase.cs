﻿using Autofac;
using Exps.Common.Commands;

namespace Exps.Common
{
    public abstract class ModuleBase : Module
    {
        protected void RegisterAll(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(this.GetType().Assembly)
                .AsClosedTypesOf(typeof(IHandlerCommand<>));
        }
    }
}
