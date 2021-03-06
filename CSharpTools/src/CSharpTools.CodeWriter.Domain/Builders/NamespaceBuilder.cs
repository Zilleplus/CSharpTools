﻿using CSharpTools.Entities;
using CSharpTools.Generic.Contracts;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpTools.CodeWriter.Domain.Builders
{
    public class NamespaceBuilder : IBuilder<NamespaceDeclarationSyntax, List<string>>
    {
        public NamespaceDeclarationSyntax Build(List<string> input)
            => SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName(String.Join(".", input)));
    }
}
