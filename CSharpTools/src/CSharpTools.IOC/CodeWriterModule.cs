﻿using Autofac;
using CSharpTools.CodeWriter.Domain.Builders;
using System;

namespace CSharpTools.IOC
{

    public class CodeWriterModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.RegisterType<InterfaceBuilder>()
                .AsImplementedInterfaces();
            builder.RegisterType<PropertyBuilder>()
                .AsImplementedInterfaces();
            builder.RegisterType<NamespaceBuilder>()
                .AsImplementedInterfaces();
        }
    }
}
